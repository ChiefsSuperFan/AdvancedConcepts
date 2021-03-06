﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvancedConcepts.UI;
using AdvancedConcepts.DI;
using AdvancedConcepts.BusinessLayer;

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
            generics.Show();

            //now set the pointer
            generics.SendMessage += OnGenericSend;

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


        //example of receiving messagaes from the generics form
        private void OnGenericSend(object sender, ExampleEventArgs e)
        {
            txtConsole.Clear();
            string message = "Sent Date: " + e.SendDate.ToLongDateString() + Environment.NewLine;
            message += e.SendMessage;
            txtConsole.Text = message;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOOP_Click(object sender, EventArgs e)
        {
            frmOOP oopForm = new frmOOP();
            oopForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLINQ linq = new frmLINQ();
            linq.Show();
        }

        private void btnDI_Click(object sender, EventArgs e)
        {
            frmSubclassControls subclassControls = new frmSubclassControls();
            subclassControls.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAD ad = new frmAD();
            ad.Show();
        }
    }
}
