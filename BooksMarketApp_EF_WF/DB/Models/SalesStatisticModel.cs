using BooksMarketApp_EF_WF.DB.Entities;

namespace BooksMarketApp_EF_WF.DB.Models;

public class SalesStatisticModel
{
    private readonly MyDbContext _dbContext;

    public SalesStatisticModel(MyDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<SalesStatistic> GetAll()
    {
        return _dbContext.SalesStatistics.ToList();
    }

    public bool SaveSalesStatistic(SalesStatistic salesStatistic)
    {
        try
        {
            _dbContext.SalesStatistics.Add(salesStatistic);
            _dbContext.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public SalesStatistic GetSalesStatisticById(int id)
    {
        return _dbContext.SalesStatistics.FirstOrDefault(s => s.Id == id);
    }

    public List<SalesStatistic> GetSalesStatisticsByBookId(int bookId)
    {
        return _dbContext.SalesStatistics.Where(s => s.BookId == bookId).ToList();
    }

    public bool CascadeRemoveSalesStatisticById(int id)
    {
        try
        {
            var salesStatistic = _dbContext.SalesStatistics.FirstOrDefault(s => s.Id == id);

            if (salesStatistic == null)
                return false;
            
            _dbContext.SalesStatistics.Remove(salesStatistic);
            _dbContext.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool UpdateSalesStatistic(SalesStatistic salesStatistic)
    {
        try
        {
            var existing = _dbContext.SalesStatistics.FirstOrDefault(s => s.Id == salesStatistic.Id);
            if (existing == null)
                return false;

            existing.BookId = salesStatistic.BookId;
            existing.Quantity = salesStatistic.Quantity;
            existing.SoldPrice = salesStatistic.SoldPrice;
            existing.CustomerId = salesStatistic.CustomerId;
            existing.SoldAt = salesStatistic.SoldAt;

            _dbContext.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }
}