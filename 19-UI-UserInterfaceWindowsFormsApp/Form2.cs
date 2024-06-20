using _19_DAL_DataAccessLayer;
using _19_DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_UI_UserInterfaceWindowsFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnYeniPersonel_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        private void btnTumKayitlar_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Owner = this;

            form3.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (AppDbContext context = new AppDbContext())
            {
                List<Personnel> personnelList = context.Personnels.ToList();
                personnelList = AdjustDataDisplay(personnelList);
                if (personnelList is not null)
                {
                    combPersonel.DataSource = personnelList;
                    combPersonel.DisplayMember = "PersonnelName";
                    combPersonel.ValueMember = "PersonnelID";
                }




                //foreach (Personnel person in personnelList)
                //{

                //    combPersonel.Items .Add($"{person.PersonnelID} {person.PersonnelName} {person.PersonnelSurname}");
                //} bu da olur ama daha sonra id yakalamak istersek ki isteyeceğiz sıkıntılı olur.
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            using (AppDbContext context = new AppDbContext())
            {
                if (combPersonel.SelectedIndex != -1 && txtbEmail.Text != "")
                {
                    Personnel personnel = (Personnel)combPersonel.SelectedItem;
                    
                    ContactInfo contact = new ContactInfo()
                    {
                        Email = txtbEmail.Text,
                        Adress = txtbAdres.Text,
                        MobileNumber = txtbTelefon.Text,
                        PersonnelID = personnel.PersonnelID
                    };
                    
                        context.ContactInfos.Update(contact);
                        context.SaveChanges();
                    
                    
                    MessageBox.Show("Ekleme başarılı");
                }
                else
                    MessageBox.Show("Bir personel seçmelisin ve email alanı boş olamaz.");
            }



        }

        private void btnIletisimEkleme_Click(object sender, EventArgs e)
        {
            using (AppDbContext context = new AppDbContext())
            {
                List<Personnel> personnelList = context.Personnels.ToList();
                personnelList = AdjustDataDisplay(personnelList);
                if (personnelList is not null)
                {
                    combPersonel.DataSource = personnelList;
                    combPersonel.DisplayMember = "PersonnelName";
                    combPersonel.ValueMember = "PersonnelID";
                }

            }
        }
        private List<Personnel> AdjustDataDisplay(List<Personnel> persons)
        {
            foreach (Personnel personnel in persons)
            {

                personnel.PersonnelName = personnel.PersonnelName + " " + personnel.PersonnelSurname;





            }
            return persons;//bu metodu comboboxu popüle ederken birden fazla property gösterebilsin diye yaptım.
        }
    }
}
