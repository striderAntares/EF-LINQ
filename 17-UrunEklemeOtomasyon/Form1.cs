using _17_UrunEklemeOtomasyon.Context;
using _17_UrunEklemeOtomasyon.Entities;
using Microsoft.VisualBasic.ApplicationServices;

namespace _17_UrunEklemeOtomasyon
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void btnEnter_Click(object sender, EventArgs e)
        {

            using (AppDbContext context = new AppDbContext())
            {
                AppUser usr = context.AppUser.FirstOrDefault(au => au.UserName.ToString() == txtbUserName.Text);

                if (usr is not null)
                {
                    if (usr.Password.ToString() == txtbPassword.Text && usr.UserName.ToString() == txtbUserName.Text)
                    {
                        Form2 form2 = new Form2();
                        form2.Owner = this;
                        form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı kullanıcı adı ve ya şifre");
                    }
                }
                else
                {
                    MessageBox.Show("Alanlar boş bırakılamaz");
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtbPassword.PasswordChar = '\0';
            }
            else
                txtbPassword.PasswordChar = '*';
        }
    }
}
