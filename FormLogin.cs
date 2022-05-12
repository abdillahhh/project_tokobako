using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokoBako
{
    public partial class FormLogin : Form
    {
        readonly string Username = "sadam";
        readonly string Password = "12345";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == Username && textBoxPW.Text == Password)
            {
                MessageBox.Show("Kamu Berhasil Login");
                Hide();
                FormHome formHome = new FormHome();
                formHome.ShowDialog();
            }
            else if (textBoxUserName.Text == "" || textBoxPW.Text == "")
            {
                MessageBox.Show("Mohon Masukan Username dan Password!");
            }
            else
            {
                MessageBox.Show("Username atau Password Salah");
            }
        }
    }
}
