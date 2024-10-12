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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ROOT secondForm = new ROOT();

            // Открываем новую форму
            secondForm.Show();

            // Закрываем текущую форму, но приложение продолжает работать
            this.Hide(); // Вместо Close, используем Hide, чтобы не завершить приложение
        }

        // Массив пользователей, где каждый элемент содержит логин, пароль и роль (admin/user)
        Dictionary<string, (string Password, string Role)> users = new Dictionary<string, (string Password, string Role)>
{
    { "admin", ("adminpass", "admin") },
    { "user", ("userpass", "user") }
};

    }
}
