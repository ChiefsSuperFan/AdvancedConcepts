using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvancedConcepts.Classes;

namespace AdvancedConcepts
{
    public partial class frmSubclassControls : Form
    {

        private InputTextBox2 inputTextBox2 = new InputTextBox2();
        public frmSubclassControls()
        {
            InitializeComponent();
        }

        private void frmSubclassControls_Load(object sender, EventArgs e)
        {        

          
            try
            {

                inputTextBox2.Font= new Font("Segoe UI", 16);
                inputTextBox2.Size= new System.Drawing.Size(400, 47);
                inputTextBox2.Location= new System.Drawing.Point(50, 50);

                inputTextBox2.Visible = true;
                

            }
            catch
            {

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
