namespace BackOffice
{
    partial class frmViewInbox
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewInbox));
            this.dataGridViewInbox = new System.Windows.Forms.DataGridView();
            this.lblInbox = new System.Windows.Forms.Label();
            this.btnShowMoreEmails = new System.Windows.Forms.Button();
            this.btnViewEmail = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnArchiveEmail = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.clsEmailCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allEmailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allEmailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEmailCollectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allEmailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allEmailsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInbox
            // 
            this.dataGridViewInbox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInbox.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewInbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.dataGridViewInbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInbox.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.dataGridViewInbox.Location = new System.Drawing.Point(128, 102);
            this.dataGridViewInbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridViewInbox.Name = "dataGridViewInbox";
            this.dataGridViewInbox.Size = new System.Drawing.Size(1595, 381);
            this.dataGridViewInbox.TabIndex = 0;
            // 
            // lblInbox
            // 
            this.lblInbox.AutoSize = true;
            this.lblInbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInbox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblInbox.Location = new System.Drawing.Point(128, 25);
            this.lblInbox.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblInbox.Name = "lblInbox";
            this.lblInbox.Size = new System.Drawing.Size(142, 55);
            this.lblInbox.TabIndex = 1;
            this.lblInbox.Text = "Inbox";
            // 
            // btnShowMoreEmails
            // 
            this.btnShowMoreEmails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.btnShowMoreEmails.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnShowMoreEmails.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowMoreEmails.Location = new System.Drawing.Point(777, 512);
            this.btnShowMoreEmails.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnShowMoreEmails.Name = "btnShowMoreEmails";
            this.btnShowMoreEmails.Size = new System.Drawing.Size(400, 125);
            this.btnShowMoreEmails.TabIndex = 2;
            this.btnShowMoreEmails.Text = "Show More Emails";
            this.btnShowMoreEmails.UseVisualStyleBackColor = false;
            this.btnShowMoreEmails.Click += new System.EventHandler(this.btnShowMoreEmails_Click);
            // 
            // btnViewEmail
            // 
            this.btnViewEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.btnViewEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnViewEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewEmail.Location = new System.Drawing.Point(137, 512);
            this.btnViewEmail.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnViewEmail.Name = "btnViewEmail";
            this.btnViewEmail.Size = new System.Drawing.Size(400, 125);
            this.btnViewEmail.TabIndex = 3;
            this.btnViewEmail.Text = "View Email";
            this.btnViewEmail.UseVisualStyleBackColor = false;
            this.btnViewEmail.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(1323, 676);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(400, 125);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnArchiveEmail
            // 
            this.btnArchiveEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.btnArchiveEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnArchiveEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnArchiveEmail.Location = new System.Drawing.Point(1323, 512);
            this.btnArchiveEmail.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnArchiveEmail.Name = "btnArchiveEmail";
            this.btnArchiveEmail.Size = new System.Drawing.Size(400, 125);
            this.btnArchiveEmail.TabIndex = 5;
            this.btnArchiveEmail.Text = "Archive Email";
            this.btnArchiveEmail.UseVisualStyleBackColor = false;
            this.btnArchiveEmail.Click += new System.EventHandler(this.btnDeleteEmail_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblError.Location = new System.Drawing.Point(128, 716);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 51);
            this.lblError.TabIndex = 6;
            // 
            // timerLoading
            // 
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // clsEmailCollectionBindingSource
            // 
            this.clsEmailCollectionBindingSource.DataSource = typeof(MyClassLibrary.clsEmailCollection);
            // 
            // allEmailsBindingSource
            // 
            this.allEmailsBindingSource.DataMember = "AllEmails";
            this.allEmailsBindingSource.DataSource = this.clsEmailCollectionBindingSource;
            // 
            // allEmailsBindingSource1
            // 
            this.allEmailsBindingSource1.DataMember = "AllEmails";
            this.allEmailsBindingSource1.DataSource = this.clsEmailCollectionBindingSource;
            // 
            // frmViewInbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(56)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1971, 1055);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnArchiveEmail);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnViewEmail);
            this.Controls.Add(this.btnShowMoreEmails);
            this.Controls.Add(this.lblInbox);
            this.Controls.Add(this.dataGridViewInbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmViewInbox";
            this.Text = "FrmViewInbox";
            this.Load += new System.EventHandler(this.FrmViewInbox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEmailCollectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allEmailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allEmailsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInbox;
        private System.Windows.Forms.Label lblInbox;
        private System.Windows.Forms.Button btnShowMoreEmails;
        private System.Windows.Forms.Button btnViewEmail;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnArchiveEmail;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.BindingSource allEmailsBindingSource;
        private System.Windows.Forms.BindingSource clsEmailCollectionBindingSource;
        private System.Windows.Forms.BindingSource allEmailsBindingSource1;
    }
}