using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using LoginSystem.Model;

namespace LoginSystem
{
    public partial class FormLogin : Form
    {
        public static bool CancelOption = false;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("User or Password  invalid");
                return;
            }

            var user = new User(txtUser.Text, txtPassword.Text);

            if (SignUpUser.Login(user))
            {
                Close();
                return;
            }
            MessageBox.Show("User inexistent or credentials is invalid");
            txtUser.Text = "";
            txtPassword.Text = "";
            txtUser.Focus();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelOption = true;
            Close();
        }

        private void chkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxPassword.Checked)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';

        }
    }
}