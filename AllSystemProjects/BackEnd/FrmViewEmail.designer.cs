namespace BackEnd
{
    partial class FrmViewEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewEmail));
            this.txtBxContent = new System.Windows.Forms.TextBox();
            this.txtBxFrom = new System.Windows.Forms.TextBox();
            this.txtBxSubject = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblEmailContent = new System.Windows.Forms.Label();
            this.btnReply = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxContent
            // 
            this.txtBxContent.BackColor = System.Drawing.Color.DimGray;
            this.txtBxContent.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxContent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBxContent.Location = new System.Drawing.Point(554, 179);
            this.txtBxContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBxContent.Multiline = true;
            this.txtBxContent.Name = "txtBxContent";
            this.txtBxContent.ReadOnly = true;
            this.txtBxContent.Size = new System.Drawing.Size(579, 271);
            this.txtBxContent.TabIndex = 0;
            this.txtBxContent.TabStop = false;
            // 
            // txtBxFrom
            // 
            this.txtBxFrom.BackColor = System.Drawing.Color.DimGray;
            this.txtBxFrom.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxFrom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBxFrom.Location = new System.Drawing.Point(554, 25);
            this.txtBxFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBxFrom.Name = "txtBxFrom";
            this.txtBxFrom.ReadOnly = true;
            this.txtBxFrom.Size = new System.Drawing.Size(579, 36);
            this.txtBxFrom.TabIndex = 1;
            this.txtBxFrom.TabStop = false;
            // 
            // txtBxSubject
            // 
            this.txtBxSubject.BackColor = System.Drawing.Color.DimGray;
            this.txtBxSubject.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxSubject.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBxSubject.Location = new System.Drawing.Point(554, 98);
            this.txtBxSubject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBxSubject.Name = "txtBxSubject";
            this.txtBxSubject.ReadOnly = true;
            this.txtBxSubject.Size = new System.Drawing.Size(579, 36);
            this.txtBxSubject.TabIndex = 2;
            this.txtBxSubject.TabStop = false;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFrom.Location = new System.Drawing.Point(268, 26);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(101, 40);
            this.lblFrom.TabIndex = 3;
            this.lblFrom.Text = "From";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSubject.Location = new System.Drawing.Point(268, 98);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(137, 40);
            this.lblSubject.TabIndex = 4;
            this.lblSubject.Text = "Subject";
            // 
            // lblEmailContent
            // 
            this.lblEmailContent.AutoSize = true;
            this.lblEmailContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailContent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEmailContent.Location = new System.Drawing.Point(268, 179);
            this.lblEmailContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailContent.Name = "lblEmailContent";
            this.lblEmailContent.Size = new System.Drawing.Size(243, 40);
            this.lblEmailContent.TabIndex = 5;
            this.lblEmailContent.Text = "Email Content";
            // 
            // btnReply
            // 
            this.btnReply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.btnReply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnReply.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReply.Location = new System.Drawing.Point(554, 533);
            this.btnReply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReply.Name = "btnReply";
            this.btnReply.Size = new System.Drawing.Size(222, 62);
            this.btnReply.TabIndex = 6;
            this.btnReply.Text = "Reply";
            this.btnReply.UseVisualStyleBackColor = false;
            this.btnReply.Click += new System.EventHandler(this.btnReply_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(926, 533);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(207, 62);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmViewEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(56)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1478, 844);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReply);
            this.Controls.Add(this.lblEmailContent);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.txtBxSubject);
            this.Controls.Add(this.txtBxFrom);
            this.Controls.Add(this.txtBxContent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmViewEmail";
            this.Text = "View Email";
            this.Load += new System.EventHandler(this.FrmViewEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxContent;
        private System.Windows.Forms.TextBox txtBxFrom;
        private System.Windows.Forms.TextBox txtBxSubject;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblEmailContent;
        private System.Windows.Forms.Button btnReply;
        private System.Windows.Forms.Button btnClose;

    }
}