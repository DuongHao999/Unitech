using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thi_Dua.DTO
{
    public class Role
    {
        private string maVT;
        private string tenVT;
        private string moTaVT;

        public string MaVT   // property
        {
            get { return maVT; }   // get method
            set { maVT = value; }  // set method
        }

        public string TenVT   // property
        {
            get { return tenVT; }   // get method
            set { tenVT = value; }  // set method
        }

        public string MoTaVT   // property
        {
            get { return moTaVT; }   // get method
            set { moTaVT = value; }  // set method
        }

        public Role(string vT_Ma, string vT_Ten, string vT_MoTa)
        {
            maVT = vT_Ma;
            tenVT = vT_Ten;
            moTaVT = vT_MoTa;
        }

        public Role(DataRow row)
        {
            this.maVT = row["VT_Ma"].ToString();
            this.tenVT = row["VT_Ten"].ToString();
            this.moTaVT = row["VT_Mo_Ta"].ToString();
            //this.CategoryID = (int)row["idcategory"];
            //this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }
        
    }
}
