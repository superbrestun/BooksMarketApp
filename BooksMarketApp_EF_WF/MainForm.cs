using BooksMarketApp_EF_WF.DB;
using BooksMarketApp_EF_WF.DB.Entities;
using BooksMarketApp_EF_WF.DB.Services;
using BooksMarketApp_EF_WF.Views;
using Microsoft.EntityFrameworkCore;

namespace BooksMarketApp_EF_WF;

public partial class MainForm : Form
{

    private readonly User _currentUser;
    private readonly BookStorageService _bookStorageService;
    private readonly MyDbContext _context;
    
    public MainForm(User user, BookStorageService storageService, MyDbContext dbContext)
    {
        InitializeComponent();
        _currentUser = user;
        _bookStorageService = storageService;
        _context = dbContext;
        
        FillSearchComboBoxes();
    }

    private void ConfigureDataGridView()
    {
        dataGridView_Books.AllowUserToAddRows = false;
        dataGridView_Books.AllowUserToDeleteRows = false;
        dataGridView_Books.ReadOnly = true;
        dataGridView_Books.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView_Books.MultiSelect = false;
        
        dataGridView_Books.AutoGenerateColumns = false;
        dataGridView_Books.Columns.Clear();
        
        dataGridView_Books.Columns.Add(new DataGridViewTextBoxColumn()
        {
            Name = "Id",
            HeaderText = "Id",
            DataPropertyName = "Id",
            Width = 50
        });
        
        dataGridView_Books.Columns.Add(new DataGridViewTextBoxColumn()
        {
            Name = "BookTitle",
            HeaderText = "Title",
            DataPropertyName = "BookTitle",
            Width = 180
        });
        
        dataGridView_Books.Columns.Add(new DataGridViewTextBoxColumn()
        {
            Name = "Author",
            HeaderText = "Author",
            DataPropertyName = "Author",
            Width = 140
        });
        
        dataGridView_Books.Columns.Add(new DataGridViewTextBoxColumn()
        {
            Name = "Genre",
            HeaderText = "Genre",
            DataPropertyName = "Genre",
            Width = 100
        });
        
        dataGridView_Books.Columns.Add(new DataGridViewTextBoxColumn()
        {
            Name = "PublishingYear",
            HeaderText = "Published At",
            DataPropertyName = "PublishingYear",
            Width = 60
        });
        
        dataGridView_Books.Columns.Add(new DataGridViewTextBoxColumn()
        {
            Name = "SellingPrice",
            HeaderText = "Price",
            DataPropertyName = "SellingPrice",
            Width = 80
        });
        
        dataGridView_Books.Columns.Add(new DataGridViewTextBoxColumn()
        {
            Name = "ParentBook",
            HeaderText = "ParentBook",
            DataPropertyName = "ParentBook",
            Width = 150
        });
    }

    private void LoadBooksData()
    {
        List<Book> books = _bookStorageService.GetAllBooksWithRelations();
        
        var displayList = books.Select(b => new
        {
            Id = b.Id,
            BookTitle = b.BookTitle,
            Author = b.Author != null ? b.Author.FullName : "-", 
            Genre = b.Genre != null ? b.Genre.GenreName : "-", 
            PublishingYear = b.PublishingYear,
            SellingPrice = b.SellingPrice,
            ParentBook = b.ParentBook != null ? b.ParentBook.BookTitle : "-" 
        }).ToList();
        
        dataGridView_Books.DataSource = displayList;
    }
    
