using System.ComponentModel;

namespace BooksMarketApp_EF_WF.Views;

partial class SignInForm
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
        label_LoginError = new System.Windows.Forms.Label();
        textBox_Login = new System.Windows.Forms.TextBox();
        groupBox2 = new System.Windows.Forms.GroupBox();
        label_EmailError = new System.Windows.Forms.Label();
        textBox_Email = new System.Windows.Forms.TextBox();
        groupBox3 = new System.Windows.Forms.GroupBox();
        label_PasswordError = new System.Windows.Forms.Label();
        checkBox_Password = new System.Windows.Forms.CheckBox();
        textBox_Password = new System.Windows.Forms.TextBox();
        button_Cancel = new System.Windows.Forms.Button();
        button_Confirm = new System.Windows.Forms.Button();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox3.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label_LoginError);
        groupBox1.Controls.Add(textBox_Login);
        groupBox1.Location = new System.Drawing.Point(19, 17);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(397, 96);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Login";
        // 
        // label_LoginError
        // 
        label_LoginError.ForeColor = System.Drawing.Color.Red;
        label_LoginError.Location = new System.Drawing.Point(15, 60);
        label_LoginError.Name = "label_LoginError";
        label_LoginError.Size = new System.Drawing.Size(360, 26);
        label_LoginError.TabIndex = 1;
        // 
        // textBox_Login
        // 
        textBox_Login.Location = new System.Drawing.Point(15, 22);
        textBox_Login.MaxLength = 20;
        textBox_Login.Name = "textBox_Login";
        textBox_Login.Size = new System.Drawing.Size(362, 23);
        textBox_Login.TabIndex = 0;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(label_EmailError);
        groupBox2.Controls.Add(textBox_Email);
        groupBox2.Location = new System.Drawing.Point(19, 136);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(396, 107);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "Email";
        // 
        // label_EmailError
        // 
        label_EmailError.ForeColor = System.Drawing.Color.Red;
        label_EmailError.Location = new System.Drawing.Point(15, 64);
        label_EmailError.Name = "label_EmailError";
        label_EmailError.Size = new System.Drawing.Size(361, 22);
        label_EmailError.TabIndex = 1;
        // 
        // textBox_Email
        // 
        textBox_Email.Location = new System.Drawing.Point(15, 25);
        textBox_Email.MaxLength = 327;
        textBox_Email.Name = "textBox_Email";
        textBox_Email.Size = new System.Drawing.Size(361, 23);
        textBox_Email.TabIndex = 0;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(label_PasswordError);
        groupBox3.Controls.Add(checkBox_Password);
        groupBox3.Controls.Add(textBox_Password);
        groupBox3.Location = new System.Drawing.Point(17, 268);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new System.Drawing.Size(398, 105);
        groupBox3.TabIndex = 2;
        groupBox3.TabStop = false;
        groupBox3.Text = "Password";
        // 
        // label_PasswordError
        // 
        label_PasswordError.ForeColor = System.Drawing.Color.Red;
        label_PasswordError.Location = new System.Drawing.Point(19, 68);
        label_PasswordError.Name = "label_PasswordError";
        label_PasswordError.Size = new System.Drawing.Size(357, 27);
        label_PasswordError.TabIndex = 2;
        // 
        // checkBox_Password
        // 
        checkBox_Password.Location = new System.Drawing.Point(364, 30);
        checkBox_Password.Name = "checkBox_Password";
        checkBox_Password.Size = new System.Drawing.Size(33, 22);
        checkBox_Password.TabIndex = 1;
        checkBox_Password.UseVisualStyleBackColor = true;
        checkBox_Password.CheckedChanged += checkBox_Password_CheckedChanged;
        // 
        // textBox_Password
        // 
        textBox_Password.Location = new System.Drawing.Point(17, 30);
        textBox_Password.Name = "textBox_Password";
        textBox_Password.PasswordChar = '*';
        textBox_Password.Size = new System.Drawing.Size(333, 23);
        textBox_Password.TabIndex = 0;
        // 
        // button_Cancel
        // 
        button_Cancel.Location = new System.Drawing.Point(17, 389);
        button_Cancel.Name = "button_Cancel";
        button_Cancel.Size = new System.Drawing.Size(129, 38);
        button_Cancel.TabIndex = 3;
        button_Cancel.Text = "Cancel";
        button_Cancel.UseVisualStyleBackColor = true;
        button_Cancel.Click += button_Cancel_Click;
        // 
        // button_Confirm
        // 
        button_Confirm.Location = new System.Drawing.Point(284, 390);
        button_Confirm.Name = "button_Confirm";
        button_Confirm.Size = new System.Drawing.Size(131, 37);
        button_Confirm.TabIndex = 4;
        button_Confirm.Text = "Confirm";
        button_Confirm.UseVisualStyleBackColor = true;
        button_Confirm.Click += button_Confirm_Click;
        // 
        // SignInForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(434, 450);
        Controls.Add(button_Confirm);
        Controls.Add(button_Cancel);
        Controls.Add(groupBox3);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "SignInForm";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label_PasswordError;

    private System.Windows.Forms.Label label_LoginError;

    private System.Windows.Forms.TextBox textBox_Email;
    private System.Windows.Forms.TextBox textBox_Password;
    private System.Windows.Forms.CheckBox checkBox_Password;
    private System.Windows.Forms.Label label_EmailError;

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Button button_Cancel;
    private System.Windows.Forms.Button button_Confirm;
    private System.Windows.Forms.TextBox textBox_Login;

    #endregion
}