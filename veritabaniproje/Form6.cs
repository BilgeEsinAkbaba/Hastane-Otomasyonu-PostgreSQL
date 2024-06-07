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
    public partial class Form6 : Form
    {
        Api api;
        public Form6()
        {
            InitializeComponent();
            api = new Api();
            SetUpListView();  // Randevu ListView için
            SetUpListView1(); // Talep ListView için

            UpdateListView(); // Randevu ListView'i güncelle
            UpdateListView1(); // Talep ListView'i güncelle
        }

        public void UpdateListView()
        {
            var list = api.GetAllUsersRandevu();


            RandevuLV.Items.Clear();
            foreach (var item in list)
            {
                string doktorAd = api.GetDoktorFromId(item.DoktorId).Name;
                string skName = api.GetSaglikKurumuFromId(item.SaglikKurumuId).Name;
                if (item.CocukId == 0)
                {
                    string[] rowAr = { item.Id.ToString(), Constants.user.AdSoyad, item.Tarih, item.Saat, doktorAd, skName };
                    var row = new ListViewItem(rowAr);
                    RandevuLV.Items.Add(row);

                }
                else
                {

                    var cocuk = api.GetCocukFromId(item.CocukId);
                    string[] rowAr = { item.Id.ToString(), cocuk.AdSoyad, item.Tarih, item.Saat, doktorAd, skName };
                    var row = new ListViewItem(rowAr);
                    RandevuLV.Items.Add(row);

                }
            }


        }

        public void SetUpListView()
        {
            RandevuLV.View = View.Details;
            RandevuLV.GridLines = true;
            RandevuLV.FullRowSelect = true;
            RandevuLV.Columns.Add("Id", 30);
            RandevuLV.Columns.Add("Ad Soyad", 70);
            RandevuLV.Columns.Add("Tarih", 100);
            RandevuLV.Columns.Add("Saat", 50);
            RandevuLV.Columns.Add("Doktor", 70);
            RandevuLV.Columns.Add("Sağlık Kurumu", 120);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                var rId = Convert.ToInt32(RandevuLV.SelectedItems[0].Text);
                var b = api.RandevuSil(rId);
                if (b)
                {
                    MessageBox.Show("Randevu başarı ile silindi", "Randevu Sil", MessageBoxButtons.OK);
                    UpdateListView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);

            }
        }
        public void UpdateListView1()
        {
            var list = api.GetTalepler();


            listView1.Items.Clear();

            foreach (var item in list)
            {

                string[] rowAr = { item.Id.ToString(), item.Text };
                var row = new ListViewItem(rowAr);
                listView1.Items.Add(row);

            }


        }

        public void SetUpListView1()
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Id", 30);
            listView1.Columns.Add("Text", 150);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RandevuLV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cikisBT_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void girisSayfasiBt_Click(object sender, EventArgs e)
        {
            LoginForm loginform;
            loginform = new LoginForm();
            loginform.Show();
            this.Hide();
        }
    }
}
