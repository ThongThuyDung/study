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
    public partial class BanThucAnControl : UserControl
    {
        private static BanThucAnControl _instance;
        public static BanThucAnControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BanThucAnControl();
                return _instance;
            }
        }
        public BanThucAnControl()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
