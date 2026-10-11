using BooksMarketApp_EF_WF.DB.Entities;
using BooksMarketApp_EF_WF.DB.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksMarketApp_EF_WF.DB.Services;

public class BookStorageService
{
    private readonly MyDbContext _dbContext;
    private readonly BookModel _bookModel;
    private readonly SalesStatisticModel _salesStatisticModel;
    private readonly UserModel _userModel;
    private readonly GenreModel _genreModel;
    private readonly PublishingHouseModel _publishingHouseModel;
    private readonly AuthorModel _authorModel;
    private readonly PromotionModel _promotionModel;
    private readonly BookPromotionModel _bookPromotionModel;
    
    public  BookStorageService(MyDbContext dbContext)
    {
        _dbContext = dbContext;
        _bookModel = new BookModel(_dbContext);
        _salesStatisticModel = new SalesStatisticModel(_dbContext);
        _userModel = new UserModel(_dbContext);
        _genreModel = new GenreModel(_dbContext);
        _publishingHouseModel = new PublishingHouseModel(_dbContext);
        _authorModel = new AuthorModel(_dbContext);
        _promotionModel = new PromotionModel(_dbContext);
        _bookPromotionModel = new BookPromotionModel(_dbContext);
    }

    public UserModel UserModel => _userModel;
    public SalesStatisticModel SalesStatisticModel => _salesStatisticModel;
    public BookModel BookModel => _bookModel;
    public GenreModel GenreModel => _genreModel;
    public PublishingHouseModel PublishingHouseModel => _publishingHouseModel;
    public AuthorModel AuthorModel => _authorModel;
    public  PromotionModel PromotionModel => _promotionModel;
    public BookPromotionModel BookPromotionModel => _bookPromotionModel;

    public List<Book> GetAllBooksWithRelations()
    {
        using (var context = new MyDbContext())
        {
            return context.Books
                .Include(b => b.Author)       
                .Include(b => b.Genre)        
                .Include(b => b.ParentBook)
                .Include(b => b.PublishingHouse)
                .AsNoTracking()
                .ToList();
        }
    }

    public List<Book> GetNewestBooks(int count = 25)
    {
        using (var context = new MyDbContext())
        {
            return context.Books
                .Include(b => b.Author)    
                .Include(b => b.Genre)        
                .Include(b => b.ParentBook)      
                .AsNoTracking()
                .OrderByDescending(b => b.PublishingYear)
                .Take(count)                             
                .ToList(); 
        }
    }
    
    public List<Book> SearchBooks(int genreId, int publishingHouseId, string authorName, string bookTitle)
    {
        using (var context = new MyDbContext())
        {
            // constructing a query with all relationships
            var query = context.Books
                .Include(b => b.Author)
                .Include(b => b.Genre)
                .Include(b => b.PublishingHouse)
                .Include(b => b.ParentBook)
                .AsNoTracking();
            
            if (genreId > 0)
            {
                query = query.Where(b => b.GenreId == genreId);
            }
            
            if (publishingHouseId > 0)
            {
                query = query.Where(b => b.PublishingHouseId == publishingHouseId);
            }
            
            if (!string.IsNullOrWhiteSpace(authorName))
            {
                query = query.Where(b => b.Author.FullName.Contains(authorName));
            }
            
            if (!string.IsNullOrWhiteSpace(bookTitle))
            {
                query = query.Where(b => b.BookTitle.Contains(bookTitle));
            }
            
            return query.ToList();
        }
    }

    public List<Book> GetBooksWithoutRelations()
    {
        return _dbContext.Books
            .Where(b => b.ParentBookId == null)
            .Select(b => new Book 
            { 
                Id = b.Id, 
                BookTitle = b.BookTitle 
            })
            .AsNoTracking()
            .ToList();
    }
    
    
}