using _17_UrunEklemeOtomasyon.Context;
using _17_UrunEklemeOtomasyon.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _17_UrunEklemeOtomasyon
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void btnKategoriDonus_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();


        }

        public void Form3_Load(object sender, EventArgs e)
        {
            using (AppDbContext context = new AppDbContext())
            {
                List<Category> cat = context.Categories.ToList();

                foreach (Category kitten in cat)
                {
                    combKategori.Items.Add(kitten.Name);
                }


            }
        }

        public void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            listvUrunler.Items.Clear();
            using (AppDbContext context = new AppDbContext())
            {
                List<Product> populateListView = context.Products.Include(c => c.Category).ToList();
                /*var populateListView = context.Products.Include(c => c.Category).ToList();*/ //listeye atmadan da oluyor. ayırt edici değişken include ve ya join edilmesi kategorinin. aralarında bağ bulunan iki tablodan eşlenikli veri çekmek için include ya da join et, ikisini de yapmıyorsan lazyloading kullan.
                //var populateListView = context.Products.ToList();
                int i = 0;
                foreach (var product in populateListView)
                {
                    listvUrunler.Items.Add(product.ID.ToString());
                    listvUrunler.Items[i].SubItems.Add(product.Name);
                    listvUrunler.Items[i].SubItems.Add(product.UnitPrice.ToString());
                    listvUrunler.Items[i].SubItems.Add(product.Stock.ToString());
                    listvUrunler.Items[i].SubItems.Add(product.Category.Name.ToString());
                    listvUrunler.Items[i].SubItems.Add(product.IsActive.ToString());
                    listvUrunler.Items[i].SubItems.Add(product.AddedDate.ToString());
                    i++;
                }//kategori adina ulasmak icin contextten direk joinlersen anonim tipler ayni isimde ozelliklere sahip olamaz diye hata veriyor. (ayni classtan inherit aldigindan iki classin da ayni isimde propertyleri mevcut) eger once kendi tiplerindeki listelere atip (tolist metodu ile) sonra joinleyip joinlerken de yeni aliaslar atarsan bu hatayi vermiyor. entity framework proxies e ait olan lazy loading metoduna alternatiftir. ve ya direk product cinsinden listeye contextten productlari yakalayip atip include edebilirsin bu da alternatiftir.

            }
        }

        public void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            using (AppDbContext context = new AppDbContext())
            {
                string cato = "";
                if (combKategori.SelectedIndex != -1)
                {
                    cato = combKategori.SelectedItem.ToString();

                }
                Category cat = context.Categories.FirstOrDefault(x => x.Name == cato);
                Product pro = new Product()
                {
                    Name = txtbProduct.Text,
                    Stock = Convert.ToSByte(numericStock.Value),
                    UnitPrice = numericUnitPrice.Value,
                    CategoryId = cat.ID

                };
                if (cat != null)
                {
                    context.Products.Add(pro);
                    context.SaveChanges();
                }

            }
        }

        public void btnSil_Click(object sender, EventArgs e)
        {
            if (listvUrunler.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listvUrunler.SelectedItems[0];


                string subitem0Value = selectedItem.SubItems[0].Text;

                int.TryParse(subitem0Value, out int markOfDeath);

                using (AppDbContext context = new AppDbContext())
                {
                    Product pro = context.Products.Find(markOfDeath);
                    context.Products.Remove(pro);
                    context.SaveChanges();
                }

            }
            else
                MessageBox.Show("Silmek için bir öğe seçmelisin.");
        }
    }
}
