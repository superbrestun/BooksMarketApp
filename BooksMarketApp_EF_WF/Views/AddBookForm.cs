using System.Globalization;
using BooksMarketApp_EF_WF.DB;
using BooksMarketApp_EF_WF.DB.Entities;
using BooksMarketApp_EF_WF.DB.Services;

namespace BooksMarketApp_EF_WF.Views;

public partial class AddBookForm : Form
{
    private readonly MyDbContext _dbContext;
    private readonly BookStorageService _bookStorageService;

    private Book? _book;
    
    private bool IsEditMode => _book != null && _book.Id != 0;

    public AddBookForm(MyDbContext dbContext, BookStorageService bookStorageService, Book book)
    {
        InitializeComponent();
        _dbContext = dbContext;
        _bookStorageService = bookStorageService;
        _book = book;

        FillComboboxex();
        FillFieldsFromBook(_book);
    }

    public AddBookForm(MyDbContext dbContext, BookStorageService bookStorageService)
    {
        InitializeComponent();
        _dbContext = dbContext;
        _bookStorageService = bookStorageService;
        _book = null;

        FillComboboxex();
    }

    private void FillComboboxex()
    {
        var genres = _bookStorageService.GenreModel.GetAll();
        var houses = _bookStorageService.PublishingHouseModel.GetAll();
        var authors = _bookStorageService.AuthorModel.GetAll();
        var books = _bookStorageService.GetBooksWithoutRelations();
        books.Insert(0, new Book { Id = 0, BookTitle = "Non" });

        comboBox_Genre.DataSource = genres;
        comboBox_Genre.DisplayMember = "GenreName";
        comboBox_Genre.ValueMember = "Id";

        comboBox_PublishingHouse.DataSource = houses;
        comboBox_PublishingHouse.DisplayMember = "Name";
        comboBox_PublishingHouse.ValueMember = "Id";

        comboBox_Author.DataSource = authors;
        comboBox_Author.DisplayMember = "FullName";
        comboBox_Author.ValueMember = "Id";

        comboBox_ParentBook.DataSource = books;
        comboBox_ParentBook.DisplayMember = "BookTitle";
        comboBox_ParentBook.ValueMember = "Id";
    }
    
    private void FillFieldsFromBook(Book? book)
    {
        if (book == null)
            return;

        textBox_BookTitle.Text = book.BookTitle;
        textBox_PagesNumber.Text = book.PagesNumber.ToString();
        textBox_CostPrice.Text = book.CostPrice.ToString(CultureInfo.InvariantCulture);
        textBox_SellingPrice.Text = book.SellingPrice.ToString(CultureInfo.InvariantCulture);
        textBox_PublishingYear.Text = book.PublishingYear.ToString();

        comboBox_Author.SelectedValue = book.AuthorId;
        comboBox_Genre.SelectedValue = book.GenreId;
        comboBox_PublishingHouse.SelectedValue = book.PublishingHouseId;
        
        comboBox_ParentBook.SelectedValue = book.ParentBookId ?? 0;
    }

    private void button_Cancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    private void button_Confirm_Click(object sender, EventArgs e)
    {
        if (comboBox_PublishingHouse.SelectedIndex == -1)
        {
            MessageBox.Show("Please select a publishing house");
            return;
        }
        if (string.IsNullOrWhiteSpace(textBox_BookTitle.Text))
        {
            MessageBox.Show("Please enter a book title");
            return;
        }
        if (comboBox_Author.SelectedIndex == -1)
        {
            MessageBox.Show("Please select an author");
            return;
        }
        if (comboBox_Genre.SelectedIndex == -1)
        {
            MessageBox.Show("Please select a genre");
            return;
        }

        if (textBox_PagesNumber.Text.Length == 0 ||
            textBox_PagesNumber.Text.Length > 5 ||
            !int.TryParse(textBox_PagesNumber.Text, out int numberPages))
        {
            MessageBox.Show("Please enter a valid page number (numeric only)");
            return;
        }

        if (textBox_CostPrice.Text.Length == 0 ||
            textBox_CostPrice.Text.Length > 8 ||
            !double.TryParse(textBox_CostPrice.Text, out double costPrice))
        {
            MessageBox.Show("Please enter a valid cost (numeric only)");
            return;
        }

        if (textBox_SellingPrice.Text.Length == 0 ||
            textBox_SellingPrice.Text.Length > 8 ||
            !double.TryParse(textBox_SellingPrice.Text, out double sellPrice))
        {
            MessageBox.Show("Please enter a valid selling price (numeric only)");
            return;
        }

        if (textBox_PublishingYear.Text.Length == 0 ||
            textBox_PublishingYear.Text.Length > 5 ||
            !int.TryParse(textBox_PublishingYear.Text, out int publishingYear))
        {
            MessageBox.Show("Please enter a valid publishing year (numeric only)");
            return;
        }
        
        int selectedParentId = (int)comboBox_ParentBook.SelectedValue;
        int? parentBookId = selectedParentId == 0 ? null : selectedParentId;

        bool success;

        if (IsEditMode)
        {
            _book.BookTitle = textBox_BookTitle.Text.Trim();
            _book.AuthorId = (int)comboBox_Author.SelectedValue;
            _book.GenreId = (int)comboBox_Genre.SelectedValue;
            _book.PublishingHouseId = (int)comboBox_PublishingHouse.SelectedValue;
            _book.PublishingYear = publishingYear;
            _book.PagesNumber = numberPages;
            _book.CostPrice = costPrice;
            _book.SellingPrice = sellPrice;
            _book.ParentBookId = parentBookId;

            success = _bookStorageService.BookModel.UpdateBook(_book);
        }
        else
        {
            var newBook = new Book()
            {
                BookTitle = textBox_BookTitle.Text.Trim(),
                AuthorId = (int)comboBox_Author.SelectedValue,
                GenreId = (int)comboBox_Genre.SelectedValue,
                PublishingHouseId = (int)comboBox_PublishingHouse.SelectedValue,
                PublishingYear = publishingYear,
                PagesNumber = numberPages,
                CostPrice = costPrice,
                SellingPrice = sellPrice,
                ImgUrl = null,
                ParentBookId = parentBookId
            };

            success = _bookStorageService.BookModel.SaveBook(newBook);
        }

        if (!success)
        {
            MessageBox.Show("Database error: could not save the book");
            return;
        }

        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private void button_CreatePublishingHouse_Click(object sender, EventArgs e)
    {
        CreatePublishingHouse createPublishingHouse = new CreatePublishingHouse(_dbContext);
        createPublishingHouse.Owner = this;
        if (createPublishingHouse.ShowDialog() == DialogResult.OK)
        {
            FillComboboxex();
        }
    }

    private void button_CreateAuthor_Click(object sender, EventArgs e)
    {
        CreateAuthorForm createAuthorForm = new CreateAuthorForm(_dbContext);
        createAuthorForm.Owner = this;
        if (createAuthorForm.ShowDialog() == DialogResult.OK)
        {
            FillComboboxex();
        }
    }

    private void button_CreateGenre_Click(object sender, EventArgs e)
    {
        CreateGenreForm createGenreForm = new CreateGenreForm(_dbContext);
        createGenreForm.Owner = this;
        if (createGenreForm.ShowDialog() == DialogResult.OK)
        {
            FillComboboxex();
        }
    }
}