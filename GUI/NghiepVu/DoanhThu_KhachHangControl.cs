using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_ver5.GUI.NghiepVu
{
    public partial class DoanhThu_KhachHangControl : UserControl
    {
        private static DoanhThu_KhachHangControl _instance;
        public static DoanhThu_KhachHangControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DoanhThu_KhachHangControl();
                return _instance;
            }
        }
        public DoanhThu_KhachHangControl()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
