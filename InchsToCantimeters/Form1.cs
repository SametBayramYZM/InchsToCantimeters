using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InchsToCantimeters
{
    public partial class InchesToCantimeters : Form
    {
        public InchesToCantimeters()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double Inches = Convert.ToDouble(tbInches.Text);
            double Cantimeters = Convert.ToDouble(Inches * 2.54);
            lbCantimeters.Text = Convert.ToString(Cantimeters);
        }
    }
}
