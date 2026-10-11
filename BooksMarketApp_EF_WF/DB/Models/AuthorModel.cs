using BooksMarketApp_EF_WF.DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace BooksMarketApp_EF_WF.DB.Models;

public class AuthorModel
{
    private readonly MyDbContext _dbContext;

    public AuthorModel(MyDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Author> GetAll()
    {
        return _dbContext.Authors.ToList();
    }

    public bool SaveAuthor(Author author)
    {
        try
        {
            _dbContext.Authors.Add(author);
            _dbContext.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public Author GetAuthorById(int id)
    {
        return _dbContext.Authors.FirstOrDefault(a => a.Id == id);
    }

    public Author GetAuthorByFullName(string fullName)
    {
        return _dbContext.Authors.FirstOrDefault(a => a.FullName == fullName);
    }

    public bool CascadeRemoveAuthorById(int id)
    {
        try
        {
            var author = _dbContext.Authors
                .Include(a => a.Books)
                .FirstOrDefault(a => a.Id == id);

            if (author == null)
                return false;

            // Delete the author's books along with all related records
            foreach (var book in author.Books.ToList())
            {
                RemoveBookWithDependencies(book);
            }

            _dbContext.Authors.Remove(author);
            _dbContext.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool UpdateAuthor(Author author)
    {
        try
        {
            var existing = _dbContext.Authors.FirstOrDefault(a => a.Id == author.Id);
            if (existing == null)
                return false;

            existing.FullName = author.FullName;

            _dbContext.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    // A helper method for cascading the removal of a book along with all its dependencies
    private void RemoveBookWithDependencies(Book book)
    {
        var fullBook = _dbContext.Books
            .Include(b => b.UserStorages)
            .Include(b => b.SalesStatistics)
            .Include(b => b.BookPromotions)
            .FirstOrDefault(b => b.Id == book.Id);

        if (fullBook == null)
            return;

        _dbContext.UserStorages.RemoveRange(fullBook.UserStorages);
        _dbContext.SalesStatistics.RemoveRange(fullBook.SalesStatistics);
        _dbContext.BookPromotions.RemoveRange(fullBook.BookPromotions);
        _dbContext.Books.Remove(fullBook);
    }
}