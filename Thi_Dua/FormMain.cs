using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thi_Dua
{
    public partial class FormMain : Form
    {
        Controls.UserControlQLCB userControl1 = new Controls.UserControlQLCB();
        Controls.UserControlQLTK userControl2 = new Controls.UserControlQLTK();
        Controls.UserControlQLTD userControl3 = new Controls.UserControlQLTD();
        public FormMain()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControl1);
            userControl1.Dock = DockStyle.Fill;
        }

        private void btnQLNS_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControl1);
            userControl1.Dock = DockStyle.Fill;
        }

        private void btnQLTD_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControl2);
            userControl2.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControl3);
            userControl3.Dock = DockStyle.Fill;
        }
    }
}
