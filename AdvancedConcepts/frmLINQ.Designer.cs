namespace AdvancedConcepts
{
    partial class frmLINQ
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
            this.cboPlayerIDS = new System.Windows.Forms.ComboBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlayerCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTeamCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalSalaries = new System.Windows.Forms.TextBox();
            this.txtMaxSalary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboPlayerIDS
            // 
            this.cboPlayerIDS.FormattingEnabled = true;
            this.cboPlayerIDS.Location = new System.Drawing.Point(336, 458);
            this.cboPlayerIDS.Name = "cboPlayerIDS";
            this.cboPlayerIDS.Size = new System.Drawing.Size(291, 39);
            this.cboPlayerIDS.TabIndex = 0;
            this.cboPlayerIDS.SelectedIndexChanged += new System.EventHandler(this.cboPlayerIDS_SelectedIndexChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(336, 583);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(291, 38);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(336, 692);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(291, 38);
            this.txtLastName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Player ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 589);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 692);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name:";
            // 
            // txtPlayerCount
            // 
            this.txtPlayerCount.Location = new System.Drawing.Point(268, 96);
            this.txtPlayerCount.Name = "txtPlayerCount";
            this.txtPlayerCount.Size = new System.Drawing.Size(498, 38);
            this.txtPlayerCount.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Player Count:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Team Count:";
            // 
            // txtTeamCount
            // 
            this.txtTeamCount.Location = new System.Drawing.Point(278, 188);
            this.txtTeamCount.Name = "txtTeamCount";
            this.txtTeamCount.Size = new System.Drawing.Size(398, 38);
            this.txtTeamCount.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(976, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total Salaries:";
            // 
            // txtTotalSalaries
            // 
            this.txtTotalSalaries.Location = new System.Drawing.Point(1194, 96);
            this.txtTotalSalaries.Name = "txtTotalSalaries";
            this.txtTotalSalaries.Size = new System.Drawing.Size(361, 38);
            this.txtTotalSalaries.TabIndex = 11;
            // 
            // txtMaxSalary
            // 
            this.txtMaxSalary.Location = new System.Drawing.Point(1209, 188);
            this.txtMaxSalary.Name = "txtMaxSalary";
            this.txtMaxSalary.Size = new System.Drawing.Size(346, 38);
            this.txtMaxSalary.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(982, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Max Salary";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmLINQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1823, 902);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaxSalary);
            this.Controls.Add(this.txtTotalSalaries);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTeamCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPlayerCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.cboPlayerIDS);
            this.Name = "frmLINQ";
            this.Text = "frmLINQ";
            this.Load += new System.EventHandler(this.frmLINQ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPlayerIDS;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlayerCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTeamCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalSalaries;
        private System.Windows.Forms.TextBox txtMaxSalary;
        private System.Windows.Forms.Label label7;
    }
}