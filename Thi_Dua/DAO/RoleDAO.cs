using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thi_Dua.DTO;

namespace Thi_Dua.DAO
{
    public class RoleDAO
    {
        private static RoleDAO instance;

        public static RoleDAO Instance
        {
            get { if (instance == null) instance = new RoleDAO(); return instance; }
            private set { instance = value; }
        }

        private RoleDAO() { }

        public List<Role> GetListRole()
        {
            List<Role> list = new List<Role>();

            string query = "select * from VAI_TRO";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Role role = new Role(item);
                list.Add(role);
            }

            return list;
        }

        public Role GetRoleByRoleID(string roleID)
        {

            //string query = "select * From VAI_TRO where VT_MA = '" + roleID + "'";
            string query = "select* From VAI_TRO where VT_MA = 'AD'";
            

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            //foreach (DataRow item in data.Rows)
            //{
            //    role = new Role(item);
            //    //list.Add(food);
            //}

            return null;
        }

        public bool InsertRole(string roleId, string roleName, string roleDescribe)
        {
            //string query = string.Format("INSERT INTO VAI_TRO ( VT_MA, VT_TEN, VT_MO_TA )VALUES  ( {0}, {1}, {2})", roleId, roleName, roleDescribe);

            string query = "INSERT INTO dbo.VAI_TRO ( VT_MA, VT_TEN, VT_MO_TA ) VALUES ( '" + roleId + "','" + roleName + "','"+ roleDescribe + "' )";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        //public bool UpdateRole(string roleId, string roleName, string roleDescribe)
        //{
        //    string query = string.Format("UPDATE dbo.Food SET name = N'{0}', idCategory = {1}, price = {2} WHERE id = {3}", name, id, price, idFood);
        //    int result = DataProvider.Instance.ExecuteNonQuery(query);

        //    return result > 0;
        //}

        //public bool DeleteRole(string roleId)
        //{
        //    BillInfoDAO.Instance.DeleteBillInfoByFoodID(idFood);

        //    string query = string.Format("Delete Food where id = {0}", idFood);
        //    int result = DataProvider.Instance.ExecuteNonQuery(query);

        //    return result > 0;
        //}
    }
}
