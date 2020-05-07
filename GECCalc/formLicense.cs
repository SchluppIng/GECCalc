using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GECCalc
{
    public partial class formLicense : Form
    {
        public formLicense()
        {
            InitializeComponent();
        }

        private void formLicense_Load(object sender, EventArgs e)
        {
            this.Text = "G.E.C. Calc Version " + typeof(MainForm).Assembly.GetName().Version;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
