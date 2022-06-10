
namespace Radar
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
            this.picBx_1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_val_tx = new System.Windows.Forms.Label();
            this.lbl_val_ty = new System.Windows.Forms.Label();
            this.lbl_val_x = new System.Windows.Forms.Label();
            this.lbl_val_y = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_speed_cx = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_speed_now = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_speed_cy = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.proBr_val_tx = new System.Windows.Forms.ProgressBar();
            this.proBr_val_ty = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.proBr_val_x = new System.Windows.Forms.ProgressBar();
            this.proBr_val_y = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tkB_speed = new System.Windows.Forms.TrackBar();
            this.btn_radar_stop = new System.Windows.Forms.Button();
            this.btn_radar_start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBx_1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkB_speed)).BeginInit();
            this.SuspendLayout();
            // 
            // picBx_1
            // 
            this.picBx_1.Location = new System.Drawing.Point(0, 0);
            this.picBx_1.Name = "picBx_1";
            this.picBx_1.Size = new System.Drawing.Size(989, 433);
            this.picBx_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBx_1.TabIndex = 0;
            this.picBx_1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbl_val_tx);
            this.panel1.Controls.Add(this.lbl_val_ty);
            this.panel1.Controls.Add(this.lbl_val_x);
            this.panel1.Controls.Add(this.lbl_val_y);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lbl_speed_cx);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl_speed_now);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lbl_speed_cy);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.proBr_val_tx);
            this.panel1.Controls.Add(this.proBr_val_ty);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.proBr_val_x);
            this.panel1.Controls.Add(this.proBr_val_y);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tkB_speed);
            this.panel1.Controls.Add(this.btn_radar_stop);
            this.panel1.Controls.Add(this.btn_radar_start);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(741, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 433);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_val_tx
            // 
            this.lbl_val_tx.AutoSize = true;
            this.lbl_val_tx.ForeColor = System.Drawing.Color.Red;
            this.lbl_val_tx.Location = new System.Drawing.Point(56, 221);
            this.lbl_val_tx.Name = "lbl_val_tx";
            this.lbl_val_tx.Size = new System.Drawing.Size(25, 13);
            this.lbl_val_tx.TabIndex = 28;
            this.lbl_val_tx.Text = "000";
            // 
            // lbl_val_ty
            // 
            this.lbl_val_ty.AutoSize = true;
            this.lbl_val_ty.ForeColor = System.Drawing.Color.Red;
            this.lbl_val_ty.Location = new System.Drawing.Point(56, 198);
            this.lbl_val_ty.Name = "lbl_val_ty";
            this.lbl_val_ty.Size = new System.Drawing.Size(25, 13);
            this.lbl_val_ty.TabIndex = 27;
            this.lbl_val_ty.Text = "000";
            // 
            // lbl_val_x
            // 
            this.lbl_val_x.AutoSize = true;
            this.lbl_val_x.ForeColor = System.Drawing.Color.Red;
            this.lbl_val_x.Location = new System.Drawing.Point(56, 172);
            this.lbl_val_x.Name = "lbl_val_x";
            this.lbl_val_x.Size = new System.Drawing.Size(25, 13);
            this.lbl_val_x.TabIndex = 26;
            this.lbl_val_x.Text = "000";
            // 
            // lbl_val_y
            // 
            this.lbl_val_y.AutoSize = true;
            this.lbl_val_y.ForeColor = System.Drawing.Color.Red;
            this.lbl_val_y.Location = new System.Drawing.Point(56, 150);
            this.lbl_val_y.Name = "lbl_val_y";
            this.lbl_val_y.Size = new System.Drawing.Size(25, 13);
            this.lbl_val_y.TabIndex = 25;
            this.lbl_val_y.Text = "000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(125, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Value Speed mow (cx):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(189, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "s/p";
            // 
            // lbl_speed_cx
            // 
            this.lbl_speed_cx.AutoSize = true;
            this.lbl_speed_cx.ForeColor = System.Drawing.Color.Red;
            this.lbl_speed_cx.Location = new System.Drawing.Point(158, 122);
            this.lbl_speed_cx.Name = "lbl_speed_cx";
            this.lbl_speed_cx.Size = new System.Drawing.Size(25, 13);
            this.lbl_speed_cx.TabIndex = 22;
            this.lbl_speed_cx.Text = "000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(179, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "p/s";
            // 
            // lbl_speed_now
            // 
            this.lbl_speed_now.AutoSize = true;
            this.lbl_speed_now.ForeColor = System.Drawing.Color.Red;
            this.lbl_speed_now.Location = new System.Drawing.Point(154, 70);
            this.lbl_speed_now.Name = "lbl_speed_now";
            this.lbl_speed_now.Size = new System.Drawing.Size(25, 13);
            this.lbl_speed_now.TabIndex = 20;
            this.lbl_speed_now.Text = "000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(3, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Value Speed mow (cy):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(67, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "s/p";
            // 
            // lbl_speed_cy
            // 
            this.lbl_speed_cy.AutoSize = true;
            this.lbl_speed_cy.ForeColor = System.Drawing.Color.Red;
            this.lbl_speed_cy.Location = new System.Drawing.Point(36, 122);
            this.lbl_speed_cy.Name = "lbl_speed_cy";
            this.lbl_speed_cy.Size = new System.Drawing.Size(25, 13);
            this.lbl_speed_cy.TabIndex = 17;
            this.lbl_speed_cy.Text = "000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(146, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Value Speed:";
            // 
            // proBr_val_tx
            // 
            this.proBr_val_tx.Location = new System.Drawing.Point(87, 221);
            this.proBr_val_tx.Maximum = 360;
            this.proBr_val_tx.Name = "proBr_val_tx";
            this.proBr_val_tx.Size = new System.Drawing.Size(102, 13);
            this.proBr_val_tx.TabIndex = 15;
            // 
            // proBr_val_ty
            // 
            this.proBr_val_ty.Location = new System.Drawing.Point(87, 198);
            this.proBr_val_ty.Maximum = 360;
            this.proBr_val_ty.Name = "proBr_val_ty";
            this.proBr_val_ty.Size = new System.Drawing.Size(102, 13);
            this.proBr_val_ty.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(3, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Value TX:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(3, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Value TY:";
            // 
            // proBr_val_x
            // 
            this.proBr_val_x.Location = new System.Drawing.Point(87, 172);
            this.proBr_val_x.Maximum = 360;
            this.proBr_val_x.Name = "proBr_val_x";
            this.proBr_val_x.Size = new System.Drawing.Size(102, 13);
            this.proBr_val_x.TabIndex = 7;
            // 
            // proBr_val_y
            // 
            this.proBr_val_y.Location = new System.Drawing.Point(87, 150);
            this.proBr_val_y.Maximum = 360;
            this.proBr_val_y.Name = "proBr_val_y";
            this.proBr_val_y.Size = new System.Drawing.Size(102, 13);
            this.proBr_val_y.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(3, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Value X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Value Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "RADAR SCANN SPEED:";
            // 
            // tkB_speed
            // 
            this.tkB_speed.Location = new System.Drawing.Point(15, 61);
            this.tkB_speed.Maximum = 100;
            this.tkB_speed.Minimum = 1;
            this.tkB_speed.Name = "tkB_speed";
            this.tkB_speed.Size = new System.Drawing.Size(124, 45);
            this.tkB_speed.TabIndex = 2;
            this.tkB_speed.Value = 1;
            this.tkB_speed.Scroll += new System.EventHandler(this.tkB_speed_Scroll);
            // 
            // btn_radar_stop
            // 
            this.btn_radar_stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_radar_stop.ForeColor = System.Drawing.Color.Red;
            this.btn_radar_stop.Location = new System.Drawing.Point(140, 3);
            this.btn_radar_stop.Name = "btn_radar_stop";
            this.btn_radar_stop.Size = new System.Drawing.Size(93, 39);
            this.btn_radar_stop.TabIndex = 1;
            this.btn_radar_stop.Text = "STOP RADAR";
            this.btn_radar_stop.UseVisualStyleBackColor = true;
            this.btn_radar_stop.Click += new System.EventHandler(this.btn_radar_stop_Click);
            // 
            // btn_radar_start
            // 
            this.btn_radar_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_radar_start.ForeColor = System.Drawing.Color.Red;
            this.btn_radar_start.Location = new System.Drawing.Point(15, 3);
            this.btn_radar_start.Name = "btn_radar_start";
            this.btn_radar_start.Size = new System.Drawing.Size(93, 39);
            this.btn_radar_start.TabIndex = 0;
            this.btn_radar_start.Text = "START RADAR";
            this.btn_radar_start.UseVisualStyleBackColor = true;
            this.btn_radar_start.Click += new System.EventHandler(this.btn_radar_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 433);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picBx_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1005, 472);
            this.Name = "Form1";
            this.Text = "RADAR-EMULATOR 0.0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBx_1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkB_speed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBx_1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_radar_stop;
        private System.Windows.Forms.Button btn_radar_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tkB_speed;
        private System.Windows.Forms.ProgressBar proBr_val_x;
        private System.Windows.Forms.ProgressBar proBr_val_y;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_speed_cy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar proBr_val_tx;
        private System.Windows.Forms.ProgressBar proBr_val_ty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_speed_now;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_speed_cx;
        private System.Windows.Forms.Label lbl_val_tx;
        private System.Windows.Forms.Label lbl_val_ty;
        private System.Windows.Forms.Label lbl_val_x;
        private System.Windows.Forms.Label lbl_val_y;
    }
}

