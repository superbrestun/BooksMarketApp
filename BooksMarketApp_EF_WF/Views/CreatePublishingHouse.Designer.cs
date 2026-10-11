using System.ComponentModel;

namespace BooksMarketApp_EF_WF.Views;

partial class CreatePublishingHouse
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
        button_CreateHouse = new System.Windows.Forms.Button();
        button_ChangeHouse = new System.Windows.Forms.Button();
        button_DeleteHouse = new System.Windows.Forms.Button();
        button_RefreshData = new System.Windows.Forms.Button();
        groupBox1 = new System.Windows.Forms.GroupBox();
        textBox_PublishingHouseName = new System.Windows.Forms.TextBox();
        button_Cancel = new System.Windows.Forms.Button();
        button_Confirm = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.Location = new System.Drawing.Point(1, 49);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new System.Drawing.Size(430, 277);
        dataGridView1.TabIndex = 0;
        // 
        // button_CreateHouse
        // 
        button_CreateHouse.Location = new System.Drawing.Point(11, 15);
        button_CreateHouse.Name = "button_CreateHouse";
        button_CreateHouse.Size = new System.Drawing.Size(77, 28);
        button_CreateHouse.TabIndex = 1;
        button_CreateHouse.Text = "Create";
        button_CreateHouse.UseVisualStyleBackColor = true;
        button_CreateHouse.Click += button_CreateHouse_Click;
        // 
        // button_ChangeHouse
        // 
        button_ChangeHouse.Location = new System.Drawing.Point(94, 15);
        button_ChangeHouse.Name = "button_ChangeHouse";
        button_ChangeHouse.Size = new System.Drawing.Size(76, 28);
        button_ChangeHouse.TabIndex = 2;
        button_ChangeHouse.Text = "Change";
        button_ChangeHouse.UseVisualStyleBackColor = true;
        button_ChangeHouse.Click += button_ChangeHouse_Click;
        // 
        // button_DeleteHouse
        // 
        button_DeleteHouse.Location = new System.Drawing.Point(176, 15);
        button_DeleteHouse.Name = "button_DeleteHouse";
        button_DeleteHouse.Size = new System.Drawing.Size(76, 28);
        button_DeleteHouse.TabIndex = 3;
        button_DeleteHouse.Text = "Delete";
        button_DeleteHouse.UseVisualStyleBackColor = true;
        button_DeleteHouse.Click += button_DeleteHouse_Click;
        // 
        // button_RefreshData
        // 
        button_RefreshData.Location = new System.Drawing.Point(258, 15);
        button_RefreshData.Name = "button_RefreshData";
        button_RefreshData.Size = new System.Drawing.Size(76, 28);
        button_RefreshData.TabIndex = 4;
        button_RefreshData.Text = "Refresh";
        button_RefreshData.UseVisualStyleBackColor = true;
        button_RefreshData.Click += button_RefreshData_Click;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(textBox_PublishingHouseName);
        groupBox1.Location = new System.Drawing.Point(9, 341);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(412, 139);
        groupBox1.TabIndex = 5;
        groupBox1.TabStop = false;
        groupBox1.Text = "Publishing House Name";
        // 
        // textBox_PublishingHouseName
        // 
        textBox_PublishingHouseName.Location = new System.Drawing.Point(15, 29);
        textBox_PublishingHouseName.MaxLength = 32;
        textBox_PublishingHouseName.Name = "textBox_PublishingHouseName";
        textBox_PublishingHouseName.Size = new System.Drawing.Size(386, 23);
        textBox_PublishingHouseName.TabIndex = 0;
        // 
        // button_Cancel
        // 
        button_Cancel.Location = new System.Drawing.Point(24, 486);
        button_Cancel.Name = "button_Cancel";
        button_Cancel.Size = new System.Drawing.Size(112, 33);
        button_Cancel.TabIndex = 6;
        button_Cancel.Text = "Cancel";
        button_Cancel.UseVisualStyleBackColor = true;
        button_Cancel.Click += button_Cancel_Click;
        // 
        // button_Confirm
        // 
        button_Confirm.Location = new System.Drawing.Point(300, 486);
        button_Confirm.Name = "button_Confirm";
        button_Confirm.Size = new System.Drawing.Size(110, 33);
        button_Confirm.TabIndex = 7;
        button_Confirm.Text = "Confirm";
        button_Confirm.UseVisualStyleBackColor = true;
        button_Confirm.Click += button_Confirm_Click;
        // 
        // CreatePublishingHouse
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(434, 534);
        Controls.Add(button_Confirm);
        Controls.Add(button_Cancel);
        Controls.Add(groupBox1);
        Controls.Add(button_RefreshData);
        Controls.Add(button_DeleteHouse);
        Controls.Add(button_ChangeHouse);
        Controls.Add(button_CreateHouse);
        Controls.Add(dataGridView1);
        Text = "CreatePublishingHouse";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button button_CreateHouse;
    private System.Windows.Forms.Button button_ChangeHouse;
    private System.Windows.Forms.Button button_DeleteHouse;
    private System.Windows.Forms.Button button_RefreshData;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox textBox_PublishingHouseName;
    private System.Windows.Forms.Button button_Cancel;
    private System.Windows.Forms.Button button_Confirm;

    #endregion
}