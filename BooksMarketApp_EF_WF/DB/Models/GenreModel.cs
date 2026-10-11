using BooksMarketApp_EF_WF.DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace BooksMarketApp_EF_WF.DB.Models;

public class GenreModel
{
    private readonly MyDbContext _dbContext;

    public GenreModel(MyDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Genre> GetAll()
    {
        return _dbContext.Genres.ToList();
    }

    public bool SaveGenre(Genre genre)
    {
        try
        {
            _dbContext.Genres.Add(genre);
            _dbContext.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public Genre GetGenreById(int id)
    {
        return _dbContext.Genres.FirstOrDefault(g => g.Id == id);
    }

    public Genre GetGenreByName(string genreName)
    {
        return _dbContext.Genres.FirstOrDefault(g => g.GenreName == genreName);
    }

    public bool CascadeRemoveGenreById(int id)
    {
        try
        {
            var genre = _dbContext.Genres
                .Include(g => g.Books)
                .FirstOrDefault(g => g.Id == id);

            if (genre == null)
                return false;

            foreach (var book in genre.Books.ToList())
            {
                RemoveBookWithDependencies(book);
            }

            _dbContext.Genres.Remove(genre);
            _dbContext.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool UpdateGenre(Genre genre)
    {
        try
        {
            var existing = _dbContext.Genres.FirstOrDefault(g => g.Id == genre.Id);
            if (existing == null)
                return false;

            existing.GenreName = genre.GenreName;

            _dbContext.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

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