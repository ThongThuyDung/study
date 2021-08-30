using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_ver5.DAL
{
    class DAL_Phim
    {
        public DataTable GetAllPhim()
        {
            DataTable dt = new DataTable();
            string query = "select * from Phim";
            dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
    }
}
