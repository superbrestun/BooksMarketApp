namespace BooksMarketApp_EF_WF;

public partial class ConnectionString
{
    public static string DefaultConnectionString =>
        @"Server=(localdb)\mssqllocaldb;Database=BookStoreDb;Trusted_Connection=True;";
}