    private void button_Refresh_Click(object sender, EventArgs e)
    {
        try
        {
            LoadBooksData();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Loading Data Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadNewBooksData()
    {
        List<Book> books = _bookStorageService.GetNewestBooks();
        
        var displayList = books.Select(b => new
        {
            Id = b.Id,
            BookTitle = b.BookTitle,
            Author = b.Author != null ? b.Author.FullName : "-", 
            Genre = b.Genre != null ? b.Genre.GenreName : "-", 
            PublishingYear = b.PublishingYear,
            SellingPrice = b.SellingPrice,
            ParentBook = b.ParentBook != null ? b.ParentBook.BookTitle : "-" 
        }).ToList();
        
        dataGridView_Books.DataSource = displayList;
    }
    
    private void button_GetNewBooks_Click(object sender, EventArgs e)
    {
        try
        {
            LoadNewBooksData();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Loading Data Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void FillSearchComboBoxes()
    {
        var allGenres = _bookStorageService.GenreModel.GetAll();
        allGenres.Insert(0, new Genre {Id = 0, GenreName = "All Genres"});
        comboBox_Genres.DataSource = allGenres;
        comboBox_Genres.DisplayMember = "GenreName";
        comboBox_Genres.ValueMember = "Id";

        var allHouses = _bookStorageService.PublishingHouseModel.GetAll();
        allHouses.Insert(0, new PublishingHouse { Id = 0, Name = "AllHouses" });
        comboBox_PublishingHouses.DataSource = allHouses;
        comboBox_PublishingHouses.DisplayMember = "Name"; 
        comboBox_PublishingHouses.ValueMember = "Id";
    }
    
    private void button_GetPopularBooks_Click(object sender, EventArgs e)
    {
        
    }

    private void button_CreatePromotion_Click(object sender, EventArgs e)
    {
        
    }

    private void button_AddBook_Click(object sender, EventArgs e)
    {
        using (var addBook = new AddBookForm(_context, _bookStorageService))
        {
            addBook.Owner = this;
            
            if (addBook.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Successfully Added Book", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    private void button_DeleteBook_Click(object sender, EventArgs e)
    {
        if (dataGridView_Books.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a row to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var selRow = dataGridView_Books.SelectedRows[0];
        int bookId = Convert.ToInt32(selRow.Cells["Id"].Value);
        
        var boxResult = MessageBox.Show($"Remove book {bookId}", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (boxResult == DialogResult.Yes)
        {
            if (_bookStorageService.BookModel.CascadeRemoveBookById(bookId))
            {
                button_Refresh_Click(null, null);
                MessageBox.Show("Successfully Deleted Book", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    private void button_SaveBookChanges_Click(object sender, EventArgs e)
    {
        if (dataGridView_Books.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a row to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        var selRow = dataGridView_Books.SelectedRows[0];
        int bookId = Convert.ToInt32(selRow.Cells["Id"].Value);

        Book changeBook = _bookStorageService.BookModel.GetBookById(bookId);
        
        AddBookForm addBookForm = new AddBookForm(_context, _bookStorageService, changeBook);
        addBookForm.Owner = this;

        if (addBookForm.ShowDialog() == DialogResult.OK)
        {
            button_Refresh_Click(null, null);
            MessageBox.Show("Successfully Changed Book", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void button_Search_Click_1(object sender, EventArgs e)
    {
        try
        {
            int selectedGenreId = (int)(comboBox_Genres.SelectedValue ?? 0);
            int selectedHouseId = (int)(comboBox_PublishingHouses.SelectedValue ?? 0);
            string authorText = textBox_Author.Text.Trim();
            string titleText = textBox_BookTitle.Text.Trim();

            List<Book> filteredBooks = _bookStorageService.SearchBooks(selectedGenreId, selectedHouseId, authorText, titleText);

            var displayList = filteredBooks.Select(b => new
            {
                Id = b.Id,
                BookTitle = b.BookTitle,
                Author = b.Author != null ? b.Author.FullName : "Not exist",
                Genre = b.Genre != null ? b.Genre.GenreName : "Not exist",
                PublishingYear = b.PublishingYear,
                SellingPrice = b.SellingPrice,
                ParentBook = b.ParentBook != null ? b.ParentBook.BookTitle : "-"
            }).ToList();

            dataGridView_Books.DataSource = displayList;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error {ex.Message}\n{ex.StackTrace}");
        }
    }

    private void button_CheckPromotions_Click(object sender, EventArgs e)
    {
        PromotionsForm promotionsForm = new PromotionsForm(_context);
        promotionsForm.Owner = this;
        promotionsForm.ShowDialog();
    }


    private void button_CheckSailStat_Click(object sender, EventArgs e)
    {
        SalesStatForm statForm = new SalesStatForm(_context);
        statForm.Owner = this;
        statForm.ShowDialog();
    }

    private void button_SellBook_Click(object sender, EventArgs e)
    {
        if (dataGridView_Books.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a row to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        var selRow = dataGridView_Books.SelectedRows[0];
        int bookId = Convert.ToInt32(selRow.Cells["Id"].Value);

        Book selectedBook = _bookStorageService.BookModel.GetBookById(bookId);
        
        SellBookForm sellBookForm = new SellBookForm(_bookStorageService, selectedBook);
        sellBookForm.Owner = this;

        if (ShowDialog() == DialogResult.OK)
        {
            MessageBox.Show("Successfully Sold Book", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
    
}