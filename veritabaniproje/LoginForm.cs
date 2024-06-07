using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using veritabaniproje.Helpers;
using veritabaniproje.Models;

namespace veritabaniproje
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            string tckn = loginTckTB.Text;
            string password = loginPasTB.Text;

            if (string.IsNullOrEmpty(tckn) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.", "Uyarı", MessageBoxButtons.OK);
                return;
            }

            if (tckn.Length != 11 || password.Length < 6 || password.Length > 20)
            {
                MessageBox.Show("TCKN 11 haneli olmalı, şifre en az 6 en uzun 20 haneli olmalı. Kontrol edin.", "Uyarı", MessageBoxButtons.OK);
                return;
            }

            Api api = new Api();
            User user = api.LoginUser(tckn, password);

            if (user.AdSoyad != null)
            {
                Constants.user = user;
                MessageBox.Show("Giriş başarılı.", "Başarılı", MessageBoxButtons.OK);
                GoHome();
            }
            else
            {
                MessageBox.Show("Giriş yapılamadı. Kayıt olun veya bilgileri kontrol edin.", "Başarısız", MessageBoxButtons.OK);
            }
        }

        private void GoHome()
        {
            var f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1;
            form1 = new Form1();
            form1.Show();
            this.Hide();

        }
    }
}