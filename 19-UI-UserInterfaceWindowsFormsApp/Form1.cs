using _19_DAL_DataAccessLayer;
using _19_DATA;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Diagnostics;

namespace _19_UI_UserInterfaceWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {


            foreach (Control ctrl in grobPersonelKayit.Controls)
            {
                if (ctrl is TextBox tb)
                {
                    tb.Text = "";
                }
                else if (ctrl is ComboBox cb)
                {
                    cb.SelectedIndex = -1;
                }
                else if (ctrl is DateTimePicker dtp)
                {
                    dtp.Value = DateTime.Now;
                }
                else if (ctrl is RadioButton rb)
                {
                    rb.Checked = false;
                }

            }
        }

        private void btnIletisim_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Owner = this;
            form2.Show();
            this.Hide();
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            if (rbErkek.Checked != rbKadin.Checked && txtbName.Text != "")
            {
                using (AppDbContext context = new AppDbContext())
                { 
                    bool sex = true;
                if (rbErkek.Checked)
                    sex = true;
                else if (rbKadin.Checked)
                    sex = false;
                Personnel personnel = new Personnel()
                {
                    PersonnelName = txtbName.Text,
                    PersonnelSurname = txtbSurname.Text,
                    TCIDNo = txtbTCNo.Text,
                    Birthdate = datetPDogum.Value,
                    Department = combBirimler.SelectedItem.ToString(),
                    Sex = sex,

                };
                    context.Personnels.Add(personnel);
                    context.SaveChanges();
                }

            }
            else
            {
                MessageBox.Show("Bir cinsiyet seçmelisin ve isim alanı boş olamaz.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (AppDbContext context = new AppDbContext())
            {
                //IQueryable<string> Departments = context.Personnels.Select(c => c.Department).Distinct(); //kurduğumuz databasede her departmandan çalışan en az bir kişi varsa bu olur.

                // foreach (string uniqueString in Departments)
                // {
                //     combBirimler.Items.Add(uniqueString);
                // } bunu bi ara deneriz tekrar.

                combBirimler.Items.Add("IT");
                combBirimler.Items.Add("HR");
                combBirimler.Items.Add("PR");
                combBirimler.Items.Add("Technical");
            }
        }
    }
}
