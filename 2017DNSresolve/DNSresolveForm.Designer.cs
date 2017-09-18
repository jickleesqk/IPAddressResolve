namespace _2017DNSresolve
{
    partial class DNSresolveForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputbox = new System.Windows.Forms.TextBox();
            this.hostbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ipbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Aliasbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input";
            // 
            // inputbox
            // 
            this.inputbox.Location = new System.Drawing.Point(108, 13);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(256, 20);
            this.inputbox.TabIndex = 1;
            this.inputbox.TextChanged += new System.EventHandler(this.inputbox_TextChanged);
            // 
            // hostbox
            // 
            this.hostbox.Location = new System.Drawing.Point(13, 65);
            this.hostbox.Name = "hostbox";
            this.hostbox.ReadOnly = true;
            this.hostbox.Size = new System.Drawing.Size(228, 20);
            this.hostbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Host Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "IP Address";
            // 
            // ipbox
            // 
            this.ipbox.Location = new System.Drawing.Point(13, 133);
            this.ipbox.Multiline = true;
            this.ipbox.Name = "ipbox";
            this.ipbox.ReadOnly = true;
            this.ipbox.Size = new System.Drawing.Size(228, 120);
            this.ipbox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Resolve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Aliasbox
            // 
            this.Aliasbox.Location = new System.Drawing.Point(293, 65);
            this.Aliasbox.Multiline = true;
            this.Aliasbox.Name = "Aliasbox";
            this.Aliasbox.ReadOnly = true;
            this.Aliasbox.Size = new System.Drawing.Size(164, 188);
            this.Aliasbox.TabIndex = 10;
            // 
            // DNSresolveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 274);
            this.Controls.Add(this.Aliasbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ipbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hostbox);
            this.Controls.Add(this.inputbox);
            this.Controls.Add(this.label1);
            this.Name = "DNSresolveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DNSresolveForm";
            this.Load += new System.EventHandler(this.DNSresolveForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputbox;
        private System.Windows.Forms.TextBox hostbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ipbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Aliasbox;
    }
}