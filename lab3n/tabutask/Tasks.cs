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
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
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
            guna2Panel1_conteiner.Controls.Add(fm);
            guna2Panel1_conteiner.Tag = fm;
            fm.Show();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            container(new Tasks_obnovit_());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            container(new Tasks_Vocheredi());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            container(new Tasks_Complate());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            container(new Tasks_Create());
        }
    }
}
