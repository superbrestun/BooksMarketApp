using BooksMarketApp_EF_WF.DB;
using BooksMarketApp_EF_WF.DB.Entities;
using BooksMarketApp_EF_WF.DB.Models;
using BooksMarketApp_EF_WF.DB.Services;

namespace BooksMarketApp_EF_WF.Views;

public partial class PromotionsForm : Form
{
    private readonly MyDbContext _dbContext;
    private readonly BookStorageService _bookStorageService;
    
    public PromotionsForm(MyDbContext dbContext)
    {
        InitializeComponent();
        _dbContext = dbContext;
        _bookStorageService = new BookStorageService(dbContext);
        PromotionsForm_Load(null,null);
    }

    private void PromotionsForm_Load(object sender, EventArgs e)
    {
        ConfigureDataGridView();
        LoadPromotions();
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
        
        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "Id",
            HeaderText = "ID",
            DataPropertyName = "Id",
            Width = 50,
            ReadOnly = true
        });
        
        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "Name",
            HeaderText = "Promotion Name",
            DataPropertyName = "Name", // Из модели Promotion.Name
            Width = 180
        });

        // Колонка Процент скидки
        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "DiscountPercent",
            HeaderText = "Discount (%)",
            DataPropertyName = "DiscountPercent",
            Width = 90
        });
        
        var startDateColumn = new DataGridViewTextBoxColumn
        {
            Name = "StartDate",
            HeaderText = "Start Date",
            DataPropertyName = "StartDate",
            Width = 100
        };
        startDateColumn.DefaultCellStyle.Format = "dd.MM.yyyy";
        dataGridView1.Columns.Add(startDateColumn);
        
        var endDateColumn = new DataGridViewTextBoxColumn
        {
            Name = "EndDate",
            HeaderText = "End Date",
            DataPropertyName = "EndDate",
            Width = 100
        };
        endDateColumn.DefaultCellStyle.Format = "dd.MM.yyyy";
        dataGridView1.Columns.Add(endDateColumn);
    }
    
    private void LoadPromotions()
    {
        try
        {
            var promotions = _bookStorageService.PromotionModel.GetAll();
            
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = promotions;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading promotions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    private void button_Refresh_Click(object sender, EventArgs e)
    {
        LoadPromotions();
    }

    private void dateTimePicker_EndDate_ValueChanged(object sender, EventArgs e) {}

    private void button_Dalete_Click(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        var selRow = dataGridView1.SelectedRows[0];
        int promotionId = Convert.ToInt32(selRow.Cells["Id"].Value);

        if (_bookStorageService.PromotionModel.CascadeRemovePromotionById(promotionId) == false)
        {
            MessageBox.Show("Promotion cannot be removed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        MessageBox.Show("Promotion has been successfully removed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        button_Refresh_Click(null, null);
    }

    private void button_Add_Click(object sender, EventArgs e)
    {
        if (textBox_Name.Text.Length == 0 
            || textBox_Name.Text.Length > 50)
        {
            MessageBox.Show("Please enter a correct value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!double.TryParse(textBox_DiscountPrecent.Text, out double discountPercent))
        {
            MessageBox.Show("Please enter a percentage", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (dateTimePicker_StartDate.Value.Date < DateTime.Now.Date)
        {
            MessageBox.Show("Please select a start date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (dateTimePicker_EndDate.Value.Date <= DateTime.Now.Date)
        {
            MessageBox.Show("Please select an end date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var newPromotion = new Promotion()
        {
            Name = textBox_Name.Text,
            DiscountPercent = discountPercent,
            StartDate = dateTimePicker_StartDate.Value.Date,
            EndDate = dateTimePicker_EndDate.Value.Date
        };

        if (!_bookStorageService.PromotionModel.SavePromotion(newPromotion))
        {
            MessageBox.Show("Promotion cannot be saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        MessageBox.Show("Promotion has been successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        button_Refresh_Click(null, null);
    }

    private void button_Change_Click(object sender, EventArgs e)
    {
        if (textBox_Name.Text.Length == 0)
        {
            MessageBox.Show("Please enter a name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        if (!double.TryParse(textBox_DiscountPrecent.Text, out double discountPercent))
        {
            MessageBox.Show("Please enter a percentage", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var selRow = dataGridView1.SelectedRows[0];
        int promotionId = Convert.ToInt32(selRow.Cells["Id"].Value);
        
        var currentPromotion = _bookStorageService.PromotionModel.GetPromotionById(promotionId);

        currentPromotion.Name = textBox_Name.Text;
        currentPromotion.DiscountPercent = discountPercent;
        currentPromotion.StartDate = dateTimePicker_StartDate.Value.Date;
        currentPromotion.EndDate = dateTimePicker_EndDate.Value.Date;
        

        if (_bookStorageService.PromotionModel.SavePromotion(currentPromotion))
        {
            MessageBox.Show("Promotion has been successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("Promotion cannot be saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}