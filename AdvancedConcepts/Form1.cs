using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedConcepts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGenerics generics = new frmGenerics();
            generics.ShowDialog();
        }

        private void btnListSort_Click(object sender, EventArgs e)
        {
            frmSortableList sortableList = new frmSortableList();
            sortableList.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmReflection reflection = new frmReflection();
            reflection.Show();
        }
    }
}
