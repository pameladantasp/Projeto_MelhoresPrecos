namespace ProjetoInterdisciplinar.View
{
    partial class InitialView
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(1265, 55);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(98, 25);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "ENTRAR";
            this.lbLogin.Click += new System.EventHandler(this.lbLogin_Click);
            // 
            // lbRegister
            // 
            this.lbRegister.AutoSize = true;
            this.lbRegister.Location = new System.Drawing.Point(1081, 55);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(141, 25);
            this.lbRegister.TabIndex = 1;
            this.lbRegister.Text = "CADASTRAR";
            this.lbRegister.Click += new System.EventHandler(this.lbRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquise seus produtos e descubra os melhores precos";
            // 
            // InitialView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 886);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbRegister);
            this.Controls.Add(this.lbLogin);
            this.Name = "InitialView";
            this.Text = "InitialView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbRegister;
        private System.Windows.Forms.Label label1;
    }
}