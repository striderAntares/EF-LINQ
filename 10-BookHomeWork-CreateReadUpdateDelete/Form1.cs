using _10_StudentsHomeWork_CreateReadUpdateDelete.Context;
using _10_StudentsHomeWork_CreateReadUpdateDelete.Entities;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;

namespace _10_StudentsHomeWork_CreateReadUpdateDelete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtbFirstName.Text is not null || txtbLastName.Text is not null || txtbEmail.Text is not null || txtbPhoneNumber.Text is not null || txtbTCKNO.Text is not null || combSex.SelectedIndex != -1 || combField.SelectedIndex != -1 || CheckEmail(txtbEmail.Text) || ValidateTCNumber(txtbTCKNO.Text))
            {
                using (var context = new HS_15SDbContext())
                {
                    Field fld = context.Fields.FirstOrDefault(f => f.FieldName == combField.SelectedItem.ToString());//yeni field nesnesi oluşturup comboboxtan gelen değeri atayıp field idyi öyle de çekebilirdin. tüm fieldı field listesine kaydedip öyle de çekebilirdin. ilk ifadeyi yoksay videoyu tekrar izleyene kadar.
                    Student stu = new Student()
                    {
                        FirstName = txtbFirstName.Text,
                        LastName = txtbLastName.Text,
                        Email = txtbEmail.Text,
                        PhoneNumber = txtbPhoneNumber.Text,
                        TCKNO = txtbTCKNO.Text,
                        Sex = combSex.SelectedItem.ToString(),
                        FieldID = fld.FieldID,
                        Birthdate = dateTimePicker1.Value
                    };

                    if (stu is not null)
                    {
                        context.Students.Add(stu);
                        context.SaveChanges();
                    }

                }
            }
            else
                MessageBox.Show("Please fill the entire form."); //TODO:SPESİFİK
        }

        private bool CheckEmail(string toCheck) //TODO: EXTENSİON METHOD
        {
            string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(toCheck, emailPattern);
        }

        public static bool ValidateTCNumber(string TCKNO)

        {
            if (TCKNO.Length != 11 || TCKNO[0] == '0')
            {
                return false;
            }
            int[] tcNumberArray = new int[TCKNO.Length];
            for (int i = 0; i < TCKNO.Length; i++)
            {
                tcNumberArray[i] = int.Parse(TCKNO[i].ToString());
            }
            int ilkOnSayiToplam = 0;
            for (int j = 0; j < (TCKNO.Length - 1); j++)
            {
                ilkOnSayiToplam += tcNumberArray[j];
            }
            if (tcNumberArray[10] != (ilkOnSayiToplam % 10))
            {
                return false;
            }
            return true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new HS_15SDbContext())
            {
                List<Field> fieldList = context.Fields.ToList();
                foreach (var field in fieldList)
                {
                    combField.Items.Add(field.FieldName);
                }//TODO:display member display value
            }

            combSex.Items.Add("Male");
            combSex.Items.Add("Female"); //TODO:belki enum classı yapmak istersin.
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            using (var context = new HS_15SDbContext())
            {
                var populateListView = context.Students.Select(x => new { x.StudentID, x.FirstName, x.LastName, x.Email, x.PhoneNumber, x.TCKNO, x.Sex, x.Field.FieldName, x.Birthdate });//DTO -DATA TRANSFER OBJECT, VM- VIEW MODEL 
                int i = 0;
                foreach (var popul in populateListView)
                {
                    listView1.Items.Add(popul.StudentID.ToString()); //subitem0 diye bir şey yok atama yapılmıyor.
                    listView1.Items[i].SubItems.Add(popul.FirstName.ToString());
                    listView1.Items[i].SubItems.Add(popul.LastName.ToString());
                    listView1.Items[i].SubItems.Add(popul.Email.ToString());
                    listView1.Items[i].SubItems.Add(popul.PhoneNumber.ToString());
                    listView1.Items[i].SubItems.Add(popul.TCKNO.ToString());
                    listView1.Items[i].SubItems.Add(popul.Sex.ToString());
                    listView1.Items[i].SubItems.Add(popul.FieldName.ToString());
                    listView1.Items[i].SubItems.Add(popul.Birthdate.ToString());
                    i++; //şunun basit yolunu bul. sor

                    //foreach (var populi in popul)
                    //{
                    //    listView1.Items.Add(popul.populi.ToString());
                    //}
                    //böyle bi şey yok. TİPİ OLUNCA OLACAK.
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];


                string subitem0Value = selectedItem.SubItems[0].Text;

                int.TryParse(subitem0Value, out int markOfForDeath);

                using (var context = new HS_15SDbContext())
                {
                    Student stu = context.Students.Find(markOfForDeath);
                    context.Students.Remove(stu);
                    context.SaveChanges();
                }

            }
            else
                MessageBox.Show("You should select an item from the list in order to delete");

        }

        private void txtbFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                byte keyValue = Convert.ToByte(e.KeyChar);

                if (keyValue >= 65 && keyValue <= 90 || keyValue >= 97 && keyValue <= 122 || keyValue == 8)
                {
                    e.Handled = false;
                }
                else
                    e.Handled = true;
            }
        }

        private void combSex_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtbTCKNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            byte keyValue = Convert.ToByte(e.KeyChar);
            if (keyValue >= 48 && keyValue <= 57 || keyValue == 8 || keyValue == 46)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
    }
}
