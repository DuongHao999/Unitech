using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thi_Dua.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            //string query = "SELECT * FROM dbo.Account WHERE UserName = N'" + userName + "' AND PassWord = N'" + passWord + "' ";
            //string query = "select * from TAI_KHOAN where TK_TEN_DANG_NHAP = ' qadmin' and TK_MAT_KHAU = '123' and TK_TRANG_THAI = '1'";

            //DataTable result = DataProvider.Instance.ExecuteQuery(query);

            string query = "USP_Login @userName , @passWord"; // khoảng trắng sau @userName quan trọng

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });

            return result.Rows.Count > 0;
        }
    }
}
