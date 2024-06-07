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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            string adSoyad = adSoyadTBreg.Text;
            string tckn = TckTBreg.Text;
            string password = passwordTBReg.Text;
            string selectedCity = sehirCBreg.SelectedItem?.ToString();


            if (string.IsNullOrEmpty(adSoyad) || string.IsNullOrEmpty(tckn) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(selectedCity))
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
            int sehirId = api.GetSehirId(selectedCity);
            User user = new User { AdSoyad = adSoyad, Tckn = tckn, Password = password, SehirId = sehirId };
            bool isOk = api.RegisterUser(user);
            var list = api.GetSehirler();

            foreach (var item in list)
            {
                sehirCBreg.Items.Add(item.Name);
            }

            

            if (isOk)
            {
                MessageBox.Show("Kaydınız başarıyla alınmıştır.", "Başarılı", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Kaydınız alınamadı.", "Başarısız", MessageBoxButtons.OK);
            }
        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            Api api = new Api();
            var sehirler = api.GetSehirler();

            foreach (var sehir in sehirler)
            {
                sehirCBreg.Items.Add(sehir.Name);
            }
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
