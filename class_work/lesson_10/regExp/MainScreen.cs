using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace regExp
{
    public partial class FormMainScreen : Form
    {
        public FormMainScreen()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) { MessageBox.Show("I pushed"); }

        private void FormMainScreen_Load(object sender, EventArgs e)
        {
            AuthorizationWindow AuthW = new AuthorizationWindow();
            if (AuthW.ShowDialog() == DialogResult.OK) // вызывает окно и если результат закрытия окна = ок
            {
                string login = "admin";
                string pass = "qwerty";

                if (AuthW.Login == login && AuthW.Password == pass) { MessageBox.Show("Authorizated"); }
                else
                {
                    MessageBox.Show("Authorixation failed");
                    //this.Close();
                    FormMainScreen_Load(sender, e);
                }
            }

        }
    }
}
