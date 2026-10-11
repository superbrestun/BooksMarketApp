using System.ComponentModel;

namespace BooksMarketApp_EF_WF.Views;

partial class PromotionsForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        dataGridView1 = new System.Windows.Forms.DataGridView();
        button_Cancel = new System.Windows.Forms.Button();
        button_Confirm = new System.Windows.Forms.Button();
        button_Refresh = new System.Windows.Forms.Button();
        button_Add = new System.Windows.Forms.Button();
        button_Change = new System.Windows.Forms.Button();
        button_Dalete = new System.Windows.Forms.Button();
        textBox_Name = new System.Windows.Forms.TextBox();
        textBox_DiscountPrecent = new System.Windows.Forms.TextBox();
        dateTimePicker_StartDate = new System.Windows.Forms.DateTimePicker();
        dateTimePicker_EndDate = new System.Windows.Forms.DateTimePicker();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.Location = new System.Drawing.Point(-3, 100);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new System.Drawing.Size(610, 284);
        dataGridView1.TabIndex = 0;
        // 
        // button_Cancel
        // 
        button_Cancel.Location = new System.Drawing.Point(12, 400);
        button_Cancel.Name = "button_Cancel";
        button_Cancel.Size = new System.Drawing.Size(143, 33);
        button_Cancel.TabIndex = 1;
        button_Cancel.Text = "Cancel";
        button_Cancel.UseVisualStyleBackColor = true;
        button_Cancel.Click += button_Cancel_Click;
        // 
        // button_Confirm
        // 
        button_Confirm.Location = new System.Drawing.Point(441, 400);
        button_Confirm.Name = "button_Confirm";
        button_Confirm.Size = new System.Drawing.Size(143, 33);
        button_Confirm.TabIndex = 2;
        button_Confirm.Text = "Confirm";
        button_Confirm.UseVisualStyleBackColor = true;
        button_Confirm.Click += button_Confirm_Click;
        // 
        // button_Refresh
        // 
        button_Refresh.Location = new System.Drawing.Point(506, 14);
        button_Refresh.Name = "button_Refresh";
        button_Refresh.Size = new System.Drawing.Size(77, 22);
        button_Refresh.TabIndex = 3;
        button_Refresh.Text = "Refresh";
        button_Refresh.UseVisualStyleBackColor = true;
        button_Refresh.Click += button_Refresh_Click;
        // 
        // button_Add
        // 
        button_Add.Location = new System.Drawing.Point(9, 8);
        button_Add.Name = "button_Add";
        button_Add.Size = new System.Drawing.Size(101, 27);
        button_Add.TabIndex = 4;
        button_Add.Text = "Add";
        button_Add.UseVisualStyleBackColor = true;
        button_Add.Click += button_Add_Click;
        // 
        // button_Change
        // 
        button_Change.Location = new System.Drawing.Point(116, 8);
        button_Change.Name = "button_Change";
        button_Change.Size = new System.Drawing.Size(101, 27);
        button_Change.TabIndex = 5;
        button_Change.Text = "Change";
        button_Change.UseVisualStyleBackColor = true;
        button_Change.Click += button_Change_Click;
        // 
        // button_Dalete
        // 
        button_Dalete.Location = new System.Drawing.Point(223, 8);
        button_Dalete.Name = "button_Dalete";
        button_Dalete.Size = new System.Drawing.Size(101, 27);
        button_Dalete.TabIndex = 6;
        button_Dalete.Text = "Delete ";
        button_Dalete.UseVisualStyleBackColor = true;
        button_Dalete.Click += button_Dalete_Click;
        // 
        // textBox_Name
        // 
        textBox_Name.Location = new System.Drawing.Point(12, 52);
        textBox_Name.Name = "textBox_Name";
        textBox_Name.Size = new System.Drawing.Size(181, 23);
        textBox_Name.TabIndex = 7;
        // 
        // textBox_DiscountPrecent
        // 
        textBox_DiscountPrecent.Location = new System.Drawing.Point(199, 52);
        textBox_DiscountPrecent.Name = "textBox_DiscountPrecent";
        textBox_DiscountPrecent.Size = new System.Drawing.Size(74, 23);
        textBox_DiscountPrecent.TabIndex = 8;
        // 
        // dateTimePicker_StartDate
        // 
        dateTimePicker_StartDate.Location = new System.Drawing.Point(279, 52);
        dateTimePicker_StartDate.Name = "dateTimePicker_StartDate";
        dateTimePicker_StartDate.Size = new System.Drawing.Size(101, 23);
        dateTimePicker_StartDate.TabIndex = 9;
        // 
        // dateTimePicker_EndDate
        // 
        dateTimePicker_EndDate.Location = new System.Drawing.Point(386, 52);
        dateTimePicker_EndDate.Name = "dateTimePicker_EndDate";
        dateTimePicker_EndDate.Size = new System.Drawing.Size(101, 23);
        dateTimePicker_EndDate.TabIndex = 10;
        dateTimePicker_EndDate.ValueChanged += dateTimePicker_EndDate_ValueChanged;
        // 
        // PromotionsForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(608, 450);
        Controls.Add(dateTimePicker_EndDate);
        Controls.Add(dateTimePicker_StartDate);
        Controls.Add(textBox_DiscountPrecent);
        Controls.Add(textBox_Name);
        Controls.Add(button_Dalete);
        Controls.Add(button_Change);
        Controls.Add(button_Add);
        Controls.Add(button_Refresh);
        Controls.Add(button_Confirm);
        Controls.Add(button_Cancel);
        Controls.Add(dataGridView1);
        Text = "PromotionsForm";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.DateTimePicker dateTimePicker_EndDate;

    private System.Windows.Forms.DateTimePicker dateTimePicker_StartDate;

    private System.Windows.Forms.TextBox textBox_Name;
    private System.Windows.Forms.TextBox textBox_DiscountPrecent;

    private System.Windows.Forms.Button button_Add;
    private System.Windows.Forms.Button button_Change;
    private System.Windows.Forms.Button button_Dalete;

    private System.Windows.Forms.Button button_Refresh;

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button button_Cancel;
    private System.Windows.Forms.Button button_Confirm;

    #endregion
}