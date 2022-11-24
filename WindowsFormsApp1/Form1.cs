using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string button = string.Empty;
        int x = 10;
        int y = 10;
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    PictureBox pic = new PictureBox
                    {
                        Name = $"{i}_{j}",
                        BorderStyle = BorderStyle.FixedSingle,
                        Size = new Size(35, 35),
                        Location = new Point(35 * i, 35 * j),
                    };
                    panel1.Controls.Add(pic);
                }
            }
            PictureBox pic1 = panel1.Controls[x+"_"+y] as PictureBox;
            pic1.BackgroundImage = Properties.Resources.BCvertical;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button = "button3";
            if (x < 19)
            {
                PictureBox pic2 = panel1.Controls[x + "_" + y] as PictureBox;
                pic2.BackgroundImage = null;
                x++;
                PictureBox pic1 = panel1.Controls[x + "_" + y] as PictureBox;
                if (x <= 19)
                    pic1.BackgroundImage = Properties.Resources.BCright;
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button = "button1";

            if (y > 0)
            {
                PictureBox pic2 = panel1.Controls[x + "_" + y] as PictureBox;
                pic2.BackgroundImage = null;
                y--;
                PictureBox pic1 = panel1.Controls[x + "_" + (y)] as PictureBox;
                if(y>=0)
                pic1.BackgroundImage = Properties.Resources.BCvertical;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button = "button2";

            if (x > 0)
                {
                    PictureBox pic2 = panel1.Controls[x + "_" + y] as PictureBox;
                    pic2.BackgroundImage = null;
                    x--;
                    PictureBox pic1 = panel1.Controls[x + "_" + y] as PictureBox;
                    if (x >= 0)
                        pic1.BackgroundImage = Properties.Resources.BCleft;
                }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button = "button5";

            if (y < 19)
            {
                PictureBox pic2 = panel1.Controls[x + "_" + y] as PictureBox;
                pic2.BackgroundImage = null;
                y++;
                PictureBox pic1 = panel1.Controls[x + "_" + (y)] as PictureBox;
                if (y <= 19)
                    pic1.BackgroundImage = Properties.Resources.BCbottom;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
                timer1.Enabled = true;
            else
                timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if(button == "button5")
            {
                button5_Click(sender, e);
            }
            else if (button == "button2")
            {
                button2_Click(sender, e);
            }
            else if (button == "button1")
            {
                button1_Click(sender, e);
            }
            else if (button == "button3")
            {
                button3_Click(sender, e);
            }
        }
    }
}
