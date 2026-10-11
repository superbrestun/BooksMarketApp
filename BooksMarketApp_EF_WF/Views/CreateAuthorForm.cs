using BooksMarketApp_EF_WF.DB;
using BooksMarketApp_EF_WF.DB.Entities;
using BooksMarketApp_EF_WF.DB.Models;

namespace BooksMarketApp_EF_WF.Views;

public partial class CreateAuthorForm : Form
{
    private readonly MyDbContext _context;
    private readonly AuthorModel _authorModel;
    
    public CreateAuthorForm(MyDbContext context)
    {
        InitializeComponent();
        _context = context;
        _authorModel = new AuthorModel(_context);
    }
    
    private void CreateAuthorForm_Load(object sender, EventArgs e)
    {
        ConfigureDataGridView();
        LoadAuthors();
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
        
        dataGridView1.Columns.Add(
            new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "Id",
                DataPropertyName = "Id",
                Width = 50,
                ReadOnly = true,
            });
        
        dataGridView1.Columns.Add(
            new DataGridViewTextBoxColumn
            {
                Name = "FullName",
                HeaderText = "Author Full Name",
                DataPropertyName = "FullName",
                Width = 200
            });
    }

    private void LoadAuthors()
    {
        try
        {
            var authors = _authorModel.GetAll();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = authors;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void button_Refresh_Click(object sender, EventArgs e)
    {
        LoadAuthors();
    }

    private void button_Cancel_Click_1(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    private void button_Confirm_Click_1(object sender, EventArgs e)
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
        int authorId = Convert.ToInt32(selRow.Cells["Id"].Value);
        
        var boxResult = MessageBox.Show("Remove Author and all his books?", "Confirm Cascade Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (boxResult == DialogResult.Yes)
        {
            if (_authorModel.CascadeRemoveAuthorById(authorId)) 
            {
                LoadAuthors();
            }
            else
            {
                MessageBox.Show("Failed to delete author", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void button_Create_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBox_AuthorFullname.Text))
        {
            MessageBox.Show("Please enter an author name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        Author newAuthor = new Author()
        {
            FullName = textBox_AuthorFullname.Text.Trim()
        };

        if (_authorModel.SaveAuthor(newAuthor))
        {
            textBox_AuthorFullname.Clear();
            LoadAuthors();
        }
        else
        {
            MessageBox.Show("Failed to save author", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}