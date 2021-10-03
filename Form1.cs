using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trygame
{
    public partial class Form1 : Form
    {
        int score;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            timer1.Interval = 100;
            timer1.Start();



        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pb1.Location.X;
            int y = pb1.Location.Y;

            if (e.KeyCode == Keys.D) x += 10;
            else if (e.KeyCode == Keys.A) x -= 10;
           // else if (e.KeyCode == Keys.W) y -= 10;
            //else if (e.KeyCode == Keys.S) y += 10;

            pb1.Location = new Point(x, y);

            if (e.KeyCode == Keys.B)
            {
                b1.Visible = true;

               b1.Top = pb1.Top - 30;
               b1.Left = pb1.Left + (pb1.Width / 2);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (pb4.Top > 450 || pb3.Top > 450 || pb2.Top > 450)
            {

                pb1.Visible = false;
                pb2.Visible = false;
                pb3.Visible = false;
                pb4.Visible = false;
                b1.Visible = false;
                label2.Text = "Game over";
                label2.Visible = true;
            }
            int z = pb2.Location.Y;
            if (pb2.Location.Y < 450)
            { z += 5;
                pb2.Location = new Point(pb2.Location.X, z);
            }

            else
            {
                pb2.Location = new Point(pb2.Location.X, 0);
            }


            int z2 = pb3.Location.Y;
            if (pb3.Location.Y < 450)
            {
                z2 += 5;
                pb3.Location = new Point(pb3.Location.X, z2);
            }

            else
            {
                pb3.Location = new Point(pb3.Location.X, 0);
            }


            int z3 = pb4.Location.Y;
            if (pb4.Location.Y < 450)
            {
                z3 += 5;
                pb4.Location = new Point(pb4.Location.X, z3);
            }

            else
            {
                pb4.Location = new Point(pb4.Location.X, 0);
            }

       
            if(b1.Visible==true)
            {
                int b = 0;
                b = b1.Location.Y;
                b -= 1;
                b1.Location = new Point(b1.Location.X, b);

            }
           if(b1.Bounds.IntersectsWith(pb4.Bounds))
            { 

                score += 1;
                lblScore.Text = Convert.ToString( score);
                pb4.Visible = false;
            }

            if (b1.Bounds.IntersectsWith(pb2.Bounds))
            {

                score += 1;
                lblScore.Text = Convert.ToString(score);
                pb2.Visible = false;
            }
            if (b1.Bounds.IntersectsWith(pb3.Bounds))
            {

                score += 1;
                lblScore.Text = Convert.ToString(score);
                pb3.Visible = false;
            }
        }
    }
}
