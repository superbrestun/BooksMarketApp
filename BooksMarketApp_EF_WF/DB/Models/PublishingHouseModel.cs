using BooksMarketApp_EF_WF.DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace BooksMarketApp_EF_WF.DB.Models;

public class PublishingHouseModel
{
    private readonly MyDbContext _dbContext;

    public PublishingHouseModel(MyDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<PublishingHouse> GetAll()
    {
        return _dbContext.PublishingHouses.AsNoTracking().ToList();
    }

    public bool SavePublishingHouse(PublishingHouse publishingHouse)
    {
        try
        {
            _dbContext.PublishingHouses.Add(publishingHouse);
            _dbContext.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public PublishingHouse GetPublishingHouseById(int id)
    {
        return _dbContext.PublishingHouses.FirstOrDefault(p => p.Id == id);
    }

    public PublishingHouse GetPublishingHouseByName(string name)
    {
        return _dbContext.PublishingHouses.FirstOrDefault(p => p.Name == name);
    }

    public bool CascadeRemovePublishingHouseById(int id)
    {
        try
        {
            var publishingHouse = _dbContext.PublishingHouses
                .Include(p => p.Books)
                .FirstOrDefault(p => p.Id == id);

            if (publishingHouse == null)
                return false;

            foreach (var book in publishingHouse.Books.ToList())
            {
                RemoveBookWithDependencies(book);
            }

            _dbContext.PublishingHouses.Remove(publishingHouse);
            _dbContext.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool UpdatePublishingHouse(PublishingHouse publishingHouse)
    {
        try
        {
            var existing = _dbContext.PublishingHouses.FirstOrDefault(p => p.Id == publishingHouse.Id);
            if (existing == null)
                return false;

            existing.Name = publishingHouse.Name;

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