using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using AdvancedConcepts.Classes;

namespace AdvancedConcepts
{
    public partial class frmReflection : Form
    {
        public frmReflection()
        {
            InitializeComponent();
        }

        private void frmReflection_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Type type = typeof(Customer);

            string output = "";

            PropertyInfo[] propertyInfo = type.GetProperties();

            foreach(PropertyInfo info in propertyInfo)
            {
                var pName = info.Name;
                var memberType = info.MemberType.ToString();
                output += pName + ", " + memberType + Environment.NewLine;
            }
            txtConsole.Text = output;
        }
    }
}
