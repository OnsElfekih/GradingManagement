using System.Drawing;
using System.Windows.Forms;
using System;

namespace miniprojet
{
    public partial class espAdmin : Form
    {
        private string errorMessageUsername = string.Empty;
        private string errorMessagePassword = string.Empty;

        public espAdmin()
        {
            InitializeComponent();
            button_login.Enabled = false;
        }

        private void textBox_usrname_TextChanged(object sender, EventArgs e)
        {
            ToggleLoginButton();
            errorMessageUsername = string.Empty;
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            ToggleLoginButton();
            errorMessagePassword = string.Empty;
        }

        private void ToggleLoginButton()
        {
            button_login.Enabled = !string.IsNullOrWhiteSpace(textBox_usrname.Text) &&
                                   !string.IsNullOrWhiteSpace(textBox_password.Text);
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username = textBox_usrname.Text;
            string password = textBox_password.Text;

            errorMessageUsername = string.Empty;
            errorMessagePassword = string.Empty;

            if (username != "adminadmin")
            {
                errorMessageUsername = "Le nom d'utilisateur est incorrect.";
                textBox_usrname.BackColor = Color.Pink;
            }
            else
            {
                textBox_usrname.BackColor = SystemColors.Window;
            }

            if (password != "adminadmin")
            {
                errorMessagePassword = "Le mot de passe est incorrect.";
                textBox_password.BackColor = Color.Pink;
            }
            else
            {
                textBox_password.BackColor = SystemColors.Window;
            }

            if (!string.IsNullOrEmpty(errorMessageUsername))
            {
                labelErrorUsername.Text = errorMessageUsername;
                labelErrorUsername.ForeColor = Color.Red;
                labelErrorUsername.Font = new Font(labelErrorUsername.Font, FontStyle.Bold);
                labelErrorUsername.Visible = true;
            }
            else
            {
                labelErrorUsername.Visible = false;
            }

            if (!string.IsNullOrEmpty(errorMessagePassword))
            {
                labelErrorPassword.Text = errorMessagePassword;
                labelErrorPassword.ForeColor = Color.Red;
                labelErrorPassword.Font = new Font(labelErrorPassword.Font, FontStyle.Bold);
                labelErrorPassword.Visible = true;
            }
            else
            {
                labelErrorPassword.Visible = false;
            }
        }
    }
}
