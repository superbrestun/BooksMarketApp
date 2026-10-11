using System.ComponentModel;

namespace BooksMarketApp_EF_WF.Views;

partial class CreateAuthorForm
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
        groupBox1 = new System.Windows.Forms.GroupBox();
        textBox_AuthorFullname = new System.Windows.Forms.TextBox();
        button_Cancel = new System.Windows.Forms.Button();
        button_Confirm = new System.Windows.Forms.Button();
        button_Create = new System.Windows.Forms.Button();
        button_Change = new System.Windows.Forms.Button();
        button_Delete = new System.Windows.Forms.Button();
        button_Refresh = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.Location = new System.Drawing.Point(3, 73);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new System.Drawing.Size(429, 220);
        dataGridView1.TabIndex = 0;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(textBox_AuthorFullname);
        groupBox1.Location = new System.Drawing.Point(3, 311);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(429, 124);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        groupBox1.Text = "Author Fullname";
        // 
        // textBox_AuthorFullname
        // 
        textBox_AuthorFullname.Location = new System.Drawing.Point(11, 27);
        textBox_AuthorFullname.Name = "textBox_AuthorFullname";
        textBox_AuthorFullname.Size = new System.Drawing.Size(417, 23);
        textBox_AuthorFullname.TabIndex = 0;
        // 
        // button_Cancel
        // 
        button_Cancel.Location = new System.Drawing.Point(12, 441);
        button_Cancel.Name = "button_Cancel";
        button_Cancel.Size = new System.Drawing.Size(118, 35);
        button_Cancel.TabIndex = 2;
        button_Cancel.Text = "Cancel";
        button_Cancel.UseVisualStyleBackColor = true;
        button_Cancel.Click += button_Cancel_Click_1;
        // 
        // button_Confirm
        // 
        button_Confirm.Location = new System.Drawing.Point(306, 441);
        button_Confirm.Name = "button_Confirm";
        button_Confirm.Size = new System.Drawing.Size(116, 35);
        button_Confirm.TabIndex = 3;
        button_Confirm.Text = "Confirm";
        button_Confirm.UseVisualStyleBackColor = true;
        button_Confirm.Click += button_Confirm_Click_1;
        // 
        // button_Create
        // 
        button_Create.Location = new System.Drawing.Point(11, 14);
        button_Create.Name = "button_Create";
        button_Create.Size = new System.Drawing.Size(83, 25);
        button_Create.TabIndex = 4;
        button_Create.Text = "Create";
        button_Create.UseVisualStyleBackColor = true;
        button_Create.Click += button_Create_Click;
        // 
        // button_Change
        // 
        button_Change.Location = new System.Drawing.Point(100, 16);
        button_Change.Name = "button_Change";
        button_Change.Size = new System.Drawing.Size(83, 23);
        button_Change.TabIndex = 5;
        button_Change.Text = "Change";
        button_Change.UseVisualStyleBackColor = true;
        // 
        // button_Delete
        // 
        button_Delete.Location = new System.Drawing.Point(189, 16);
        button_Delete.Name = "button_Delete";
        button_Delete.Size = new System.Drawing.Size(83, 23);
        button_Delete.TabIndex = 6;
        button_Delete.Text = "Delete";
        button_Delete.UseVisualStyleBackColor = true;
        button_Delete.Click += button_Delete_Click;
        // 
        // button_Refresh
        // 
        button_Refresh.Location = new System.Drawing.Point(278, 16);
        button_Refresh.Name = "button_Refresh";
        button_Refresh.Size = new System.Drawing.Size(83, 23);
        button_Refresh.TabIndex = 7;
        button_Refresh.Text = "Refresh";
        button_Refresh.UseVisualStyleBackColor = true;
        button_Refresh.Click += button_Refresh_Click;
        // 
        // CreateAuthorForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(434, 488);
        Controls.Add(button_Refresh);
        Controls.Add(button_Delete);
        Controls.Add(button_Change);
        Controls.Add(button_Create);
        Controls.Add(button_Confirm);
        Controls.Add(button_Cancel);
        Controls.Add(groupBox1);
        Controls.Add(dataGridView1);
        Text = "CreateAuthorForm";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button_Change;
    private System.Windows.Forms.Button button_Delete;
    private System.Windows.Forms.Button button_Refresh;

    private System.Windows.Forms.Button button_Cancel;
    private System.Windows.Forms.Button button_Confirm;
    private System.Windows.Forms.Button button_Create;

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox textBox_AuthorFullname;

    #endregion
}