using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace GECCalc
{
    public partial class formAbout : Form
    {
        public formAbout()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formAbout_Load(object sender, EventArgs e)
        {
            this.Text = "G.E.C. Calc Version " + typeof(MainForm).Assembly.GetName().Version;
            lblAboutHeader.Text = "G.E.C. Calc Version " + typeof(MainForm).Assembly.GetName().Version;
            lblLicense.Text = "G.E.C.Calc Version\n" + typeof(MainForm).Assembly.GetName().Version + "\nThis software is under the GNU General Public License v3.0";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:", "GECCalc@gmx.de");
        }

        private void linklblLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formLicense frmLi = new formLicense();
            frmLi.txtLicense.Text = Resources.ResourceLicense.License;
            frmLi.Show();
          
        }

    }
}
