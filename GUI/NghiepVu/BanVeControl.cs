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
    public partial class BanVeControl : UserControl
    {
        private static BanVeControl _instance;
        public static BanVeControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BanVeControl();
                return _instance;
            }
        }
        public BanVeControl()
        {
            InitializeComponent();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
