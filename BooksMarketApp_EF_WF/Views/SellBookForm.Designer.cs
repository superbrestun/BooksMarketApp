using System.ComponentModel;

namespace BooksMarketApp_EF_WF.Views;

partial class SellBookForm
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
        button_Confirm = new System.Windows.Forms.Button();
        button_Cancel = new System.Windows.Forms.Button();
        textBox_Quantity = new System.Windows.Forms.TextBox();
        label_QuantityError = new System.Windows.Forms.Label();
        comboBox_Users = new System.Windows.Forms.ComboBox();
        SuspendLayout();
        // 
        // button_Confirm
        // 
        button_Confirm.Location = new System.Drawing.Point(231, 105);
        button_Confirm.Name = "button_Confirm";
        button_Confirm.Size = new System.Drawing.Size(130, 38);
        button_Confirm.TabIndex = 0;
        button_Confirm.Text = "Confirm";
        button_Confirm.UseVisualStyleBackColor = true;
        button_Confirm.Click += button_Confirm_Click;
        // 
        // button_Cancel
        // 
        button_Cancel.Location = new System.Drawing.Point(12, 105);
        button_Cancel.Name = "button_Cancel";
        button_Cancel.Size = new System.Drawing.Size(130, 38);
        button_Cancel.TabIndex = 1;
        button_Cancel.Text = "Cancel";
        button_Cancel.UseVisualStyleBackColor = true;
        button_Cancel.Click += button_Cancel_Click;
        // 
        // textBox_Quantity
        // 
        textBox_Quantity.Location = new System.Drawing.Point(34, 58);
        textBox_Quantity.Name = "textBox_Quantity";
        textBox_Quantity.Size = new System.Drawing.Size(299, 23);
        textBox_Quantity.TabIndex = 2;
        // 
        // label_QuantityError
        // 
        label_QuantityError.ForeColor = System.Drawing.Color.Red;
        label_QuantityError.Location = new System.Drawing.Point(34, 13);
        label_QuantityError.Name = "label_QuantityError";
        label_QuantityError.Size = new System.Drawing.Size(298, 30);
        label_QuantityError.TabIndex = 3;
        // 
        // comboBox_Users
        // 
        comboBox_Users.FormattingEnabled = true;
        comboBox_Users.Location = new System.Drawing.Point(35, 16);
        comboBox_Users.Name = "comboBox_Users";
        comboBox_Users.Size = new System.Drawing.Size(298, 23);
        comboBox_Users.TabIndex = 4;
        // 
        // SellBookForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(373, 157);
        Controls.Add(comboBox_Users);
        Controls.Add(label_QuantityError);
        Controls.Add(textBox_Quantity);
        Controls.Add(button_Cancel);
        Controls.Add(button_Confirm);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "SellBookForm";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ComboBox comboBox_Users;

    private System.Windows.Forms.Label label_QuantityError;

    private System.Windows.Forms.Button button_Confirm;
    private System.Windows.Forms.TextBox textBox_Quantity;

    private System.Windows.Forms.Button button_Cancel;

    #endregion
}