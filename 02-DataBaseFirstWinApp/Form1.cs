using _02_DataBaseFirstWinApp.Models;

namespace _02_DataBaseFirstWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddContent_Click(object sender, EventArgs e)
        {
            Add(txtbCategoryName.Text, txtbCategoryDescription.Text);
        }

        static void Add(string name, string desc) //metod yazmağa gerek yok. bunun için. bu spesifik örnek için. ama belki lazım olur.
        {
            using (NorthwindContext db = new NorthwindContext())
            {

                Category newCategory = new Category();

                newCategory.CategoryName = name;
                newCategory.Description = desc;



                db.Categories.Add(newCategory);
                db.SaveChanges();
            }

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            SelectAndList(lboxCategories);
            SelectAndListToListView(listView1);
        }

        static void SelectAndList(ListBox lb)
        {
            lb.Items.Clear();
            using (NorthwindContext db = new NorthwindContext())
            {
                List<Category> categ = db.Categories.ToList();

                foreach (var cat in categ)
                {
                    lb.Items.Add($"{cat.CategoryId} {cat.CategoryName} {cat.Description}");
                }

            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Remove(txtbCategoryName.Text);
        }

        static void Remove(string name)
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                Category removeCategory = db.Categories.First(x => x.CategoryName == name);
                if (removeCategory != null)
                {
                    db.Categories.Remove(removeCategory);

                    db.SaveChanges();
                }


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        static void SelectAndListToListView(ListView lv)
        {
            lv.Items.Clear();
            using (NorthwindContext db = new NorthwindContext())
            {
                List<Category> categ = db.Categories.ToList();
                int i = 0;
                foreach (var cat in categ)
                {
                    lv.Items.Add(cat.CategoryId.ToString());
                    lv.Items[i].SubItems.Add(cat.CategoryName);
                    lv.Items[i].SubItems.Add(cat.Description);//listviewa sırayla ekleyince columnlara da sırayla ekleme yapar.
                    i++;
                }

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update(txtbCategoryName.Text, txtbCategoryDescription.Text);
        }
        static void Update(string name, string desc)
        {
            using (var db = new NorthwindContext())
            {
                Category cat = db.Categories.FirstOrDefault(x => x.CategoryName == name);
                if (cat is not null) //eğer yukarıdaki sorgu boş dönerse null reference hatası almamak için bu koşulu ekledik.
                {
                    cat.Description = desc;


                    db.SaveChanges();
                }
                else
                    Console.WriteLine("Null olamaz");//bu ne mk

            }
        }
    }
}
