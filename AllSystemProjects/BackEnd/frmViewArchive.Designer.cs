namespace BackEnd
{
    partial class frmViewArchive
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
            this.lblError = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblInbox = new System.Windows.Forms.Label();
            this.dataGridViewInbox = new System.Windows.Forms.DataGridView();
            this.btnViewEmail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInbox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblError.Location = new System.Drawing.Point(14, 702);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 51);
            this.lblError.TabIndex = 13;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(1209, 662);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(400, 125);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // lblInbox
            // 
            this.lblInbox.AutoSize = true;
            this.lblInbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInbox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblInbox.Location = new System.Drawing.Point(14, 11);
            this.lblInbox.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblInbox.Name = "lblInbox";
            this.lblInbox.Size = new System.Drawing.Size(184, 55);
            this.lblInbox.TabIndex = 8;
            this.lblInbox.Text = "Archive";
            // 
            // dataGridViewInbox
            // 
            this.dataGridViewInbox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInbox.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewInbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.dataGridViewInbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInbox.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.dataGridViewInbox.Location = new System.Drawing.Point(14, 88);
            this.dataGridViewInbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridViewInbox.Name = "dataGridViewInbox";
            this.dataGridViewInbox.Size = new System.Drawing.Size(1595, 381);
            this.dataGridViewInbox.TabIndex = 7;
            // 
            // btnViewEmail
            // 
            this.btnViewEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.btnViewEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnViewEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewEmail.Location = new System.Drawing.Point(23, 498);
            this.btnViewEmail.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnViewEmail.Name = "btnViewEmail";
            this.btnViewEmail.Size = new System.Drawing.Size(400, 125);
            this.btnViewEmail.TabIndex = 10;
            this.btnViewEmail.Text = "View Email";
            this.btnViewEmail.UseVisualStyleBackColor = false;
            // 
            // frmViewArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(76)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(1713, 829);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnViewEmail);
            this.Controls.Add(this.lblInbox);
            this.Controls.Add(this.dataGridViewInbox);
            this.Name = "frmViewArchive";
            this.Text = "frmViewArchive";
            this.Load += new System.EventHandler(this.frmViewArchive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblInbox;
        private System.Windows.Forms.DataGridView dataGridViewInbox;
        private System.Windows.Forms.Button btnViewEmail;
    }
}