using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ascii_Project {
    public partial class Form1 : Form {
        Bitmap bmp_temp = new Bitmap(256,256);
        public Form1() {
            InitializeComponent();
        }

        private void Generate_Bitmap(object sender, EventArgs e) {
            Bitmap bmp_temp = new Bitmap(256,256);
            Random rnd = new Random();
            for (int i = 0; i < 4000; i++) {
                int x = rnd.Next(0,255);
                int y = rnd.Next(0,255);
                int red = rnd.Next(0,255);
                int grn = rnd.Next(0,255);
                int blu = rnd.Next(0,255);
                bmp_temp.SetPixel(x,y,Color.FromArgb(red,grn,blu));

            }

            pictureBox2.Image = bmp_temp;

        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs Mouse) {
            Color pixel_col = bmp_temp.GetPixel(Mouse.X, Mouse.Y);


        }
    }
}
