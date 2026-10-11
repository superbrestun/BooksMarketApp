using BooksMarketApp_EF_WF.DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace BooksMarketApp_EF_WF.DB.Models;

public class PromotionModel
{
    private readonly MyDbContext _dbContext;

    public PromotionModel(MyDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Promotion> GetAll()
    {
        return _dbContext.Promotions.ToList();
    }

    public bool SavePromotion(Promotion promotion)
    {
        try
        {
            _dbContext.Promotions.Add(promotion);
            _dbContext.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public Promotion GetPromotionById(int id)
    {
        return _dbContext.Promotions.FirstOrDefault(p => p.Id == id);
    }

    public Promotion GetPromotionByName(string name)
    {
        return _dbContext.Promotions.FirstOrDefault(p => p.Name == name);
    }

    public bool CascadeRemovePromotionById(int id)
    {
        try
        {
            var promotion = _dbContext.Promotions
                .Include(p => p.BookPromotions)
                .FirstOrDefault(p => p.Id == id);

            if (promotion == null)
                return false;

            _dbContext.BookPromotions.RemoveRange(promotion.BookPromotions);
            _dbContext.Promotions.Remove(promotion);
            _dbContext.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool UpdatePromotion(Promotion promotion)
    {
        try
        {
            var existing = _dbContext.Promotions.FirstOrDefault(p => p.Id == promotion.Id);
            if (existing == null)
                return false;

            existing.Name = promotion.Name;
            existing.DiscountPercent = promotion.DiscountPercent;
            existing.StartDate = promotion.StartDate;
            existing.EndDate = promotion.EndDate;

            _dbContext.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }
}