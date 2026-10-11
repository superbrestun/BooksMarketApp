using BooksMarketApp_EF_WF.DB.Entities;

namespace BooksMarketApp_EF_WF.DB;

public static class MyDbContextInitializer
{
    public static void Initialize(MyDbContext context)
    {
        context.Database.EnsureCreated();

        // Seed only if tables are empty
        SeedPublishingHouses(context);
        SeedAuthors(context);
        SeedGenres(context);
        SeedUsers(context);
        SeedBooks(context);
        SeedPromotions(context);

        context.SaveChanges();
    }

    private static void SeedPublishingHouses(MyDbContext context)
    {
        if (context.PublishingHouses.Any())
            return;

        context.PublishingHouses.AddRange(
            new PublishingHouse { Name = "Eksmo" },
            new PublishingHouse { Name = "AST" }
        );

        context.SaveChanges();
    }

    private static void SeedAuthors(MyDbContext context)
    {
        if (context.Authors.Any())
            return;

        context.Authors.AddRange(
            new Author { FullName = "Leo Tolstoy" },
            new Author { FullName = "Fyodor Dostoevsky" }
        );

        context.SaveChanges();
    }

    private static void SeedGenres(MyDbContext context)
    {
        if (context.Genres.Any())
            return;

        context.Genres.AddRange(
            new Genre { GenreName = "Novel" },
            new Genre { GenreName = "Classic" }
        );

        context.SaveChanges();
    }

    private static void SeedUsers(MyDbContext context)
    {
        if (context.Users.Any())
            return;

        context.Users.Add(new User
        {
            Login = "admin",
            Password = "admin123",
            Email = "admin@example.com",
            AdminPermission = true,
            CreatedAt = DateTime.UtcNow
        });

        context.SaveChanges();
    }

    private static void SeedBooks(MyDbContext context)
    {
        if (context.Books.Any())
            return;
        
        var publishingHouse = context.PublishingHouses.First();
        var author = context.Authors.First();
        var genre = context.Genres.First();

        context.Books.Add(new Book
        {
            PublishingHouseId = publishingHouse.Id,
            BookTitle = "War and Peace",
            AuthorId = author.Id,
            GenreId = genre.Id,
            PagesNumber = 1225,
            CostPrice = 300,
            SellingPrice = 550,
            PublishingYear = 1869
        });

        context.SaveChanges();
    }

    private static void SeedPromotions(MyDbContext context)
    {
        if (context.Promotions.Any())
            return;

        context.Promotions.Add(new Promotion
        {
            Name = "Summer Sale",
            DiscountPercent = 15,
            StartDate = DateTime.UtcNow,
            EndDate = DateTime.UtcNow.AddMonths(1)
        });

        context.SaveChanges();
    }
}