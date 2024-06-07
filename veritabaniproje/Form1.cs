using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using veritabaniproje.Helpers;
using veritabaniproje.Models;

namespace veritabaniproje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadAnnouncements();
        }
        private void LoadAnnouncements()
        {
            Api api = new Api();
            Kaynak kaynak;
            var duyuru = api.GetDuyuru(14, out kaynak);
            duyuruLB.Text = duyuru.Text;
            kaynakLB.Text = kaynak.Name;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
        }

        private void cocukEkleButton_Click(object sender, EventArgs e)
        {
            ChildRegistrationForm childregistrationForm = new ChildRegistrationForm();
            childregistrationForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void kaynakLB_Click(object sender, EventArgs e)
        {

        }
    }
}
