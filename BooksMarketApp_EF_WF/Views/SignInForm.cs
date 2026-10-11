using System.Text.RegularExpressions;
using BooksMarketApp_EF_WF.DB;
using BooksMarketApp_EF_WF.DB.Entities;
using BooksMarketApp_EF_WF.DB.Models;

namespace BooksMarketApp_EF_WF.Views;

public partial class SignInForm : Form
{
    
    public User? CreatedUser { get; private set; }
    
    public SignInForm()
    {
        InitializeComponent();
    }

    private void button_Cancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    private void checkBox_Password_CheckedChanged(object sender, EventArgs e)
    {
        textBox_Password.PasswordChar = checkBox_Password.Checked ? '\0' : '*';
    }

    private void button_Confirm_Click(object sender, EventArgs e)
    {
        string regularyEmail = "^[^\\s@]+@[^\\s@]+\\.[^\\s@]+$";

        if (textBox_Login.Text.Length < 3)
        {
            label_LoginError.Text = "Login is  too short";
            return;
        }
        label_LoginError.Text = "";

        if (!Regex.IsMatch(textBox_Email.Text, regularyEmail))
        {
            label_EmailError.Text = "Email is invalid";
            return;
        }
        label_EmailError.Text = "";

        if (textBox_Password.Text.Length < 8)
        {
            label_PasswordError.Text = "Password is too short";
            return;
        }
        label_PasswordError.Text = "";

        User customer = new User() {
            Login = textBox_Login.Text, 
            Email = textBox_Email.Text,
            Password = textBox_Password.Text,
            AdminPermission = false,
            CreatedAt = DateTime.Now
            };

        using (var context = new MyDbContext())
        {
            var UserModel = new UserModel(context);

            if (UserModel.SaveUser(customer))
            {
                CreatedUser = customer;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid creating");
            }
        }
        
    }
}