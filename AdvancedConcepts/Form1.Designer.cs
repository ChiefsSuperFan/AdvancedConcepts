namespace AdvancedConcepts
{
    partial class Form1
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
            this.btnGenerics = new System.Windows.Forms.Button();
            this.btnListSort = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.btnOOP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerics
            // 
            this.btnGenerics.Location = new System.Drawing.Point(73, 60);
            this.btnGenerics.Name = "btnGenerics";
            this.btnGenerics.Size = new System.Drawing.Size(218, 71);
            this.btnGenerics.TabIndex = 0;
            this.btnGenerics.Text = "Generics";
            this.btnGenerics.UseVisualStyleBackColor = true;
            this.btnGenerics.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnListSort
            // 
            this.btnListSort.Location = new System.Drawing.Point(73, 189);
            this.btnListSort.Name = "btnListSort";
            this.btnListSort.Size = new System.Drawing.Size(198, 70);
            this.btnListSort.TabIndex = 1;
            this.btnListSort.Text = "Sortable List";
            this.btnListSort.UseVisualStyleBackColor = true;
            this.btnListSort.Click += new System.EventHandler(this.btnListSort_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "Reflection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(698, 357);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(706, 259);
            this.txtConsole.TabIndex = 3;
            // 
            // btnOOP
            // 
            this.btnOOP.Location = new System.Drawing.Point(82, 392);
            this.btnOOP.Name = "btnOOP";
            this.btnOOP.Size = new System.Drawing.Size(193, 68);
            this.btnOOP.TabIndex = 4;
            this.btnOOP.Text = "OOP";
            this.btnOOP.UseVisualStyleBackColor = true;
            this.btnOOP.Click += new System.EventHandler(this.btnOOP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1637, 773);
            this.Controls.Add(this.btnOOP);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnListSort);
            this.Controls.Add(this.btnGenerics);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerics;
        private System.Windows.Forms.Button btnListSort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button btnOOP;
    }
}

