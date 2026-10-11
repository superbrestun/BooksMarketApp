using BooksMarketApp_EF_WF.DB.Entities;
using BooksMarketApp_EF_WF.DB.Models;
using BooksMarketApp_EF_WF.DB.Services;

namespace BooksMarketApp_EF_WF.Views;

public partial class SellBookForm : Form
{
    private readonly BookStorageService _service;
    private readonly Book _book;
    
    public SellBookForm(BookStorageService service, Book book)
    {
        InitializeComponent();
        _service = service;
        _book = book;
        FillComboBox();
    }

    private void FillComboBox()
    {
        var Users = _service.UserModel.GetAll();
        
        comboBox_Users.DataSource = Users;
        comboBox_Users.DisplayMember = "Username";
        comboBox_Users.ValueMember = "UserId";
    }
    
    private void button_Cancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }


    private void button_Confirm_Click(object sender, EventArgs e)
    {
        if (_book == null)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        if (comboBox_Users.SelectedIndex == 0)
        {
            MessageBox.Show("Please select a user");
            return;
        }
        
        if (textBox_Quantity.Text.Length < 1 && textBox_Quantity.Text.Length > 10)
        {
            MessageBox.Show("Please enter a number of books");
            return;
        }

        if (!int.TryParse(textBox_Quantity.Text, out int quantityOfBooks))
        {
            MessageBox.Show("Please enter a number of books");
            return;
        }

        SalesStatistic newSailStat = new SalesStatistic()
        {
            BookId = _book.Id,
            Quantity = quantityOfBooks,
            SoldPrice = _book.SellingPrice,
            CustomerId = comboBox_Users.SelectedIndex,
            SoldAt = DateTime.Now,
        };

        if (_service.SalesStatisticModel.SaveSalesStatistic(newSailStat))
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}