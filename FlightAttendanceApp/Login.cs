using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightAttendanceApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        private void mainForm()
        {
            if (txtUsername.Text == "Me" && txtPassword.Text == "1234")
            {
                this.Hide();
                new MainForm().Show();


            }
            else
            {
                MessageBox.Show("Username Or Password Incorrect You Dummy!!\n Try Again");

            }
        }
        private void Reset()
        {

            txtUsername.Clear();
            txtPassword.Clear();
            //txtUsername.Focus();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mainForm();
            }
            if (e.KeyChar == (char)Keys.F1)
            {
                Reset();
            }

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            mainForm();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
        }
    }

}
