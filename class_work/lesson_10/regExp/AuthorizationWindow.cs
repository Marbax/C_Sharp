using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace regExp
{
    public partial class AuthorizationWindow : Form
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void AuthorizationWindow_Load(object sender, EventArgs e)
        {
            Activate();
        }

        private void TextBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            Login = textBoxLogin.Text;
            Password = textBoxPassword.Text;

            if (Login == "" || Password == "") { MessageBox.Show("Incorrect Login or Password"); }
            else
            {
                string _loginPattern = @"^[a-zA-Z][a-zA-Z0-9_]{4,12}$";
                string _passwPattern = @"^[a-zA-Z][a-zA-Z0-9_]{4,12}$";

                var _regExpLogin = new Regex(_loginPattern);

                if (!_regExpLogin.IsMatch(Login))
                    MessageBox.Show("Incorrect Login");
                else
                {
                    MessageBox.Show("Correct Login");
                    var _regExpPassw = new Regex(_passwPattern);
                    if (!_regExpPassw.IsMatch(Password))
                        MessageBox.Show("Password Incorrect");
                    else
                    {
                        MessageBox.Show("Correct Password");
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
        }
    }
}
