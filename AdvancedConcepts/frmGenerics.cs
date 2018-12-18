using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvancedConcepts.Generics;

namespace AdvancedConcepts
{
    public partial class frmGenerics : Form
    {
        public frmGenerics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            var a = 123;

            var b = 45.6666;

            CompareValue compareValue = new CompareValue();

            var maxValue = compareValue.Max(a, b);

            MessageBox.Show(maxValue.ToString());


        }
    }
}
