namespace Login_Form
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_sgnin = new System.Windows.Forms.Button();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.txtBx_paswrd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBx_usr = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkBx_showpassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sgnin
            // 
            this.btn_sgnin.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_sgnin.Location = new System.Drawing.Point(466, 244);
            this.btn_sgnin.Name = "btn_sgnin";
            this.btn_sgnin.Size = new System.Drawing.Size(93, 33);
            this.btn_sgnin.TabIndex = 0;
            this.btn_sgnin.Text = "Sign in";
            this.btn_sgnin.UseVisualStyleBackColor = true;
            this.btn_sgnin.Click += new System.EventHandler(this.btn_sgnin_Click);
            // 
            // btn_cancle
            // 
            this.btn_cancle.ForeColor = System.Drawing.Color.Red;
            this.btn_cancle.Location = new System.Drawing.Point(373, 244);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(65, 33);
            this.btn_cancle.TabIndex = 1;
            this.btn_cancle.Text = "Cancle";
            this.btn_cancle.UseVisualStyleBackColor = true;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // txtBx_paswrd
            // 
            this.txtBx_paswrd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtBx_paswrd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBx_paswrd.Location = new System.Drawing.Point(373, 179);
            this.txtBx_paswrd.Name = "txtBx_paswrd";
            this.txtBx_paswrd.PasswordChar = '*';
            this.txtBx_paswrd.Size = new System.Drawing.Size(186, 20);
            this.txtBx_paswrd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(370, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(370, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username:";
            // 
            // txtBx_usr
            // 
            this.txtBx_usr.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtBx_usr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBx_usr.Location = new System.Drawing.Point(373, 130);
            this.txtBx_usr.Name = "txtBx_usr";
            this.txtBx_usr.Size = new System.Drawing.Size(186, 20);
            this.txtBx_usr.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(428, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // chkBx_showpassword
            // 
            this.chkBx_showpassword.AutoSize = true;
            this.chkBx_showpassword.BackColor = System.Drawing.Color.Transparent;
            this.chkBx_showpassword.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.chkBx_showpassword.Location = new System.Drawing.Point(373, 200);
            this.chkBx_showpassword.Name = "chkBx_showpassword";
            this.chkBx_showpassword.Size = new System.Drawing.Size(102, 17);
            this.chkBx_showpassword.TabIndex = 7;
            this.chkBx_showpassword.Text = "Show Password";
            this.chkBx_showpassword.UseVisualStyleBackColor = false;
            this.chkBx_showpassword.CheckedChanged += new System.EventHandler(this.chkBx_showpassword_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(590, 300);
            this.Controls.Add(this.chkBx_showpassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBx_usr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBx_paswrd);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.btn_sgnin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sgnin;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.TextBox txtBx_paswrd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBx_usr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkBx_showpassword;
    }
}

