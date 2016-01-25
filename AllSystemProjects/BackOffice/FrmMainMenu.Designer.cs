namespace BackOffice
{
    partial class FrmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.MenuStripMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEmailClient = new System.Windows.Forms.Button();
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.PicBoxLogo = new System.Windows.Forms.PictureBox();
            this.MenuStripMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStripMainMenu
            // 
            this.MenuStripMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(184)))), ((int)(((byte)(222)))));
            this.MenuStripMainMenu.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.emailClientToolStripMenuItem});
            this.MenuStripMainMenu.Location = new System.Drawing.Point(0, 0);
            this.MenuStripMainMenu.Name = "MenuStripMainMenu";
            this.MenuStripMainMenu.Size = new System.Drawing.Size(1478, 44);
            this.MenuStripMainMenu.TabIndex = 0;
            this.MenuStripMainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(184)))), ((int)(((byte)(222)))));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(73, 40);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(184)))), ((int)(((byte)(222)))));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 40);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // emailClientToolStripMenuItem
            // 
            this.emailClientToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(184)))), ((int)(((byte)(222)))));
            this.emailClientToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.emailClientToolStripMenuItem.Name = "emailClientToolStripMenuItem";
            this.emailClientToolStripMenuItem.Size = new System.Drawing.Size(178, 40);
            this.emailClientToolStripMenuItem.Text = "Email Client";
            this.emailClientToolStripMenuItem.Click += new System.EventHandler(this.emailClientToolStripMenuItem_Click);
            // 
            // btnEmailClient
            // 
            this.btnEmailClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(65)))));
            this.btnEmailClient.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmailClient.ForeColor = System.Drawing.Color.White;
            this.btnEmailClient.Image = ((System.Drawing.Image)(resources.GetObject("btnEmailClient.Image")));
            this.btnEmailClient.Location = new System.Drawing.Point(114, 221);
            this.btnEmailClient.Name = "btnEmailClient";
            this.btnEmailClient.Size = new System.Drawing.Size(354, 235);
            this.btnEmailClient.TabIndex = 1;
            this.btnEmailClient.Text = "Email Client";
            this.btnEmailClient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmailClient.UseVisualStyleBackColor = false;
            this.btnEmailClient.Click += new System.EventHandler(this.btnEmailClient_Click);
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.AutoSize = true;
            this.lblMainMenu.Font = new System.Drawing.Font("Lucida Bright", 20F);
            this.lblMainMenu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMainMenu.Location = new System.Drawing.Point(34, 84);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(232, 45);
            this.lblMainMenu.TabIndex = 2;
            this.lblMainMenu.Text = "Main Menu";
            // 
            // PicBoxLogo
            // 
            this.PicBoxLogo.AccessibleDescription = "Company Logo";
            this.PicBoxLogo.AccessibleName = "Logo";
            this.PicBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicBoxLogo.Image = global::BackOffice.Properties.Resources.logosmaller;
            this.PicBoxLogo.Location = new System.Drawing.Point(558, 84);
            this.PicBoxLogo.Name = "PicBoxLogo";
            this.PicBoxLogo.Size = new System.Drawing.Size(874, 568);
            this.PicBoxLogo.TabIndex = 3;
            this.PicBoxLogo.TabStop = false;
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(56)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1478, 844);
            this.Controls.Add(this.PicBoxLogo);
            this.Controls.Add(this.lblMainMenu);
            this.Controls.Add(this.btnEmailClient);
            this.Controls.Add(this.MenuStripMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStripMainMenu;
            this.Name = "FrmMainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.MenuStripMainMenu.ResumeLayout(false);
            this.MenuStripMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailClientToolStripMenuItem;
        private System.Windows.Forms.Button btnEmailClient;
        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.PictureBox PicBoxLogo;
    }
}

