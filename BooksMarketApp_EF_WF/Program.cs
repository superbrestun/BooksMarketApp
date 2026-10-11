using BooksMarketApp_EF_WF.DB;
using BooksMarketApp_EF_WF.DB.Entities;
using BooksMarketApp_EF_WF.DB.Services;
using BooksMarketApp_EF_WF.Views;

namespace BooksMarketApp_EF_WF;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
    
        using (var context = new MyDbContext())
        {
            
            MyDbContextInitializer.Initialize(context);
        }
        
        using (LoginForm loginForm = new LoginForm())
        {
            if (loginForm.ShowDialog() != DialogResult.OK)
            {
                return; 
            }
            
            User loggedInUser = loginForm.User!;
            
            Application.Run(new MainForm(loggedInUser, new BookStorageService(new MyDbContext()), new MyDbContext()));
        }
    }
}