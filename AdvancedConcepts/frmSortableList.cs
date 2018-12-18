using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvancedConcepts.UI;

namespace AdvancedConcepts
{
    public partial class frmSortableList : Form
    {
        public frmSortableList()
        {
            InitializeComponent();
        }

        private void frmSortableList_Load(object sender, EventArgs e)
        {
            //setup listview
            lvSort.Columns.Add("Name", 250);
            lvSort.Columns.Add("Job Title", 250);
            lvSort.Columns.Add("Age", 100);
            lvSort.Width = 600;

            //these two properties must be set
            lvSort.View = View.Details;
            lvSort.HeaderStyle = ColumnHeaderStyle.Clickable;

            AddRows();

            

        }

        private void AddRows()
        {
            ListViewItem item = new ListViewItem("Tony Stone");
            item.SubItems.Add("Chief Information Officer");
            item.SubItems.Add("40");
            lvSort.Items.Add(item);

            ListViewItem item1 = new ListViewItem("Jacquie Stone");
            item1.SubItems.Add("Chief Executive Officer");
            item1.SubItems.Add("40");
            lvSort.Items.Add(item1);

            ListViewItem item2 = new ListViewItem("Sweetie Stone");
            item2.SubItems.Add("Family Dog");
            item2.SubItems.Add("6");
            lvSort.Items.Add(item2);

            ListViewItem item3 = new ListViewItem("Ben Stone");
            item3.SubItems.Add("HS Senior");
            item3.SubItems.Add("18");
            lvSort.Items.Add(item3);

            ListViewItem item4 = new ListViewItem("Brett Stone");
            item4.SubItems.Add("HS Sophomore");
            item4.SubItems.Add("40");
            lvSort.Items.Add(item4);

            ListViewItem item5 = new ListViewItem("Chubby Stone");
            item5.SubItems.Add("Senior Family Dog");
            item5.SubItems.Add("12");
            lvSort.Items.Add(item5);

        }

        private void lvSort_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            try
            {
                ItemComparer sorter = lvSort.ListViewItemSorter as ItemComparer;

                if (sorter == null)
                {
                    sorter = new ItemComparer(e.Column)
                    {
                        Order = SortOrder.Ascending
                    };
                
                    lvSort.ListViewItemSorter = sorter;
                }
                // if clicked column is already the column that is being sorted
                if (e.Column == sorter.Column)
                {
                    // Reverse the current sort direction
                    if (sorter.Order == SortOrder.Ascending)
                        sorter.Order = SortOrder.Descending;
                    else
                        sorter.Order = SortOrder.Ascending;
                }
                else
                {
                    // Set the column number that is to be sorted; default to ascending.
                    sorter.Column = e.Column;
                    sorter.Order = SortOrder.Ascending;
                }
                lvSort.Sort();

            }
            catch
            {

            }
        }
    }
}
