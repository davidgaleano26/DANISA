using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DANISA
{
    public partial class AdminUser : Form
    {
        public AdminUser()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        Inicio ini = new Inicio();
            ini.Show();
            this.Hide();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            Administrador_login admin = new Administrador_login();
            admin.Show();
            this.Close();
        }
    }
}
