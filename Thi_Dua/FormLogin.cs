using Microsoft.Data.SqlClient;
using System.Data;
using Thi_Dua.DAO;

namespace Thi_Dua
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            //Test();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPassWord.Text;
            if ( Login(userName, passWord) )
            {
                FormMain formMain = new FormMain();
                this.Hide();
                formMain.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
            //if ( txtUserName.Text == "text" && txtPass.Text =="123")
            //{
            //    FormMain formMain = new FormMain();
            //    this.Hide();
            //    formMain.ShowDialog();
            //    this.Show();
            //}
        }


        // Login function
        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

    }
}
