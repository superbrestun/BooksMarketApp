namespace BooksMarketApp_EF_WF;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        toolStrip1 = new System.Windows.Forms.ToolStrip();
        statusStrip1 = new System.Windows.Forms.StatusStrip();
        splitContainer1 = new System.Windows.Forms.SplitContainer();
        button_CheckUsers = new System.Windows.Forms.Button();
        button_CheckBookInfo = new System.Windows.Forms.Button();
        button_CheckSailStat = new System.Windows.Forms.Button();
        button_CheckPromotions = new System.Windows.Forms.Button();
        button_PutAsideForCustomerBook = new System.Windows.Forms.Button();
        button_PutBookInPromotion = new System.Windows.Forms.Button();
        button_SellBook = new System.Windows.Forms.Button();
        button_SaveBookChanges = new System.Windows.Forms.Button();
        button_DeleteBook = new System.Windows.Forms.Button();
        button_AddBook = new System.Windows.Forms.Button();
        groupBox4 = new System.Windows.Forms.GroupBox();
        textBox_BookTitle = new System.Windows.Forms.TextBox();
        groupBox3 = new System.Windows.Forms.GroupBox();
        textBox_Author = new System.Windows.Forms.TextBox();
        groupBox2 = new System.Windows.Forms.GroupBox();
        comboBox_PublishingHouses = new System.Windows.Forms.ComboBox();
        groupBox1 = new System.Windows.Forms.GroupBox();
        comboBox_Genres = new System.Windows.Forms.ComboBox();
        button_Search = new System.Windows.Forms.Button();
        button_Refresh = new System.Windows.Forms.Button();
        button_GetPopularGenreBook = new System.Windows.Forms.Button();
        button_GetPopularAuthorBooks = new System.Windows.Forms.Button();
        button_GetPopularBooks = new System.Windows.Forms.Button();
        button_GetNewBooks = new System.Windows.Forms.Button();
        dataGridView_Books = new System.Windows.Forms.DataGridView();
        button_CheckBookPromotions = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        groupBox4.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView_Books).BeginInit();
        SuspendLayout();
        // 
        // toolStrip1
        // 
        toolStrip1.Location = new System.Drawing.Point(0, 0);
        toolStrip1.Name = "toolStrip1";
        toolStrip1.Size = new System.Drawing.Size(800, 25);
        toolStrip1.TabIndex = 0;
        toolStrip1.Text = "toolStrip1";
        // 
        // statusStrip1
        // 
        statusStrip1.Location = new System.Drawing.Point(0, 428);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new System.Drawing.Size(800, 22);
        statusStrip1.TabIndex = 1;
        statusStrip1.Text = "statusStrip1";
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
        splitContainer1.Location = new System.Drawing.Point(0, 25);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(button_CheckBookPromotions);
        splitContainer1.Panel1.Controls.Add(button_CheckUsers);
        splitContainer1.Panel1.Controls.Add(button_CheckBookInfo);
        splitContainer1.Panel1.Controls.Add(button_CheckSailStat);
        splitContainer1.Panel1.Controls.Add(button_CheckPromotions);
        splitContainer1.Panel1.Controls.Add(button_PutAsideForCustomerBook);
        splitContainer1.Panel1.Controls.Add(button_PutBookInPromotion);
        splitContainer1.Panel1.Controls.Add(button_SellBook);
        splitContainer1.Panel1.Controls.Add(button_SaveBookChanges);
        splitContainer1.Panel1.Controls.Add(button_DeleteBook);
        splitContainer1.Panel1.Controls.Add(button_AddBook);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(groupBox4);
        splitContainer1.Panel2.Controls.Add(groupBox3);
        splitContainer1.Panel2.Controls.Add(groupBox2);
        splitContainer1.Panel2.Controls.Add(groupBox1);
        splitContainer1.Panel2.Controls.Add(button_Search);
        splitContainer1.Panel2.Controls.Add(button_Refresh);
        splitContainer1.Panel2.Controls.Add(button_GetPopularGenreBook);
        splitContainer1.Panel2.Controls.Add(button_GetPopularAuthorBooks);
        splitContainer1.Panel2.Controls.Add(button_GetPopularBooks);
        splitContainer1.Panel2.Controls.Add(button_GetNewBooks);
        splitContainer1.Panel2.Controls.Add(dataGridView_Books);
        splitContainer1.Size = new System.Drawing.Size(800, 403);
        splitContainer1.SplitterDistance = 206;
        splitContainer1.TabIndex = 2;
        // 
        // button_CheckUsers
        // 
        button_CheckUsers.Location = new System.Drawing.Point(15, 254);
        button_CheckUsers.Name = "button_CheckUsers";
        button_CheckUsers.Size = new System.Drawing.Size(176, 24);
        button_CheckUsers.TabIndex = 11;
        button_CheckUsers.Text = "Check Users";
        button_CheckUsers.UseVisualStyleBackColor = true;
        // 
        // button_CheckBookInfo
        // 
        button_CheckBookInfo.Location = new System.Drawing.Point(16, 284);
        button_CheckBookInfo.Name = "button_CheckBookInfo";
        button_CheckBookInfo.Size = new System.Drawing.Size(176, 24);
        button_CheckBookInfo.TabIndex = 10;
        button_CheckBookInfo.Text = "Check Book Info";
        button_CheckBookInfo.UseVisualStyleBackColor = true;
        // 
        // button_CheckSailStat
        // 
        button_CheckSailStat.Location = new System.Drawing.Point(12, 224);
        button_CheckSailStat.Name = "button_CheckSailStat";
        button_CheckSailStat.Size = new System.Drawing.Size(177, 24);
        button_CheckSailStat.TabIndex = 9;
        button_CheckSailStat.Text = "Check Sales Statisticks";
        button_CheckSailStat.UseVisualStyleBackColor = true;
        button_CheckSailStat.Click += button_CheckSailStat_Click;
        // 
        // button_CheckPromotions
        // 
        button_CheckPromotions.Location = new System.Drawing.Point(15, 194);
        button_CheckPromotions.Name = "button_CheckPromotions";
        button_CheckPromotions.Size = new System.Drawing.Size(177, 24);
        button_CheckPromotions.TabIndex = 8;
        button_CheckPromotions.Text = "Check Promotions";
        button_CheckPromotions.UseVisualStyleBackColor = true;
        button_CheckPromotions.Click += button_CheckPromotions_Click;
        // 
        // button_PutAsideForCustomerBook
        // 
        button_PutAsideForCustomerBook.Location = new System.Drawing.Point(15, 164);
        button_PutAsideForCustomerBook.Name = "button_PutAsideForCustomerBook";
        button_PutAsideForCustomerBook.Size = new System.Drawing.Size(177, 24);
        button_PutAsideForCustomerBook.TabIndex = 6;
        button_PutAsideForCustomerBook.Text = "Put aside for customer";
        button_PutAsideForCustomerBook.UseVisualStyleBackColor = true;
        // 
        // button_PutBookInPromotion
        // 
        button_PutBookInPromotion.Location = new System.Drawing.Point(15, 134);
        button_PutBookInPromotion.Name = "button_PutBookInPromotion";
        button_PutBookInPromotion.Size = new System.Drawing.Size(177, 24);
        button_PutBookInPromotion.TabIndex = 5;
        button_PutBookInPromotion.Text = "Put in promotion";
        button_PutBookInPromotion.UseVisualStyleBackColor = true;
        // 
        // button_SellBook
        // 
        button_SellBook.Location = new System.Drawing.Point(15, 104);
        button_SellBook.Name = "button_SellBook";
        button_SellBook.Size = new System.Drawing.Size(177, 24);
        button_SellBook.TabIndex = 3;
        button_SellBook.Text = "Sell Book";
        button_SellBook.UseVisualStyleBackColor = true;
        button_SellBook.Click += button_SellBook_Click;
        // 
        // button_SaveBookChanges
        // 
        button_SaveBookChanges.Location = new System.Drawing.Point(15, 74);
        button_SaveBookChanges.Name = "button_SaveBookChanges";
        button_SaveBookChanges.Size = new System.Drawing.Size(177, 24);
        button_SaveBookChanges.TabIndex = 2;
        button_SaveBookChanges.Text = "Save Book Changes";
        button_SaveBookChanges.UseVisualStyleBackColor = true;
        button_SaveBookChanges.Click += button_SaveBookChanges_Click;
        // 
        // button_DeleteBook
        // 
        button_DeleteBook.Location = new System.Drawing.Point(15, 45);
        button_DeleteBook.Name = "button_DeleteBook";
        button_DeleteBook.Size = new System.Drawing.Size(177, 24);
        button_DeleteBook.TabIndex = 1;
        button_DeleteBook.Text = "Delete Book";
        button_DeleteBook.UseVisualStyleBackColor = true;
        button_DeleteBook.Click += button_DeleteBook_Click;
        // 
        // button_AddBook
        // 
        button_AddBook.Location = new System.Drawing.Point(15, 15);
        button_AddBook.Name = "button_AddBook";
        button_AddBook.Size = new System.Drawing.Size(177, 24);
        button_AddBook.TabIndex = 0;
        button_AddBook.Text = "Add Book";
        button_AddBook.UseVisualStyleBackColor = true;
        button_AddBook.Click += button_AddBook_Click;
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(textBox_BookTitle);
        groupBox4.Location = new System.Drawing.Point(388, 36);
        groupBox4.Name = "groupBox4";
        groupBox4.Size = new System.Drawing.Size(119, 48);
        groupBox4.TabIndex = 12;
        groupBox4.TabStop = false;
        groupBox4.Text = "BookTitle";
        // 
        // textBox_BookTitle
        // 
        textBox_BookTitle.Location = new System.Drawing.Point(0, 19);
        textBox_BookTitle.Name = "textBox_BookTitle";
        textBox_BookTitle.Size = new System.Drawing.Size(118, 23);
        textBox_BookTitle.TabIndex = 0;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(textBox_Author);
        groupBox3.Location = new System.Drawing.Point(250, 36);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new System.Drawing.Size(132, 48);
        groupBox3.TabIndex = 11;
        groupBox3.TabStop = false;
        groupBox3.Text = "Author";
        // 
        // textBox_Author
        // 
        textBox_Author.Location = new System.Drawing.Point(0, 19);
        textBox_Author.Name = "textBox_Author";
        textBox_Author.Size = new System.Drawing.Size(132, 23);
        textBox_Author.TabIndex = 0;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(comboBox_PublishingHouses);
        groupBox2.Location = new System.Drawing.Point(127, 37);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(117, 47);
        groupBox2.TabIndex = 10;
        groupBox2.TabStop = false;
        groupBox2.Text = "PublishingHouse";
        // 
        // comboBox_PublishingHouses
        // 
        comboBox_PublishingHouses.FormattingEnabled = true;
        comboBox_PublishingHouses.Location = new System.Drawing.Point(0, 18);
        comboBox_PublishingHouses.Name = "comboBox_PublishingHouses";
        comboBox_PublishingHouses.Size = new System.Drawing.Size(117, 23);
        comboBox_PublishingHouses.TabIndex = 0;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(comboBox_Genres);
        groupBox1.Location = new System.Drawing.Point(12, 36);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(109, 48);
        groupBox1.TabIndex = 9;
        groupBox1.TabStop = false;
        groupBox1.Text = "Genre";
        // 
        // comboBox_Genres
        // 
        comboBox_Genres.FormattingEnabled = true;
        comboBox_Genres.Location = new System.Drawing.Point(0, 19);
        comboBox_Genres.Name = "comboBox_Genres";
        comboBox_Genres.Size = new System.Drawing.Size(108, 23);
        comboBox_Genres.TabIndex = 0;
        // 
        // button_Search
        // 
        button_Search.Location = new System.Drawing.Point(513, 45);
        button_Search.Name = "button_Search";
        button_Search.Size = new System.Drawing.Size(74, 25);
        button_Search.TabIndex = 8;
        button_Search.Text = "Search";
        button_Search.UseVisualStyleBackColor = true;
        button_Search.Click += button_Search_Click_1;
        // 
        // button_Refresh
        // 
        button_Refresh.Location = new System.Drawing.Point(513, 10);
        button_Refresh.Name = "button_Refresh";
        button_Refresh.Size = new System.Drawing.Size(74, 24);
        button_Refresh.TabIndex = 7;
        button_Refresh.Text = "Refresh";
        button_Refresh.UseVisualStyleBackColor = true;
        button_Refresh.Click += button_Refresh_Click;
        // 
        // button_GetPopularGenreBook
        // 
        button_GetPopularGenreBook.Location = new System.Drawing.Point(245, 10);
        button_GetPopularGenreBook.Name = "button_GetPopularGenreBook";
        button_GetPopularGenreBook.Size = new System.Drawing.Size(112, 21);
        button_GetPopularGenreBook.TabIndex = 6;
        button_GetPopularGenreBook.Text = "Popular Genre";
        button_GetPopularGenreBook.UseVisualStyleBackColor = true;
        // 
        // button_GetPopularAuthorBooks
        // 
        button_GetPopularAuthorBooks.Location = new System.Drawing.Point(136, 9);
        button_GetPopularAuthorBooks.Name = "button_GetPopularAuthorBooks";
        button_GetPopularAuthorBooks.Size = new System.Drawing.Size(103, 23);
        button_GetPopularAuthorBooks.TabIndex = 5;
        button_GetPopularAuthorBooks.Text = "Popular Author";
        button_GetPopularAuthorBooks.UseVisualStyleBackColor = true;
        // 
        // button_GetPopularBooks
        // 
        button_GetPopularBooks.Location = new System.Drawing.Point(69, 9);
        button_GetPopularBooks.Name = "button_GetPopularBooks";
        button_GetPopularBooks.Size = new System.Drawing.Size(61, 24);
        button_GetPopularBooks.TabIndex = 4;
        button_GetPopularBooks.Text = "Popular";
        button_GetPopularBooks.UseVisualStyleBackColor = true;
        button_GetPopularBooks.Click += button_GetPopularBooks_Click;
        // 
        // button_GetNewBooks
        // 
        button_GetNewBooks.Location = new System.Drawing.Point(11, 9);
        button_GetNewBooks.Name = "button_GetNewBooks";
        button_GetNewBooks.Size = new System.Drawing.Size(52, 24);
        button_GetNewBooks.TabIndex = 3;
        button_GetNewBooks.Text = "New";
        button_GetNewBooks.UseVisualStyleBackColor = true;
        button_GetNewBooks.Click += button_GetNewBooks_Click;
        // 
        // dataGridView_Books
        // 
        dataGridView_Books.Location = new System.Drawing.Point(3, 84);
        dataGridView_Books.Name = "dataGridView_Books";
        dataGridView_Books.Size = new System.Drawing.Size(584, 316);
        dataGridView_Books.TabIndex = 0;
        // 
        // button_CheckBookPromotions
        // 
        button_CheckBookPromotions.Location = new System.Drawing.Point(16, 314);
        button_CheckBookPromotions.Name = "button_CheckBookPromotions";
        button_CheckBookPromotions.Size = new System.Drawing.Size(175, 25);
        button_CheckBookPromotions.TabIndex = 12;
        button_CheckBookPromotions.Text = "Check Book Promotions";
        button_CheckBookPromotions.UseVisualStyleBackColor = true;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(splitContainer1);
        Controls.Add(statusStrip1);
        Controls.Add(toolStrip1);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "BookStorage App";
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        groupBox4.ResumeLayout(false);
        groupBox4.PerformLayout();
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView_Books).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button button_CheckBookPromotions;

    private System.Windows.Forms.Button button_CheckUsers;

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.ComboBox comboBox_Genres;
    private System.Windows.Forms.ComboBox comboBox_PublishingHouses;
    private System.Windows.Forms.TextBox textBox_Author;
    private System.Windows.Forms.TextBox textBox_BookTitle;

    private System.Windows.Forms.Button button_Search;

    private System.Windows.Forms.Button button_CheckBookInfo;

    private System.Windows.Forms.Button button_Refresh;

    private System.Windows.Forms.Button button_PutBookInPromotion;
    private System.Windows.Forms.Button button_PutAsideForCustomerBook;
    private System.Windows.Forms.Button button_CheckPromotions;
    private System.Windows.Forms.Button button_CheckSailStat;

    private System.Windows.Forms.Button button_GetPopularAuthorBooks;
    private System.Windows.Forms.Button button_GetPopularGenreBook;
    private System.Windows.Forms.Button button_AddBook;
    private System.Windows.Forms.Button button_DeleteBook;
    private System.Windows.Forms.Button button_SaveBookChanges;
    private System.Windows.Forms.Button button_SellBook;

    private System.Windows.Forms.Button button_GetNewBooks;
    private System.Windows.Forms.Button button_GetPopularBooks;

    private System.Windows.Forms.DataGridView dataGridView_Books;

    private System.Windows.Forms.SplitContainer splitContainer1;

    private System.Windows.Forms.StatusStrip statusStrip1;

    private System.Windows.Forms.ToolStrip toolStrip1;

    #endregion
}