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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 1;
                label2.Text = "Cargando el Sistema al " + progressBar1.Value + "%";
            }
            else
            {
                timer1.Enabled = false;
                MessageBox.Show("Carga completa");

                AdminUser admu = new AdminUser();
                

                
                admu.Show();
                this.Hide();

            }

            
            
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
