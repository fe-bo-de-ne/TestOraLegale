using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestOraLegale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TimeZoneInfo.Local.IsDaylightSavingTime(DateTime.Now))
            {
                bllTest.Text = "Ora legale";
            }
            else
            {
                bllTest.Text = "Ora solare";
            }
        }
    }
}
