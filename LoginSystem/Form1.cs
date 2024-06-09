using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginSystem.Model;

namespace LoginSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            FormLogin formLogin = new FormLogin();
            while (SignUpUser.LoggedInUser == null)
            {
                Visible = false;
                formLogin.ShowDialog();
                if (FormLogin.CancelOption)
                {
                    Application.Exit();
                    return;
                }
            }

            lblBoasVindas.Text = $"Bem Vindo(a) \n {SignUpUser.LoggedInUser.Nickname}";
            Visible = true;
        }
    }
}