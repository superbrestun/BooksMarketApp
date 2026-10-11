using BooksMarketApp_EF_WF.DB;
using BooksMarketApp_EF_WF.DB.Entities;
using BooksMarketApp_EF_WF.DB.Models;

namespace BooksMarketApp_EF_WF.Views;

public partial class CreateGenreForm : Form
{
    private readonly MyDbContext _dbContext;
    private readonly GenreModel _genreModel;
    
    public CreateGenreForm(MyDbContext dbContext)
    {
        InitializeComponent();
        _dbContext = dbContext;
        _genreModel = new GenreModel(_dbContext);
    }
    
    private void CreateGenreForm_Load(object sender, EventArgs e)
    {
        ConfigureDataGridView();
        LoadGenres();
    }
    
    private void ConfigureDataGridView()
    {
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.AllowUserToDeleteRows = false;
        dataGridView1.ReadOnly = true;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView1.MultiSelect = false;

        dataGridView1.AutoGenerateColumns = false;
        dataGridView1.Columns.Clear();

        // 1. Колонка ID
        dataGridView1.Columns.Add(
            new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "Id",
                DataPropertyName = "Id",
                Width = 50,
                ReadOnly = true,
            });

        // 2. Колонка Название жанра
        dataGridView1.Columns.Add(
            new DataGridViewTextBoxColumn
            {
                Name = "GenreName",
                HeaderText = "Genre Name",
                DataPropertyName = "GenreName", // Строго соответствует GenreName в модели Genre
                Width = 200
            });
    }

    private void LoadGenres()
    {
        try
        {
            var genres = _genreModel.GetAll();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = genres;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


    private void button_Refresh_Click(object sender, EventArgs e)
    {
        LoadGenres();
    }

    private void button_Cancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    private void button_Confirm_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private void button_Delete_Click(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a row to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var selRow = dataGridView1.SelectedRows[0];
        int genreId = Convert.ToInt32(selRow.Cells["Id"].Value);
        
        var boxResult = MessageBox.Show("Remove Genre and all books related to it?", "Confirm Cascade Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (boxResult == DialogResult.Yes)
        {
            // Метод каскадного удаления внутри GenreModel
            if (_genreModel.CascadeRemoveGenreById(genreId)) 
            {
                LoadGenres();
            }
            else
            {
                MessageBox.Show("Failed to delete genre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


    private void button_Create_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBox_GenreName.Text))
        {
            MessageBox.Show("Please enter a genre name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        Genre newGenre = new Genre()
        {
            GenreName = textBox_GenreName.Text.Trim()
        };

        if (_genreModel.SaveGenre(newGenre))
        {
            textBox_GenreName.Clear();
            LoadGenres();
        }
        else
        {
            MessageBox.Show("Failed to save genre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}