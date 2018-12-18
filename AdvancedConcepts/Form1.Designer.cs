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
            this.SuspendLayout();
            // 
            // btnGenerics
            // 
            this.btnGenerics.Location = new System.Drawing.Point(86, 78);
            this.btnGenerics.Name = "btnGenerics";
            this.btnGenerics.Size = new System.Drawing.Size(218, 71);
            this.btnGenerics.TabIndex = 0;
            this.btnGenerics.Text = "Generics";
            this.btnGenerics.UseVisualStyleBackColor = true;
            this.btnGenerics.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnListSort
            // 
            this.btnListSort.Location = new System.Drawing.Point(106, 239);
            this.btnListSort.Name = "btnListSort";
            this.btnListSort.Size = new System.Drawing.Size(198, 70);
            this.btnListSort.TabIndex = 1;
            this.btnListSort.Text = "Sortable List";
            this.btnListSort.UseVisualStyleBackColor = true;
            this.btnListSort.Click += new System.EventHandler(this.btnListSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1637, 773);
            this.Controls.Add(this.btnListSort);
            this.Controls.Add(this.btnGenerics);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerics;
        private System.Windows.Forms.Button btnListSort;
    }
}

