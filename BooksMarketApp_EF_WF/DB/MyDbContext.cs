using BooksMarketApp_EF_WF.DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace BooksMarketApp_EF_WF.DB;

public class MyDbContext : DbContext
{
    public MyDbContext()
    {
        
    }
    
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<UserStorage> UserStorages { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<PublishingHouse> PublishingHouses { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<SalesStatistic> SalesStatistics { get; set; }
    public DbSet<Promotion> Promotions { get; set; }
    public DbSet<BookPromotion> BookPromotions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(
                ConnectionString._connectionString);
        }
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<UserStorage>()
            .HasKey(us => new { us.UserId, us.BookId });

        modelBuilder.Entity<BookPromotion>()
            .HasKey(bp => new { bp.BookId, bp.PromotionId });
        
        modelBuilder.Entity<Book>()
            .HasOne(b => b.ParentBook)
            .WithMany()
            .HasForeignKey(b => b.ParentBookId)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<UserStorage>()
            .HasOne(us => us.User)
            .WithMany(u => u.UserStorages)
            .HasForeignKey(us => us.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<UserStorage>()
            .HasOne(us => us.Book)
            .WithMany(b => b.UserStorages)
            .HasForeignKey(us => us.BookId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<SalesStatistic>()
            .HasOne(s => s.Book)
            .WithMany(b => b.SalesStatistics)
            .HasForeignKey(s => s.BookId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<BookPromotion>()
            .HasOne(bp => bp.Book)
            .WithMany(b => b.BookPromotions)
            .HasForeignKey(bp => bp.BookId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<BookPromotion>()
            .HasOne(bp => bp.Promotion)
            .WithMany(p => p.BookPromotions)
            .HasForeignKey(bp => bp.PromotionId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}