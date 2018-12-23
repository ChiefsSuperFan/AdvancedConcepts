namespace AdvancedConcepts
{
    partial class frmGenerics
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
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 958);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(91, 89);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(292, 69);
            this.btnCompare.TabIndex = 1;
            this.btnCompare.Text = "Compare Values";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(91, 733);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(230, 55);
            this.btnSendMessage.TabIndex = 2;
            this.btnSendMessage.Text = "Send Message";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(82, 606);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(458, 108);
            this.txtMessage.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(91, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(292, 69);
            this.button2.TabIndex = 4;
            this.button2.Text = "Create Instance";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(91, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(292, 77);
            this.button3.TabIndex = 5;
            this.button3.Text = "Interfaces";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmGenerics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1674, 1101);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGenerics";
            this.Text = "frmGenerics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}