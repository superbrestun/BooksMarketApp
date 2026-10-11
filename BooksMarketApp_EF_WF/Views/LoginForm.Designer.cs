using System.ComponentModel;

namespace BooksMarketApp_EF_WF.Views;

partial class LoginForm
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
        checkBox_Password = new System.Windows.Forms.CheckBox();
        textBox_Password = new System.Windows.Forms.TextBox();
        label_PasswordError = new System.Windows.Forms.Label();
        button_SignIn = new System.Windows.Forms.Button();
        button_Cancel = new System.Windows.Forms.Button();
        button_Confirm = new System.Windows.Forms.Button();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label_LoginError);
        groupBox1.Controls.Add(textBox_Login);
        groupBox1.Location = new System.Drawing.Point(23, 62);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(389, 118);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Login";
        // 
        // label_LoginError
        // 
        label_LoginError.Font = new System.Drawing.Font("Segoe UI", 12F);
        label_LoginError.ForeColor = System.Drawing.Color.Red;
        label_LoginError.Location = new System.Drawing.Point(21, 68);
        label_LoginError.Name = "label_LoginError";
        label_LoginError.Size = new System.Drawing.Size(357, 28);
        label_LoginError.TabIndex = 1;
        label_LoginError.Click += label_LoginError_Click;
        // 
        // textBox_Login
        // 
        textBox_Login.Location = new System.Drawing.Point(18, 32);
        textBox_Login.MaxLength = 20;
        textBox_Login.Name = "textBox_Login";
        textBox_Login.Size = new System.Drawing.Size(360, 23);
        textBox_Login.TabIndex = 0;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(checkBox_Password);
        groupBox2.Controls.Add(textBox_Password);
        groupBox2.Controls.Add(label_PasswordError);
        groupBox2.Location = new System.Drawing.Point(23, 208);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(389, 116);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "Password";
        // 
        // checkBox_Password
        // 
        checkBox_Password.Location = new System.Drawing.Point(353, 29);
        checkBox_Password.Name = "checkBox_Password";
        checkBox_Password.Size = new System.Drawing.Size(25, 22);
        checkBox_Password.TabIndex = 4;
        checkBox_Password.UseVisualStyleBackColor = true;
        checkBox_Password.CheckedChanged += checkBox_Password_CheckedChanged;
        // 
        // textBox_Password
        // 
        textBox_Password.Location = new System.Drawing.Point(18, 28);
        textBox_Password.Name = "textBox_Password";
        textBox_Password.PasswordChar = '*';
        textBox_Password.Size = new System.Drawing.Size(325, 23);
        textBox_Password.TabIndex = 3;
        // 
        // label_PasswordError
        // 
        label_PasswordError.Font = new System.Drawing.Font("Segoe UI", 12F);
        label_PasswordError.ForeColor = System.Drawing.Color.Red;
        label_PasswordError.Location = new System.Drawing.Point(18, 66);
        label_PasswordError.Name = "label_PasswordError";
        label_PasswordError.Size = new System.Drawing.Size(360, 28);
        label_PasswordError.TabIndex = 2;
        // 
        // button_SignIn
        // 
        button_SignIn.Location = new System.Drawing.Point(343, 12);
        button_SignIn.Name = "button_SignIn";
        button_SignIn.Size = new System.Drawing.Size(69, 31);
        button_SignIn.TabIndex = 2;
        button_SignIn.Text = "Sign in";
        button_SignIn.UseVisualStyleBackColor = true;
        button_SignIn.Click += button_SignIn_Click;
        // 
        // button_Cancel
        // 
        button_Cancel.Location = new System.Drawing.Point(23, 349);
        button_Cancel.Name = "button_Cancel";
        button_Cancel.Size = new System.Drawing.Size(127, 39);
        button_Cancel.TabIndex = 3;
        button_Cancel.Text = "Cancel";
        button_Cancel.UseVisualStyleBackColor = true;
        button_Cancel.Click += button_Cancel_Click_1;
        // 
        // button_Confirm
        // 
        button_Confirm.Location = new System.Drawing.Point(286, 349);
        button_Confirm.Name = "button_Confirm";
        button_Confirm.Size = new System.Drawing.Size(126, 39);
        button_Confirm.TabIndex = 4;
        button_Confirm.Text = "Confirm";
        button_Confirm.UseVisualStyleBackColor = true;
        button_Confirm.Click += button_Confirm_Click_1;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(434, 450);
        Controls.Add(button_Confirm);
        Controls.Add(button_Cancel);
        Controls.Add(button_SignIn);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "LoginForm";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.CheckBox checkBox_Password;

    private System.Windows.Forms.Button button_Cancel;
    private System.Windows.Forms.Button button_Confirm;

    private System.Windows.Forms.Label label_PasswordError;
    private System.Windows.Forms.TextBox textBox_Password;

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button button_SignIn;
    private System.Windows.Forms.TextBox textBox_Login;
    private System.Windows.Forms.Label label_LoginError;

    #endregion
}