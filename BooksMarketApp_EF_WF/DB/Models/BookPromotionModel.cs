using BooksMarketApp_EF_WF.DB.Entities;

namespace BooksMarketApp_EF_WF.DB.Models;

public class BookPromotionModel
{
    private readonly MyDbContext _dbContext;

    public BookPromotionModel(MyDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<BookPromotion> GetAll()
    {
        return _dbContext.BookPromotions.ToList();
    }

    public bool SaveBookPromotion(BookPromotion bookPromotion)
    {
        try
        {
            _dbContext.BookPromotions.Add(bookPromotion);
            _dbContext.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public BookPromotion GetBookPromotionByBookAndPromotion(int bookId, int promotionId)
    {
        return _dbContext.BookPromotions
            .FirstOrDefault(bp => bp.BookId == bookId && bp.PromotionId == promotionId);
    }

    public bool CascadeRemoveBookPromotionByBookAndPromotion(int bookId, int promotionId)
    {
        try
        {
            var bookPromotion = _dbContext.BookPromotions
                .FirstOrDefault(bp => bp.BookId == bookId && bp.PromotionId == promotionId);

            if (bookPromotion == null)
                return false;
            
            _dbContext.BookPromotions.Remove(bookPromotion);
            _dbContext.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool UpdateBookPromotion(BookPromotion bookPromotion)
    {
        try
        {
            var existing = _dbContext.BookPromotions
                .FirstOrDefault(bp => bp.BookId == bookPromotion.BookId && bp.PromotionId == bookPromotion.PromotionId);

            if (existing == null)
                return false;
            
            _dbContext.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }
}