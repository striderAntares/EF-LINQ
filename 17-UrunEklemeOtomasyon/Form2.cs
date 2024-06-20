using _17_UrunEklemeOtomasyon.Context;
using _17_UrunEklemeOtomasyon.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_UrunEklemeOtomasyon
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public Form2()
        {
            InitializeComponent();
            instance = this;
        }

        public void btnUrunEkle_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Owner = this;
            form3.Show();
            this.Hide();
        }

        public void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            using (AppDbContext context = new AppDbContext())
            {

                int success = context.Categories.Count();
                Category cat = new Category()
                {
                    Name = txtbKategoriAdı.Text,
                    Description = txtbAciklama.Text
                };//gelen degerleri burda trim edebilirsin
                if (cat != null)
                {
                    context.Categories.Add(cat);
                    context.SaveChanges();
                    success--;
                    if (success != context.Categories.Count())
                    {
                        MessageBox.Show("Ekleme başarılı");
                    }
                    else
                    {
                        MessageBox.Show("Bir takım başarısızlıklar söz konusu");
                    }
                    success = context.Categories.Count();
                }
                else
                {
                    MessageBox.Show("Kategori adını ve ya açıklamasını boş bırakamazsın.");
                }

            }
        }

        public void btnKategoriYenile_Click(object sender, EventArgs e)
        {
            listvKategoriler.Items.Clear();
            using (AppDbContext context = new AppDbContext())
            {
                var populateListView = context.Categories.Select(c => new { c.ID, c.Name, c.Description });
                int i = 0;
                foreach (var item in populateListView)
                {
                    listvKategoriler.Items.Add(item.ID.ToString());
                    listvKategoriler.Items[i].SubItems.Add(item.Name);
                    listvKategoriler.Items[i].SubItems.Add(item.Description);
                    i++;
                }//listviewitemla da yapabilirsin burayi
            }
        }
    }
}
