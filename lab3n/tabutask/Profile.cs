using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabutask
{
    public partial class Profile : Form
    {
        private Size formOriginalSize;
        private Rectangle recLab3;
        private Rectangle recTex6;
        private Rectangle recTex5;
        private Rectangle recTex2;

        public Profile()
        {
            InitializeComponent();
            this.Resize += profile_Resiz;
            formOriginalSize = this.Size;
            recLab3 = new Rectangle(label3.Location, label3.Size);
            recTex6 = new Rectangle(guna2TextBox6.Location, guna2TextBox6.Size);
            recTex5 = new Rectangle(guna2TextBox5.Location, guna2TextBox5.Size);
            recTex2 = new Rectangle(guna2TextBox2.Location, guna2TextBox2.Size);
        }
        private void profile_Resiz(object sender, EventArgs e)
        {
            resize_Control(label3, recLab3);
            resize_Control(guna2TextBox6, recTex6);
            resize_Control(guna2TextBox5, recTex5);
            resize_Control(guna2TextBox2, recTex2);
        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

        }


    }
}
