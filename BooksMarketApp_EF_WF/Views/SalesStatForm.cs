using BooksMarketApp_EF_WF.DB;
using BooksMarketApp_EF_WF.DB.Entities;
using BooksMarketApp_EF_WF.DB.Models;

namespace BooksMarketApp_EF_WF.Views;

public partial class SalesStatForm : Form
{
    private readonly MyDbContext _context;
    private readonly SalesStatisticModel _salesStatistic;
    
    public SalesStatForm(MyDbContext context)
    {
        InitializeComponent();
        _context = context;
        _salesStatistic = new SalesStatisticModel(_context);
    }
}