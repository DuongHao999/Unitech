using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thi_Dua.DAO;
using Thi_Dua.DTO;

namespace Thi_Dua.Controls
{
    public partial class UserControlQLCB : UserControl
    {
        public UserControlQLCB()
        {
            InitializeComponent();
            loadRole();
        }

        private void loadRole()
        {
            List<Role> listCategory = RoleDAO.Instance.GetListRole();
            dtgvRole.DataSource = listCategory;
            dtgvRole.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvRole.Columns["MaVT"].HeaderText = "Mã vai trò";
            dtgvRole.Columns["TenVT"].HeaderText = "Tên vai trò";
            dtgvRole.Columns["MoTaVT"].HeaderText = "Mô tả quyền";
            //dtgvRole.DisplayMember = "Name";
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRoleCreate_Click(object sender, EventArgs e)
        {
            string roleId = txtRoleId.Text;
            string rolename = txtRoleName.Text;
            string roleDecribe = txtRoleDcribe.Text;

            RoleDAO.Instance.InsertRole(roleId, rolename, roleDecribe);

            loadRole();
        }

        private void txtRoleId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgvRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dtgvRoleRow = dtgvRole.Rows[e.RowIndex];

            string roleID = dtgvRoleRow.Cells[0].Value.ToString();
            string roleName = dtgvRoleRow.Cells[1].Value.ToString();
            string roleDescribe = dtgvRoleRow.Cells[2].Value.ToString();

            txtRoleId.Text = roleID;
            txtRoleName.Text = roleName;
            txtRoleDcribe.Text = roleDescribe;
            //MessageBox.Show("test " + text);

            //RoleDAO.Instance.GetRoleByRoleID(roleID);
        }
    }
}
