using System.ComponentModel;

namespace BooksMarketApp_EF_WF.Views;

partial class CreateGenreForm
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
        textBox_GenreName = new System.Windows.Forms.TextBox();
        button_Cancel = new System.Windows.Forms.Button();
        button_Confirm = new System.Windows.Forms.Button();
        button_Create = new System.Windows.Forms.Button();
        button_Update = new System.Windows.Forms.Button();
        button_Delete = new System.Windows.Forms.Button();
        button_Refresh = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.Location = new System.Drawing.Point(1, 73);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new System.Drawing.Size(431, 234);
        dataGridView1.TabIndex = 0;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(textBox_GenreName);
        groupBox1.Location = new System.Drawing.Point(5, 313);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(427, 127);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        groupBox1.Text = "Genre";
        // 
        // textBox_GenreName
        // 
        textBox_GenreName.Location = new System.Drawing.Point(13, 25);
        textBox_GenreName.Name = "textBox_GenreName";
        textBox_GenreName.Size = new System.Drawing.Size(403, 23);
        textBox_GenreName.TabIndex = 0;
        // 
        // button_Cancel
        // 
        button_Cancel.Location = new System.Drawing.Point(18, 446);
        button_Cancel.Name = "button_Cancel";
        button_Cancel.Size = new System.Drawing.Size(115, 30);
        button_Cancel.TabIndex = 2;
        button_Cancel.Text = "Cancel";
        button_Cancel.UseVisualStyleBackColor = true;
        button_Cancel.Click += button_Cancel_Click;
        // 
        // button_Confirm
        // 
        button_Confirm.Location = new System.Drawing.Point(306, 446);
        button_Confirm.Name = "button_Confirm";
        button_Confirm.Size = new System.Drawing.Size(115, 30);
        button_Confirm.TabIndex = 3;
        button_Confirm.Text = "Confirm";
        button_Confirm.UseVisualStyleBackColor = true;
        button_Confirm.Click += button_Confirm_Click;
        // 
        // button_Create
        // 
        button_Create.Location = new System.Drawing.Point(9, 10);
        button_Create.Name = "button_Create";
        button_Create.Size = new System.Drawing.Size(87, 25);
        button_Create.TabIndex = 4;
        button_Create.Text = "Create";
        button_Create.UseVisualStyleBackColor = true;
        button_Create.Click += button_Create_Click;
        // 
        // button_Update
        // 
        button_Update.Location = new System.Drawing.Point(102, 10);
        button_Update.Name = "button_Update";
        button_Update.Size = new System.Drawing.Size(87, 25);
        button_Update.TabIndex = 5;
        button_Update.Text = "Update";
        button_Update.UseVisualStyleBackColor = true;
        // 
        // button_Delete
        // 
        button_Delete.Location = new System.Drawing.Point(195, 10);
        button_Delete.Name = "button_Delete";
        button_Delete.Size = new System.Drawing.Size(87, 25);
        button_Delete.TabIndex = 6;
        button_Delete.Text = "Delete";
        button_Delete.UseVisualStyleBackColor = true;
        button_Delete.Click += button_Delete_Click;
        // 
        // button_Refresh
        // 
        button_Refresh.Location = new System.Drawing.Point(288, 10);
        button_Refresh.Name = "button_Refresh";
        button_Refresh.Size = new System.Drawing.Size(87, 25);
        button_Refresh.TabIndex = 7;
        button_Refresh.Text = "Refresh";
        button_Refresh.UseVisualStyleBackColor = true;
        button_Refresh.Click += button_Refresh_Click;
        // 
        // CreateGenreForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(434, 551);
        Controls.Add(button_Refresh);
        Controls.Add(button_Delete);
        Controls.Add(button_Update);
        Controls.Add(button_Create);
        Controls.Add(button_Confirm);
        Controls.Add(button_Cancel);
        Controls.Add(groupBox1);
        Controls.Add(dataGridView1);
        Text = "CreateGenreForm";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button_Create;
    private System.Windows.Forms.Button button_Update;
    private System.Windows.Forms.Button button_Delete;
    private System.Windows.Forms.Button button_Refresh;

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox textBox_GenreName;
    private System.Windows.Forms.Button button_Confirm;
    private System.Windows.Forms.Button button_Cancel;

    #endregion
}