using BooksMarketApp_EF_WF.DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace BooksMarketApp_EF_WF.DB.Models;

public class UserStorageModel
{
    private readonly MyDbContext _dbContext;

    public UserStorageModel(MyDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<UserStorage> GetAll()
    {
        return _dbContext.UserStorages.ToList();
    }

    public bool SaveUserStorage(UserStorage userStorage)
    {
        try
        {
            _dbContext.UserStorages.Add(userStorage);
            _dbContext.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public UserStorage GetUserStorageByUserAndBook(int userId, int bookId)
    {
        return _dbContext.UserStorages
            .FirstOrDefault(us => us.UserId == userId && us.BookId == bookId);
    }

    public List<UserStorage> GetUserStoragesByUserId(int userId)
    {
        return _dbContext.UserStorages
            .Include(us => us.Book)
            .Where(us => us.UserId == userId)
            .ToList();
    }

    public bool CascadeRemoveUserStorageByUserAndBook(int userId, int bookId)
    {
        try
        {
            var userStorage = _dbContext.UserStorages
                .FirstOrDefault(us => us.UserId == userId && us.BookId == bookId);

            if (userStorage == null)
                return false;
            
            _dbContext.UserStorages.Remove(userStorage);
            _dbContext.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool UpdateUserStorage(UserStorage userStorage)
    {
        try
        {
            var existing = _dbContext.UserStorages
                .FirstOrDefault(us => us.UserId == userStorage.UserId && us.BookId == userStorage.BookId);

            if (existing == null)
                return false;

            existing.AddedAt = userStorage.AddedAt;
            existing.Status = userStorage.Status;

            _dbContext.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }
}