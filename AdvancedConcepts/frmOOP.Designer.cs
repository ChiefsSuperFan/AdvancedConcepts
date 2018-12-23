namespace AdvancedConcepts
{
    partial class frmOOP
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnExtensionMethods = new System.Windows.Forms.Button();
            this.btnNullable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "Interfaces";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExtensionMethods
            // 
            this.btnExtensionMethods.Location = new System.Drawing.Point(116, 73);
            this.btnExtensionMethods.Name = "btnExtensionMethods";
            this.btnExtensionMethods.Size = new System.Drawing.Size(338, 78);
            this.btnExtensionMethods.TabIndex = 1;
            this.btnExtensionMethods.Text = "Extension Methods";
            this.btnExtensionMethods.UseVisualStyleBackColor = true;
            this.btnExtensionMethods.Click += new System.EventHandler(this.btnExtensionMethods_Click);
            // 
            // btnNullable
            // 
            this.btnNullable.Location = new System.Drawing.Point(116, 328);
            this.btnNullable.Name = "btnNullable";
            this.btnNullable.Size = new System.Drawing.Size(338, 80);
            this.btnNullable.TabIndex = 2;
            this.btnNullable.Text = "Nullable Types";
            this.btnNullable.UseVisualStyleBackColor = true;
            this.btnNullable.Click += new System.EventHandler(this.btnNullable_Click);
            // 
            // frmOOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 722);
            this.Controls.Add(this.btnNullable);
            this.Controls.Add(this.btnExtensionMethods);
            this.Controls.Add(this.button1);
            this.Name = "frmOOP";
            this.Text = "frmOOP";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExtensionMethods;
        private System.Windows.Forms.Button btnNullable;
    }
}