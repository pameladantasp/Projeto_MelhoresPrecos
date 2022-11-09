namespace ProjetoInterdisciplinar.View
{
    partial class ListItem
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelInformationUser = new System.Windows.Forms.Panel();
            this.labelPost = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.panelInformationItem = new System.Windows.Forms.Panel();
            this.lbDescriptionProduct = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pctUserIcon = new System.Windows.Forms.PictureBox();
            this.pctDefault = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelInformationUser.SuspendLayout();
            this.panelInformationItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDefault)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInformationUser
            // 
            this.panelInformationUser.Controls.Add(this.lbUserName);
            this.panelInformationUser.Controls.Add(this.labelPost);
            this.panelInformationUser.Location = new System.Drawing.Point(35, 10);
            this.panelInformationUser.Name = "panelInformationUser";
            this.panelInformationUser.Size = new System.Drawing.Size(153, 42);
            this.panelInformationUser.TabIndex = 1;
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.ForeColor = System.Drawing.Color.Gray;
            this.labelPost.Location = new System.Drawing.Point(4, 4);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(67, 13);
            this.labelPost.TabIndex = 0;
            this.labelPost.Text = "Postado por:";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(4, 21);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(110, 13);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "Angelica Acevedo";
            // 
            // panelInformationItem
            // 
            this.panelInformationItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInformationItem.Controls.Add(this.panel1);
            this.panelInformationItem.Controls.Add(this.label5);
            this.panelInformationItem.Controls.Add(this.label4);
            this.panelInformationItem.Controls.Add(this.lbDescriptionProduct);
            this.panelInformationItem.Location = new System.Drawing.Point(3, 184);
            this.panelInformationItem.Name = "panelInformationItem";
            this.panelInformationItem.Size = new System.Drawing.Size(185, 67);
            this.panelInformationItem.TabIndex = 2;
            // 
            // lbDescriptionProduct
            // 
            this.lbDescriptionProduct.AutoSize = true;
            this.lbDescriptionProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescriptionProduct.Location = new System.Drawing.Point(4, 5);
            this.lbDescriptionProduct.Name = "lbDescriptionProduct";
            this.lbDescriptionProduct.Size = new System.Drawing.Size(184, 13);
            this.lbDescriptionProduct.TabIndex = 0;
            this.lbDescriptionProduct.Text = "Refrigerante Coca Cola Pet 3 L";
            this.lbDescriptionProduct.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(33, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Supermercado Enxuto";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(82)))), ((int)(((byte)(65)))));
            this.label5.Location = new System.Drawing.Point(130, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "R$ 9,49";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // pctUserIcon
            // 
            this.pctUserIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctUserIcon.Image = global::ProjetoInterdisciplinar.Properties.Resources.userIcon_png;
            this.pctUserIcon.Location = new System.Drawing.Point(7, 10);
            this.pctUserIcon.Name = "pctUserIcon";
            this.pctUserIcon.Size = new System.Drawing.Size(22, 34);
            this.pctUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctUserIcon.TabIndex = 3;
            this.pctUserIcon.TabStop = false;
            // 
            // pctDefault
            // 
            this.pctDefault.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctDefault.Image = global::ProjetoInterdisciplinar.Properties.Resources.grocery_png;
            this.pctDefault.Location = new System.Drawing.Point(35, 58);
            this.pctDefault.Name = "pctDefault";
            this.pctDefault.Size = new System.Drawing.Size(104, 120);
            this.pctDefault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctDefault.TabIndex = 0;
            this.pctDefault.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(1, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 1);
            this.panel1.TabIndex = 3;
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pctUserIcon);
            this.Controls.Add(this.panelInformationItem);
            this.Controls.Add(this.panelInformationUser);
            this.Controls.Add(this.pctDefault);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(192, 255);
            this.panelInformationUser.ResumeLayout(false);
            this.panelInformationUser.PerformLayout();
            this.panelInformationItem.ResumeLayout(false);
            this.panelInformationItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDefault)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctDefault;
        private System.Windows.Forms.Panel panelInformationUser;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Panel panelInformationItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbDescriptionProduct;
        private System.Windows.Forms.PictureBox pctUserIcon;
        private System.Windows.Forms.Panel panel1;
    }
}
