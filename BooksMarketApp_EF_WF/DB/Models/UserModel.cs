using BooksMarketApp_EF_WF.DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace BooksMarketApp_EF_WF.DB.Models;

public class UserModel
{
    private readonly MyDbContext _dbContext;

    public UserModel(MyDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<User> GetAll()
    {
        return _dbContext.Users.ToList();
    }

    public bool SaveUser(User user)
    {
        try
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public User GetUserByEmail(string email)
    {
        return _dbContext.Users.FirstOrDefault(u => u.Email == email);
    }

    public User GetUserByLogin(string login, string password)
    {
        return _dbContext.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
    }

    public bool CascadeRemoveUserByEmail(string email)
    {
        try
        {
            var user = _dbContext.Users
                .Include(u => u.UserStorages)
                .FirstOrDefault(u => u.Email == email);

            if (user == null)
                return false;

            _dbContext.UserStorages.RemoveRange(user.UserStorages);
            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool CascadeRemoveUserByLogin(string login)
    {
        try
        {
            var user = _dbContext.Users
                .Include(u => u.UserStorages)
                .FirstOrDefault(u => u.Login == login);

            if (user == null)
                return false;

            _dbContext.UserStorages.RemoveRange(user.UserStorages);
            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool UpdateUser(User user)
    {
        try
        {
            var existing = _dbContext.Users.FirstOrDefault(u => u.Id == user.Id);
            if (existing == null)
                return false;

            existing.Login = user.Login;
            existing.Password = user.Password;
            existing.Email = user.Email;
            existing.AdminPermission = user.AdminPermission;
            existing.CreatedAt = user.CreatedAt;

            _dbContext.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }
}