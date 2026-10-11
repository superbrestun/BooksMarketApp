using BooksMarketApp_EF_WF.DB;
using BooksMarketApp_EF_WF.DB.Entities;
using BooksMarketApp_EF_WF.DB.Models;

namespace BooksMarketApp_EF_WF.Views;

public partial class CreatePublishingHouse : Form
{
    private readonly MyDbContext _dbContext;
    private readonly PublishingHouseModel _publishingHouseModel;
    
    public CreatePublishingHouse(MyDbContext dbContext)
    {
        InitializeComponent();
        _dbContext = dbContext;
        _publishingHouseModel = new PublishingHouseModel(_dbContext);
    }

    private void CreatePublishingHouse_Load(object sender, EventArgs e)
    {
        ConfigureDataGridView();
        LoadHouses();
    }
    
    private void ConfigureDataGridView()
    {
        dataGridView1.AutoGenerateColumns = true;
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
        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "Name",
            HeaderText = "Name",
            DataPropertyName = "Name",
            Width = 200
        });
    }

    private void LoadHouses()
    {
        try
        {
            var houses = _publishingHouseModel.GetAll();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = houses;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }


    private void button_RefreshData_Click(object sender, EventArgs e)
    {
        try
        {
            LoadHouses();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
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


    private void button_DeleteHouse_Click(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a row");
            return;
        }

        var selRow = dataGridView1.SelectedRows[0];
        int houseId = Convert.ToInt32(selRow.Cells["Id"].Value);
        
        var boxResult = MessageBox.Show("Remove Houses?", "Confirm", MessageBoxButtons.YesNo);

        if (boxResult == DialogResult.Yes)
        {
            if (_publishingHouseModel.CascadeRemovePublishingHouseById(houseId))
            {
                button_RefreshData_Click(null, null);
            }
        }
    }

    private void button_CreateHouse_Click(object sender, EventArgs e)
    {
        if(textBox_PublishingHouseName.Text.Length == 0)
        {
            MessageBox.Show("Please enter a name");
            return;
        }

        PublishingHouse publishingHouse = new PublishingHouse()
        {
            Name = textBox_PublishingHouseName.Text
        };

        if (_publishingHouseModel.SavePublishingHouse(publishingHouse))
        {
            button_RefreshData_Click(null, null);
        }
    }

    private void button_ChangeHouse_Click(object sender, EventArgs e)
    {
        
    }
}