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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPost = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbDescriptionProduct = new System.Windows.Forms.Label();
            this.lbNameSupermarket = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.pctUserIcon = new System.Windows.Forms.PictureBox();
            this.pctDefault = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDefault)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbUserName);
            this.panel1.Controls.Add(this.labelPost);
            this.panel1.Location = new System.Drawing.Point(35, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 42);
            this.panel1.TabIndex = 1;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.lbPrice);
            this.panel2.Controls.Add(this.lbNameSupermarket);
            this.panel2.Controls.Add(this.lbDescriptionProduct);
            this.panel2.Location = new System.Drawing.Point(3, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 67);
            this.panel2.TabIndex = 2;
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
            // 
            // lbNameSupermarket
            // 
            this.lbNameSupermarket.AutoSize = true;
            this.lbNameSupermarket.ForeColor = System.Drawing.Color.Gray;
            this.lbNameSupermarket.Location = new System.Drawing.Point(33, 30);
            this.lbNameSupermarket.Name = "lbNameSupermarket";
            this.lbNameSupermarket.Size = new System.Drawing.Size(112, 13);
            this.lbNameSupermarket.TabIndex = 1;
            this.lbNameSupermarket.Text = "Supermercado Enxuto";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(82)))), ((int)(((byte)(65)))));
            this.lbPrice.Location = new System.Drawing.Point(130, 52);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(52, 13);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "R$ 9,49";
            // 
            // pctUserIcon
            // 
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
            this.pctDefault.Image = global::ProjetoInterdisciplinar.Properties.Resources.grocery_png;
            this.pctDefault.Location = new System.Drawing.Point(35, 58);
            this.pctDefault.Name = "pctDefault";
            this.pctDefault.Size = new System.Drawing.Size(104, 120);
            this.pctDefault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctDefault.TabIndex = 0;
            this.pctDefault.TabStop = false;
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pctUserIcon);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pctDefault);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(194, 257);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDefault)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctDefault;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbNameSupermarket;
        private System.Windows.Forms.Label lbDescriptionProduct;
        private System.Windows.Forms.PictureBox pctUserIcon;
    }
}
