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
    public partial class ROOT : Form
    {
        private Size formOriginalSize;
        private Rectangle recLab2;
        private Rectangle recLab1;
        private Rectangle recPic1;
        private Rectangle recBut1;
        private Rectangle recBut2;
        private Rectangle recBut3;
        private Rectangle recBut4;
        private Rectangle recBut5;
        public ROOT()
        {
            InitializeComponent();
            this.Resize += ROOT_Resiz;
            formOriginalSize = this.Size;
            recPic1 = new Rectangle(guna2PictureBox1.Location, guna2PictureBox1.Size);
            recLab2 = new Rectangle(label2.Location, label2.Size);
            recLab1 = new Rectangle(label1.Location, label1.Size);
            recBut1 = new Rectangle(guna2Button1.Location, guna2Button1.Size);
            recBut2 = new Rectangle(guna2Button2.Location, guna2Button2.Size);
            recBut3 = new Rectangle(guna2Button3.Location, guna2Button3.Size);
            recBut4 = new Rectangle(guna2Button4.Location, guna2Button4.Size);
            recBut5 = new Rectangle(guna2Button5.Location, guna2Button5.Size);
        }
        private void ROOT_Resiz(object sender, EventArgs e)
        {
            resize_Control(guna2PictureBox1, recPic1);
            resize_Control(label2, recLab2);
            resize_Control(label1, recLab1);
            resize_Control(guna2Button1, recBut1);
            resize_Control(guna2Button2, recBut2);
            resize_Control(guna2Button3, recBut3);
            resize_Control(guna2Button4, recBut4);
            resize_Control(guna2Button5, recBut5);
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

        private void ROOT_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            container(new Profile());
        }
        
        private void container(object _form)
        {
            if (guna2Panel1_conteiner.Controls.Count > 0) guna2Panel1_conteiner.Controls.Clear(); ;
            
            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            guna2Panel1_conteiner.Controls.Add( fm );
            guna2Panel1_conteiner.Tag = fm;
            fm.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            container(new Tasks());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            container(new Notes());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            container(new Reports());
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Authorization SecondForm = new Authorization();
            SecondForm.Show();
            Close();
        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
