using BooksMarketApp_EF_WF.DB;
using BooksMarketApp_EF_WF.DB.Entities;
using BooksMarketApp_EF_WF.DB.Models;

namespace BooksMarketApp_EF_WF.Views;

public partial class LoginForm : Form
{
    
    public User? User { get; private set; }
    
    public LoginForm()
    {
        InitializeComponent();
    }

    private void label_LoginError_Click(object sender, EventArgs e) { }

    private void button_Confirm_Click_1(object sender, EventArgs e)
    {
        if (textBox_Login.Text.Length < 3)
        {
            label_LoginError.Text = "Login is too short";
            return;
        }
        label_LoginError.Text = "";
        
        if (textBox_Password.Text.Length < 8)
        {
            label_PasswordError.Text = "Password is too short";
            return;
        }
        label_PasswordError.Text = "";
        
        string login = textBox_Login.Text.Trim();
        string password = textBox_Password.Text.Trim();
        
        using (var context = new MyDbContext())
        {
            var userModel = new UserModel(context);
            
            var user = userModel.GetUserByLogin(login, password);

            if (user != null)
            {
                User = user;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid login or password or user is not exist");
            }
        }
    }

    private void button_Cancel_Click_1(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }


    private void checkBox_Password_CheckedChanged(object sender, EventArgs e)
    {
        textBox_Password.PasswordChar = checkBox_Password.Checked ? '\0' : '*';
    }

    private void button_SignIn_Click(object sender, EventArgs e)
    {
        using (SignInForm signInForm = new SignInForm())
        {
            signInForm.Owner = this;

            if (signInForm.ShowDialog() == DialogResult.OK && signInForm.CreatedUser != null)
            {
                FillFieldsWithUserData(signInForm.CreatedUser);
            }
        }
    }

    private void FillFieldsWithUserData(User user)
    {
        User = user;
        textBox_Login.Text = user.Login;
        textBox_Password.Text = user.Password;
    }
}