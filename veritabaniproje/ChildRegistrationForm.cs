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
    public partial class ChildRegistrationForm : Form
    {
        public ChildRegistrationForm()
        {
            InitializeComponent();
        }

        private void cocukEkleButton_Click(object sender, EventArgs e)
        {
            string parentTckn = ebeveynTcknTB.Text;
            string childName = cocukAdSoyadTb.Text;

            if (string.IsNullOrEmpty(parentTckn) || string.IsNullOrEmpty(childName))
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.", "Uyarı", MessageBoxButtons.OK);
                return;
            }

            if (parentTckn.Length != 11)
            {
                MessageBox.Show("TCKN 11 haneli olmalı. Kontrol edin.", "Uyarı", MessageBoxButtons.OK);
                return;
            }

            Api api = new Api();
            Cocuk cocuk = new Cocuk { AdSoyad = childName };
            bool isOk = api.AddChild(cocuk, parentTckn);

            if (isOk)
            {
                MessageBox.Show("Kayıt alındı.", "Başarılı", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Kayıt alınamadı.", "Başarısız", MessageBoxButtons.OK);
            }
        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
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
