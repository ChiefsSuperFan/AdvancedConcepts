﻿namespace AdvancedConcepts
{
    partial class frmSortableList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvSort = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvSort
            // 
            this.lvSort.Location = new System.Drawing.Point(37, 32);
            this.lvSort.Name = "lvSort";
            this.lvSort.Size = new System.Drawing.Size(1164, 843);
            this.lvSort.TabIndex = 0;
            this.lvSort.UseCompatibleStateImageBehavior = false;
            this.lvSort.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvSort_ColumnClick);
            // 
            // frmSortableList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 1116);
            this.Controls.Add(this.lvSort);
            this.Name = "frmSortableList";
            this.Text = "frmSortableList";
            this.Load += new System.EventHandler(this.frmSortableList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvSort;
    }
}