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
            this.button2 = new System.Windows.Forms.Button();
            this.btnDI = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 65);
            this.button2.TabIndex = 5;
            this.button2.Text = "LINQ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDI
            // 
            this.btnDI.Location = new System.Drawing.Point(98, 647);
            this.btnDI.Name = "btnDI";
            this.btnDI.Size = new System.Drawing.Size(177, 66);
            this.btnDI.TabIndex = 6;
            this.btnDI.Text = "button3";
            this.btnDI.UseVisualStyleBackColor = true;
            this.btnDI.Click += new System.EventHandler(this.btnDI_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(394, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(257, 65);
            this.button3.TabIndex = 7;
            this.button3.Text = "Directory Svcs";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1637, 773);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDI);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDI;
        private System.Windows.Forms.Button button3;
    }
}

