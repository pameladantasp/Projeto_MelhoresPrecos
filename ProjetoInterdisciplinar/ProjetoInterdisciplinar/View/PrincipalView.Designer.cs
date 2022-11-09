namespace ProjetoInterdisciplinar.View
{
    partial class PrincipalView
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
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbRegister = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.listItem1 = new ProjetoInterdisciplinar.View.ListItem();
            this.listItem2 = new ProjetoInterdisciplinar.View.ListItem();
            this.listItem3 = new ProjetoInterdisciplinar.View.ListItem();
            this.listItem4 = new ProjetoInterdisciplinar.View.ListItem();
            this.panelToolbar.SuspendLayout();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbLogin.Location = new System.Drawing.Point(580, 19);
            this.lbLogin.Margin = new System.Windows.Forms.Padding(5);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(58, 13);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "ENTRAR";
            this.lbLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbLogin.Click += new System.EventHandler(this.lbLogin_Click);
            // 
            // lbRegister
            // 
            this.lbRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRegister.AutoSize = true;
            this.lbRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbRegister.Location = new System.Drawing.Point(478, 19);
            this.lbRegister.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(82, 13);
            this.lbRegister.TabIndex = 1;
            this.lbRegister.Text = "CADASTRAR";
            this.lbRegister.Click += new System.EventHandler(this.lbRegister_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(2, 11);
            this.labelSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(415, 17);
            this.labelSearch.TabIndex = 2;
            this.labelSearch.Text = "Pesquise seus produtos e descubra os melhores precos";
            // 
            // panelToolbar
            // 
            this.panelToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(82)))), ((int)(((byte)(65)))));
            this.panelToolbar.Controls.Add(this.pictureBox1);
            this.panelToolbar.Controls.Add(this.lbLogin);
            this.panelToolbar.Controls.Add(this.lbRegister);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolbar.Location = new System.Drawing.Point(0, 0);
            this.panelToolbar.Margin = new System.Windows.Forms.Padding(2);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(664, 52);
            this.panelToolbar.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtSearch.Location = new System.Drawing.Point(3, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(411, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.Text = "Busque por um produto...";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearch.Controls.Add(this.labelSearch);
            this.panelSearch.Controls.Add(this.pictureBox2);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Location = new System.Drawing.Point(134, 57);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(434, 67);
            this.panelSearch.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::ProjetoInterdisciplinar.Properties.Resources.search_png;
            this.pictureBox2.Location = new System.Drawing.Point(391, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::ProjetoInterdisciplinar.Properties.Resources.logoAppTranslucido;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Size = new System.Drawing.Size(81, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.listItem1);
            this.flowLayoutPanel1.Controls.Add(this.listItem3);
            this.flowLayoutPanel1.Controls.Add(this.listItem4);
            this.flowLayoutPanel1.Controls.Add(this.listItem2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 130);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(640, 296);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // listItem1
            // 
            this.listItem1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listItem1.Location = new System.Drawing.Point(3, 3);
            this.listItem1.Name = "listItem1";
            this.listItem1.Size = new System.Drawing.Size(194, 257);
            this.listItem1.TabIndex = 0;
            // 
            // listItem2
            // 
            this.listItem2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listItem2.Location = new System.Drawing.Point(3, 266);
            this.listItem2.Name = "listItem2";
            this.listItem2.Size = new System.Drawing.Size(194, 257);
            this.listItem2.TabIndex = 0;
            // 
            // listItem3
            // 
            this.listItem3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listItem3.Location = new System.Drawing.Point(203, 3);
            this.listItem3.Name = "listItem3";
            this.listItem3.Size = new System.Drawing.Size(194, 257);
            this.listItem3.TabIndex = 0;
            // 
            // listItem4
            // 
            this.listItem4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listItem4.Location = new System.Drawing.Point(403, 3);
            this.listItem4.Name = "listItem4";
            this.listItem4.Size = new System.Drawing.Size(194, 257);
            this.listItem4.TabIndex = 0;
            // 
            // PrincipalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 438);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelToolbar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(693, 501);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(680, 477);
            this.Name = "PrincipalView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.PrincipalView_Load);
            this.panelToolbar.ResumeLayout(false);
            this.panelToolbar.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbRegister;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Panel panelToolbar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ListItem listItem1;
        private ListItem listItem3;
        private ListItem listItem4;
        private ListItem listItem2;
    }
}