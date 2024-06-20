using _03_DataBaseFirstwDropDown.Models;

namespace _03_DataBaseFirstwDropDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NorthwindContext db = new NorthwindContext();
            List<Category> cats = db.Categories.ToList();

            foreach (var name in cats)
            {
                cbCategory.Items.Add(name.CategoryName);//display member display value konusuna bakarsak foreach alttaki gereksiz kalır.
            }
        }

        static void Add(string pdName, string ctName)
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                int catID = 0;
                Product newProduct = new Product();

                newProduct.ProductName = pdName;


                List<Category> cats = db.Categories.ToList();

                foreach (var cat in cats)
                {
                    if (cat.CategoryName == ctName)
                    {
                        catID = cat.CategoryId;
                    }

                }

                newProduct.CategoryId = catID;

                if (catID != 0 && newProduct is not null)
                {
                    db.Products.Add(newProduct);
                    db.SaveChanges();
                }

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add(txtbProductName.Text, cbCategory.SelectedItem.ToString());
        }
    }
}
