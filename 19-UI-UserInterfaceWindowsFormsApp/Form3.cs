using _19_DAL_DataAccessLayer;
using _19_DATA;
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
//formu hazırlarken karşılaştığım eblehlikler:
//arasında bağlantı bulunan iki tablonun verilerine arayüzde ulaşmak istersen lazy loading (.netcoreproxies) ve ya joinlemek (linq) ve ya include (linq) etmek arasında kalırsan. include etmek senin için kolaylık sağlıyor esneklik veriyor. ve null reference hatası alıyorsan bu üç yollardan birinde mantık hatası yapmışsın demektir reference tipinde bir veriye null olma imkanı vermişsin demektir yapma. bunu yapma hatta artık anticipate et biraz. mesela listeye atarken tablolarımızı içlerinden birinin boş gelip gelemeyeceği sorusunu sor. ona göre karar yapıları hazırla. arasında bağlantı bulunan iki tablonun birinden öbürünü çektiğinde içinde bulanan kayıtlı verilerden ikinci tablosu boş olan eleman her ne kadar tipi string olsa da boş olduğu için reference type kabul edilecektir bu yerde. ki zaten içinde dönmedikçe böyle olacaktır.
namespace _19_UI_UserInterfaceWindowsFormsApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            PopulateLabel();
            InitializeListView();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            PopulateLabel();
        }

        public void PopulateLabel()
        {
            label1.Text = "";
            using (AppDbContext context = new AppDbContext())
            {

                List<Personnel> personnelList = context.Personnels.Where(c => c.ContactInfoOfPersonnel != null).ToList();
                List<Personnel> personnelListEmpty = context.Personnels.Where(c => c.ContactInfoOfPersonnel == null).ToList();
                List<ContactInfo> contactList = context.ContactInfos.ToList();


                var totality = personnelList.Join(contactList, x => x.PersonnelID, r => r.PersonnelID, (x, r) => new
                {
                    PersonnelID = x.PersonnelID,
                    PersonnelName = x.PersonnelName,
                    PersonnelSurname = x.PersonnelSurname,
                    TCIDNo = x.TCIDNo,
                    Sex = x.Sex,
                    Birthdate = x.Birthdate,
                    Department = x.Department,
                    Email = r.Email,
                });//listleri joinleyince içinde boş olan varsa o kısmı joinlermiyor. iletişim bilgisi eksik olanlar kayıp.

                
                //bool RequiredCheckerJoin = false;
                //foreach (var item in totality)
                //{
                //    if (item.Email != "" && item.PersonnelName != "")
                //    {
                //        RequiredCheckerJoin = true;
                //    }
                //    else
                //        RequiredCheckerJoin = false;
                //}

                //if (RequiredCheckerJoin)
                //{
                foreach (var person in totality)
                {
                    label1.Text += $"{person.PersonnelID} {person.PersonnelName} {person.PersonnelSurname} {person.TCIDNo} {person.Sex} {person.Birthdate}{person.Department} {person.Email}\n";
                }

                foreach (Personnel person in personnelListEmpty)
                {
                    label1.Text += $"{person.PersonnelID} {person.PersonnelName} {person.PersonnelSurname} {person.TCIDNo} {person.Sex} {person.Birthdate}{person.Department}\n";
                }
                //}
                //else
                //    MessageBox.Show("Henüz iletişim bilgileri eklenmemiş personel mevcut.");

            }
        }

        private void btnLabelTemizlik_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void btnListViewTemizle_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            using (AppDbContext context = new AppDbContext())
            {

                int selectedIndex = combKosul.SelectedIndex;
                if (selectedIndex != -1)
                {
                    switch (selectedIndex)
                    {
                        case 0:
                            {
                                List<Personnel> personnelList = context.Personnels.Include(x => x.ContactInfoOfPersonnel).Where(x => x.PersonnelName.StartsWith(txtbKosulMetini.Text)).ToList();
                                PopulateListView(personnelList);
                                break;
                            }
                        case 1:
                            {
                                List<Personnel> personnelList1 = context.Personnels.Include(x => x.ContactInfoOfPersonnel).Where(x => x.PersonnelName.Contains(txtbKosulMetini.Text)).ToList();//include ederken class nava kadar ver.
                                PopulateListView(personnelList1);
                                break;
                            }
                        case 2:
                            {
                                List<Personnel> personnelList2 = context.Personnels.Include(x => x.ContactInfoOfPersonnel).Where(x => x.PersonnelName.EndsWith(txtbKosulMetini.Text)).ToList();
                                PopulateListView(personnelList2);
                                break;
                            }
                        default:
                            {
                                MessageBox.Show("Başaramadık..");
                                break;
                            }
                    }
                }
                else
                    MessageBox.Show("Koşul seçmelisin.");

            }
        }
        private void InitializeListView()
        {
            listView1.Enabled = true;

            listView1.View = View.Details;
            listView1.AllowColumnReorder = true;

            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("ID", 60);
            listView1.Columns.Add("İsim", 180);
            listView1.Columns.Add("Soyisim", 180);
            listView1.Columns.Add("TCKNO", 240);
            listView1.Columns.Add("Doğum günü", 240);
            listView1.Columns.Add("Cinsiyet", 180);
            listView1.Columns.Add("Departman", 180);
            listView1.Columns.Add("Email", 360);
            listView1.Columns.Add("Telefon no", 300);


        }

        private void PopulateListView(List<Personnel> people)
        {


            listView1.Items.Clear();

            int i = 0;
            foreach (Personnel person in people)
            {
                listView1.Items.Add(person.PersonnelID.ToString());
                listView1.Items[i].SubItems.Add(person.PersonnelName);
                listView1.Items[i].SubItems.Add(person.PersonnelSurname);
                listView1.Items[i].SubItems.Add(person.TCIDNo);
                listView1.Items[i].SubItems.Add(person.Birthdate.ToString());
                listView1.Items[i].SubItems.Add(person.Sex.ToString());
                listView1.Items[i].SubItems.Add(person.Department);
                if (person.ContactInfoOfPersonnel != null)
                {
                    listView1.Items[i].SubItems.Add(person.ContactInfoOfPersonnel.Email);
                    listView1.Items[i].SubItems.Add(person.ContactInfoOfPersonnel.MobileNumber);
                }
                else
                {
                    listView1.Items[i].SubItems.Add("");
                    listView1.Items[i].SubItems.Add("");
                }
                i++;
            }


        }
        private bool RequiredCheckerInclude(List<Personnel> people)
        {
            foreach (Personnel person in people)
            {

                if (person.ContactInfoOfPersonnel is not null && person.PersonnelName != "")
                    return false;


            }
            return true;

        }//iletişim bilgileri eklenmemiş var mı diye baksak mı bakmasak mı



        private void btnSil_Click(object sender, EventArgs e)
        {
            //int personnelIDIndex;
            //for (int i = 0; i < listView1.Items.Count; i++)
            //{
            //    if (listView1.Columns[i].Text == "PersonnelID")
            //    {
            //        personnelIDIndex = i;
            //    }
            //}TODO: magic number olmasın dedik de magic text oldu şimdi de. üşenmezsen foolproof yolunu araştır.
            if (listView1.SelectedItems.Count > 0)
            {
                int markOfDeath = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
                using (AppDbContext context = new AppDbContext())
                {
                    Personnel perso = context.Personnels.Find(markOfDeath);
                    context.Remove(perso);
                    context.SaveChanges();
                }
            }
        }
    }
}
