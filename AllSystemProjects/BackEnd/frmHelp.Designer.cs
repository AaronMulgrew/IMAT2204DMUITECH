namespace BackEnd
{
    partial class frmHelp
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblQ1 = new System.Windows.Forms.Label();
            this.lblA1 = new System.Windows.Forms.Label();
            this.lblQ2 = new System.Windows.Forms.Label();
            this.lblA2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(16, 10);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 43);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblQ1
            // 
            this.lblQ1.AutoSize = true;
            this.lblQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblQ1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblQ1.Location = new System.Drawing.Point(16, 88);
            this.lblQ1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQ1.Name = "lblQ1";
            this.lblQ1.Size = new System.Drawing.Size(406, 24);
            this.lblQ1.TabIndex = 1;
            this.lblQ1.Text = "How do I create a service order for a customer?";
            this.lblQ1.Click += new System.EventHandler(this.lblQ1_Click);
            // 
            // lblA1
            // 
            this.lblA1.AutoSize = true;
            this.lblA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblA1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblA1.Location = new System.Drawing.Point(16, 112);
            this.lblA1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblA1.Name = "lblA1";
            this.lblA1.Size = new System.Drawing.Size(503, 24);
            this.lblA1.TabIndex = 2;
            this.lblA1.Text = "Go to Main Menu, and then click on \'Create Service Order\'.";
            // 
            // lblQ2
            // 
            this.lblQ2.AutoSize = true;
            this.lblQ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblQ2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblQ2.Location = new System.Drawing.Point(16, 157);
            this.lblQ2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQ2.Name = "lblQ2";
            this.lblQ2.Size = new System.Drawing.Size(310, 24);
            this.lblQ2.TabIndex = 3;
            this.lblQ2.Text = "How to change my login password?";
            // 
            // lblA2
            // 
            this.lblA2.AutoSize = true;
            this.lblA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblA2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblA2.Location = new System.Drawing.Point(16, 188);
            this.lblA2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblA2.Name = "lblA2";
            this.lblA2.Size = new System.Drawing.Size(412, 24);
            this.lblA2.TabIndex = 4;
            this.lblA2.Text = "Go to Main Menu, and then click on \'Staff Portal\'.";
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(56)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(527, 452);
            this.Controls.Add(this.lblA2);
            this.Controls.Add(this.lblQ2);
            this.Controls.Add(this.lblA1);
            this.Controls.Add(this.lblQ1);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHelp";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.frmHelp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblQ1;
        private System.Windows.Forms.Label lblA1;
        private System.Windows.Forms.Label lblQ2;
        private System.Windows.Forms.Label lblA2;
    }
}