using _20_DbFirstRepositoryDesignNorthwind.Models;
using _20_DbFirstRepositoryDesignNorthwind.Repositories;
namespace _20_DbFirstRepositoryDesignNorthwind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            CategoryRepository categoryRepository = new CategoryRepository();
            List<Category> cats = categoryRepository.GetAll();
            int i = 0;
            foreach (Category c in cats)
            {
                listView1.Items.Add(c.CategoryId.ToString());
                listView1.Items[i].SubItems.Add(c.CategoryName);
                listView1.Items[i].SubItems.Add(c.Description);
                i++;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            CategoryRepository cr = new CategoryRepository();
            Category cat = new Category()
            {
                CategoryName = txtbKatAdi.Text,
                Description = txtbKatAciklama.Text
            };
            cr.Update(cat);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            CategoryRepository categoryRepository = new CategoryRepository();
            List<Category> cats = categoryRepository.GetAll();
            int i = 0;
            foreach (Category c in cats)
            {
                listView1.Items.Add(c.CategoryId.ToString());
                listView1.Items[i].SubItems.Add(c.CategoryName);
                listView1.Items[i].SubItems.Add(c.Description);
                i++;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CategoryRepository cr = new CategoryRepository();
            int markOfDeath = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
            cr.DeleteByID(markOfDeath);

        }
    }
}
