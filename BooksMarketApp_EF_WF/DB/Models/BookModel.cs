using BooksMarketApp_EF_WF.DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace BooksMarketApp_EF_WF.DB.Models;

public class BookModel
{
    private readonly MyDbContext _dbContext;

    public BookModel(MyDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Book> GetAll()
    {
        return _dbContext.Books.ToList();
    }

    public bool SaveBook(Book book)
    {
        try
        {
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public Book GetBookById(int id)
    {
        return _dbContext.Books.FirstOrDefault(b => b.Id == id);
    }

    public Book GetBookByTitle(string bookTitle)
    {
        return _dbContext.Books.FirstOrDefault(b => b.BookTitle == bookTitle);
    }

    public bool CascadeRemoveBookById(int id)
    {
        try
        {
            var book = _dbContext.Books
                .Include(b => b.UserStorages)
                .Include(b => b.SalesStatistics)
                .Include(b => b.BookPromotions)
                .FirstOrDefault(b => b.Id == id);

            if (book == null)
                return false;

            _dbContext.UserStorages.RemoveRange(book.UserStorages);
            _dbContext.SalesStatistics.RemoveRange(book.SalesStatistics);
            _dbContext.BookPromotions.RemoveRange(book.BookPromotions);

            // If other books reference this book as a “parent” book, we reset the reference to zero
            var childBooks = _dbContext.Books.Where(b => b.ParentBookId == id).ToList();
            foreach (var child in childBooks)
            {
                child.ParentBookId = null;
            }

            _dbContext.Books.Remove(book);
            _dbContext.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool UpdateBook(Book book)
    {
        try
        {
            var existing = _dbContext.Books.FirstOrDefault(b => b.Id == book.Id);
            if (existing == null)
                return false;

            existing.PublishingHouseId = book.PublishingHouseId;
            existing.BookTitle = book.BookTitle;
            existing.ImgUrl = book.ImgUrl;
            existing.AuthorId = book.AuthorId;
            existing.GenreId = book.GenreId;
            existing.PagesNumber = book.PagesNumber;
            existing.CostPrice = book.CostPrice;
            existing.SellingPrice = book.SellingPrice;
            existing.ParentBookId = book.ParentBookId;
            existing.PublishingYear = book.PublishingYear;

            _dbContext.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }
}