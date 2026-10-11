using System.ComponentModel;

namespace BooksMarketApp_EF_WF.Views;

partial class AddBookForm
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
        groupBox1 = new System.Windows.Forms.GroupBox();
        button_CreatePublishingHouse = new System.Windows.Forms.Button();
        comboBox_PublishingHouse = new System.Windows.Forms.ComboBox();
        groupBox2 = new System.Windows.Forms.GroupBox();
        textBox_BookTitle = new System.Windows.Forms.TextBox();
        groupBox3 = new System.Windows.Forms.GroupBox();
        textBox_ImgUrl = new System.Windows.Forms.TextBox();
        groupBox4 = new System.Windows.Forms.GroupBox();
        button_CreateAuthor = new System.Windows.Forms.Button();
        comboBox_Author = new System.Windows.Forms.ComboBox();
        groupBox5 = new System.Windows.Forms.GroupBox();
        button_CreateGenre = new System.Windows.Forms.Button();
        comboBox_Genre = new System.Windows.Forms.ComboBox();
        groupBox6 = new System.Windows.Forms.GroupBox();
        textBox_PagesNumber = new System.Windows.Forms.TextBox();
        groupBox7 = new System.Windows.Forms.GroupBox();
        textBox_CostPrice = new System.Windows.Forms.TextBox();
        groupBox8 = new System.Windows.Forms.GroupBox();
        textBox_SellingPrice = new System.Windows.Forms.TextBox();
        groupBox9 = new System.Windows.Forms.GroupBox();
        comboBox_ParentBook = new System.Windows.Forms.ComboBox();
        groupBox10 = new System.Windows.Forms.GroupBox();
        textBox_PublishingYear = new System.Windows.Forms.TextBox();
        button_Cancel = new System.Windows.Forms.Button();
        button_Confirm = new System.Windows.Forms.Button();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox4.SuspendLayout();
        groupBox5.SuspendLayout();
        groupBox6.SuspendLayout();
        groupBox7.SuspendLayout();
        groupBox8.SuspendLayout();
        groupBox9.SuspendLayout();
        groupBox10.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(button_CreatePublishingHouse);
        groupBox1.Controls.Add(comboBox_PublishingHouse);
        groupBox1.Location = new System.Drawing.Point(13, 13);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(414, 68);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Publishing House";
        // 
        // button_CreatePublishingHouse
        // 
        button_CreatePublishingHouse.Location = new System.Drawing.Point(348, 26);
        button_CreatePublishingHouse.Name = "button_CreatePublishingHouse";
        button_CreatePublishingHouse.Size = new System.Drawing.Size(47, 21);
        button_CreatePublishingHouse.TabIndex = 1;
        button_CreatePublishingHouse.Text = "Create";
        button_CreatePublishingHouse.UseVisualStyleBackColor = true;
        button_CreatePublishingHouse.Click += button_CreatePublishingHouse_Click;
        // 
        // comboBox_PublishingHouse
        // 
        comboBox_PublishingHouse.FormattingEnabled = true;
        comboBox_PublishingHouse.Location = new System.Drawing.Point(13, 26);
        comboBox_PublishingHouse.Name = "comboBox_PublishingHouse";
        comboBox_PublishingHouse.Size = new System.Drawing.Size(323, 23);
        comboBox_PublishingHouse.TabIndex = 0;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(textBox_BookTitle);
        groupBox2.Location = new System.Drawing.Point(12, 87);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(414, 68);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "Book Title";
        // 
        // textBox_BookTitle
        // 
        textBox_BookTitle.Location = new System.Drawing.Point(12, 27);
        textBox_BookTitle.Name = "textBox_BookTitle";
        textBox_BookTitle.Size = new System.Drawing.Size(388, 23);
        textBox_BookTitle.TabIndex = 0;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(textBox_ImgUrl);
        groupBox3.Location = new System.Drawing.Point(9, 161);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new System.Drawing.Size(416, 68);
        groupBox3.TabIndex = 2;
        groupBox3.TabStop = false;
        groupBox3.Text = "ImgUrl";
        // 
        // textBox_ImgUrl
        // 
        textBox_ImgUrl.Location = new System.Drawing.Point(13, 27);
        textBox_ImgUrl.Name = "textBox_ImgUrl";
        textBox_ImgUrl.Size = new System.Drawing.Size(389, 23);
        textBox_ImgUrl.TabIndex = 0;
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(button_CreateAuthor);
        groupBox4.Controls.Add(comboBox_Author);
        groupBox4.Location = new System.Drawing.Point(11, 235);
        groupBox4.Name = "groupBox4";
        groupBox4.Size = new System.Drawing.Size(415, 68);
        groupBox4.TabIndex = 3;
        groupBox4.TabStop = false;
        groupBox4.Text = "Author";
        // 
        // button_CreateAuthor
        // 
        button_CreateAuthor.Location = new System.Drawing.Point(350, 27);
        button_CreateAuthor.Name = "button_CreateAuthor";
        button_CreateAuthor.Size = new System.Drawing.Size(50, 20);
        button_CreateAuthor.TabIndex = 1;
        button_CreateAuthor.Text = "Create";
        button_CreateAuthor.UseVisualStyleBackColor = true;
        button_CreateAuthor.Click += button_CreateAuthor_Click;
        // 
        // comboBox_Author
        // 
        comboBox_Author.FormattingEnabled = true;
        comboBox_Author.Location = new System.Drawing.Point(11, 25);
        comboBox_Author.Name = "comboBox_Author";
        comboBox_Author.Size = new System.Drawing.Size(327, 23);
        comboBox_Author.TabIndex = 0;
        // 
        // groupBox5
        // 
        groupBox5.Controls.Add(button_CreateGenre);
        groupBox5.Controls.Add(comboBox_Genre);
        groupBox5.Location = new System.Drawing.Point(13, 309);
        groupBox5.Name = "groupBox5";
        groupBox5.Size = new System.Drawing.Size(414, 68);
        groupBox5.TabIndex = 4;
        groupBox5.TabStop = false;
        groupBox5.Text = "Genre";
        // 
        // button_CreateGenre
        // 
        button_CreateGenre.Location = new System.Drawing.Point(346, 27);
        button_CreateGenre.Name = "button_CreateGenre";
        button_CreateGenre.Size = new System.Drawing.Size(52, 20);
        button_CreateGenre.TabIndex = 1;
        button_CreateGenre.Text = "Create";
        button_CreateGenre.UseVisualStyleBackColor = true;
        button_CreateGenre.Click += button_CreateGenre_Click;
        // 
        // comboBox_Genre
        // 
        comboBox_Genre.FormattingEnabled = true;
        comboBox_Genre.Location = new System.Drawing.Point(14, 25);
        comboBox_Genre.Name = "comboBox_Genre";
        comboBox_Genre.Size = new System.Drawing.Size(322, 23);
        comboBox_Genre.TabIndex = 0;
        // 
        // groupBox6
        // 
        groupBox6.Controls.Add(textBox_PagesNumber);
        groupBox6.Location = new System.Drawing.Point(13, 383);
        groupBox6.Name = "groupBox6";
        groupBox6.Size = new System.Drawing.Size(414, 68);
        groupBox6.TabIndex = 5;
        groupBox6.TabStop = false;
        groupBox6.Text = "Pages Number";
        // 
        // textBox_PagesNumber
        // 
        textBox_PagesNumber.Location = new System.Drawing.Point(11, 25);
        textBox_PagesNumber.Name = "textBox_PagesNumber";
        textBox_PagesNumber.Size = new System.Drawing.Size(387, 23);
        textBox_PagesNumber.TabIndex = 0;
        // 
        // groupBox7
        // 
        groupBox7.Controls.Add(textBox_CostPrice);
        groupBox7.Location = new System.Drawing.Point(14, 457);
        groupBox7.Name = "groupBox7";
        groupBox7.Size = new System.Drawing.Size(413, 68);
        groupBox7.TabIndex = 6;
        groupBox7.TabStop = false;
        groupBox7.Text = "Cost Price";
        // 
        // textBox_CostPrice
        // 
        textBox_CostPrice.Location = new System.Drawing.Point(13, 24);
        textBox_CostPrice.Name = "textBox_CostPrice";
        textBox_CostPrice.Size = new System.Drawing.Size(383, 23);
        textBox_CostPrice.TabIndex = 0;
        // 
        // groupBox8
        // 
        groupBox8.Controls.Add(textBox_SellingPrice);
        groupBox8.Location = new System.Drawing.Point(13, 531);
        groupBox8.Name = "groupBox8";
        groupBox8.Size = new System.Drawing.Size(411, 68);
        groupBox8.TabIndex = 7;
        groupBox8.TabStop = false;
        groupBox8.Text = "Selling Price";
        // 
        // textBox_SellingPrice
        // 
        textBox_SellingPrice.Location = new System.Drawing.Point(12, 25);
        textBox_SellingPrice.Name = "textBox_SellingPrice";
        textBox_SellingPrice.Size = new System.Drawing.Size(384, 23);
        textBox_SellingPrice.TabIndex = 0;
        // 
        // groupBox9
        // 
        groupBox9.Controls.Add(comboBox_ParentBook);
        groupBox9.Location = new System.Drawing.Point(11, 605);
        groupBox9.Name = "groupBox9";
        groupBox9.Size = new System.Drawing.Size(415, 68);
        groupBox9.TabIndex = 8;
        groupBox9.TabStop = false;
        groupBox9.Text = "Parent Book";
        // 
        // comboBox_ParentBook
        // 
        comboBox_ParentBook.FormattingEnabled = true;
        comboBox_ParentBook.Location = new System.Drawing.Point(13, 22);
        comboBox_ParentBook.Name = "comboBox_ParentBook";
        comboBox_ParentBook.Size = new System.Drawing.Size(385, 23);
        comboBox_ParentBook.TabIndex = 0;
        // 
        // groupBox10
        // 
        groupBox10.Controls.Add(textBox_PublishingYear);
        groupBox10.Location = new System.Drawing.Point(11, 679);
        groupBox10.Name = "groupBox10";
        groupBox10.Size = new System.Drawing.Size(415, 68);
        groupBox10.TabIndex = 9;
        groupBox10.TabStop = false;
        groupBox10.Text = "Publishing Year";
        // 
        // textBox_PublishingYear
        // 
        textBox_PublishingYear.Location = new System.Drawing.Point(13, 23);
        textBox_PublishingYear.Name = "textBox_PublishingYear";
        textBox_PublishingYear.Size = new System.Drawing.Size(384, 23);
        textBox_PublishingYear.TabIndex = 0;
        // 
        // button_Cancel
        // 
        button_Cancel.Location = new System.Drawing.Point(12, 765);
        button_Cancel.Name = "button_Cancel";
        button_Cancel.Size = new System.Drawing.Size(132, 31);
        button_Cancel.TabIndex = 10;
        button_Cancel.Text = "Cancel";
        button_Cancel.UseVisualStyleBackColor = true;
        button_Cancel.Click += button_Cancel_Click;
        // 
        // button_Confirm
        // 
        button_Confirm.Location = new System.Drawing.Point(295, 765);
        button_Confirm.Name = "button_Confirm";
        button_Confirm.Size = new System.Drawing.Size(129, 31);
        button_Confirm.TabIndex = 11;
        button_Confirm.Text = "Confirm";
        button_Confirm.UseVisualStyleBackColor = true;
        button_Confirm.Click += button_Confirm_Click;
        // 
        // AddBookForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(434, 806);
        Controls.Add(button_Confirm);
        Controls.Add(button_Cancel);
        Controls.Add(groupBox10);
        Controls.Add(groupBox9);
        Controls.Add(groupBox8);
        Controls.Add(groupBox7);
        Controls.Add(groupBox6);
        Controls.Add(groupBox5);
        Controls.Add(groupBox4);
        Controls.Add(groupBox3);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "AddBookForm";
        groupBox1.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        groupBox4.ResumeLayout(false);
        groupBox5.ResumeLayout(false);
        groupBox6.ResumeLayout(false);
        groupBox6.PerformLayout();
        groupBox7.ResumeLayout(false);
        groupBox7.PerformLayout();
        groupBox8.ResumeLayout(false);
        groupBox8.PerformLayout();
        groupBox9.ResumeLayout(false);
        groupBox10.ResumeLayout(false);
        groupBox10.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button_CreatePublishingHouse;

    private System.Windows.Forms.TextBox textBox_PagesNumber;
    private System.Windows.Forms.TextBox textBox_CostPrice;
    private System.Windows.Forms.TextBox textBox_SellingPrice;
    private System.Windows.Forms.TextBox textBox_PublishingYear;
    private System.Windows.Forms.ComboBox comboBox_ParentBook;
    private System.Windows.Forms.Button button_CreateAuthor;
    private System.Windows.Forms.Button button_CreateGenre;

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.GroupBox groupBox6;
    private System.Windows.Forms.GroupBox groupBox7;
    private System.Windows.Forms.GroupBox groupBox8;
    private System.Windows.Forms.GroupBox groupBox9;
    private System.Windows.Forms.GroupBox groupBox10;
    private System.Windows.Forms.Button button_Cancel;
    private System.Windows.Forms.Button button_Confirm;
    private System.Windows.Forms.TextBox textBox_BookTitle;
    private System.Windows.Forms.ComboBox comboBox_PublishingHouse;
    private System.Windows.Forms.TextBox textBox_ImgUrl;
    private System.Windows.Forms.ComboBox comboBox_Author;
    private System.Windows.Forms.ComboBox comboBox_Genre;

    #endregion
}