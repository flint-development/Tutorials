using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radar
{
    public partial class Form1 : Form
    {
        Timer t = new Timer();

        int WIDTH = 300, HEIGHT = 300, HAND = 150;

        int u;  //in degree
        int cx, cy;     //center of the circle
        int x, y;       //HAND coordinate

        int tx, ty, lim = 20;

        private void btn_radar_start_Click(object sender, EventArgs e)
        {
            t.Start();
        }

        private void btn_radar_stop_Click(object sender, EventArgs e)
        {
            t.Stop();
        }

        private void tkB_speed_Scroll(object sender, EventArgs e)
        {
            t.Interval = tkB_speed.Value;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        Bitmap bmp;
        Pen p;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //create Bitmap
            bmp = new Bitmap(WIDTH + 1, HEIGHT + 1);

            //background color
            this.BackColor = Color.Black;

            //center
            cx = WIDTH / 2;
            cy = HEIGHT / 2;

            //initial degree of HAND
            u = 0;

            //timer
            t.Interval = 5; //in millisecond
            t.Tick += new EventHandler(this.t_Tick);
        }

        private void t_Tick(object sender, EventArgs e)
        {

            //speed of tkb value
            lbl_speed_now.Text = Convert.ToString(tkB_speed.Value);

            //speed of radar now
            lbl_speed_cy.Text = Convert.ToString(cy);
            lbl_speed_cx.Text = Convert.ToString(cx);

            //update Systemstate
            proBr_val_y.Value = y;
            lbl_val_y.Text = Convert.ToString(proBr_val_y.Value);

            proBr_val_x.Value = x;
            lbl_val_x.Text = Convert.ToString(proBr_val_x.Value);

            proBr_val_ty.Value = ty;
            lbl_val_ty.Text = Convert.ToString(proBr_val_ty.Value);

            proBr_val_tx.Value = tx;
            lbl_val_tx.Text = Convert.ToString(proBr_val_tx.Value);

            //pen
            p = new Pen(Color.Green, 1f);

            //graphics
            g = Graphics.FromImage(bmp);

            //calculate x, y coordinate of HAND
            int tu = (u - lim) % 360;

            if (u >= 0 && u <= 180)
            {
                //right half
                //u in degree is converted into radian.

                x = cx + (int)(HAND * Math.Sin(Math.PI * u / 180));
                y = cy - (int)(HAND * Math.Cos(Math.PI * u / 180));
            }
            else
            {
                x = cx - (int)(HAND * -Math.Sin(Math.PI * u / 180));
                y = cy - (int)(HAND * Math.Cos(Math.PI * u / 180));
            }

            if (tu >= 0 && tu <= 180)
            {
                //right half
                //tu in degree is converted into radian.

                tx = cx + (int)(HAND * Math.Sin(Math.PI * tu / 180));
                ty = cy - (int)(HAND * Math.Cos(Math.PI * tu / 180));
            }
            else
            {
                tx = cx - (int)(HAND * -Math.Sin(Math.PI * tu / 180));
                ty = cy - (int)(HAND * Math.Cos(Math.PI * tu / 180));
            }

            //draw circle
            g.DrawEllipse(p, 0, 0, WIDTH, HEIGHT);  //bigger circle
            g.DrawEllipse(p, 45, 45, WIDTH - 90, HEIGHT - 90); // middle circle
            g.DrawEllipse(p, 80, 80, WIDTH - 160, HEIGHT - 160); //smaller circle

            //draw perpendicular line
            g.DrawLine(p, new Point(cx, 0), new Point(cx, HEIGHT)); // UP-DOWN
            g.DrawLine(p, new Point(0, cy), new Point(WIDTH, cy)); //LEFT-RIGHT

            //draw HAND
            g.DrawLine(new Pen(Color.Black, 1f), new Point(cx, cy), new Point(tx, ty));
            g.DrawLine(p, new Point(cx, cy), new Point(x, y));

            //load bitmap in picturebox1
            picBx_1.Image = bmp;

            //dispose
            p.Dispose();
            g.Dispose();

            //update
            u++;
            if (u == 360)
            {
                u = 0;
            }
        }
    }
}
