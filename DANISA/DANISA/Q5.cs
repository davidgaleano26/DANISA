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
    public partial class Q5 : Form
    {
        public Q5()
        {
            InitializeComponent();
        }

        private void BtnPintura_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "D:/DANISA/AUDI/Q5/" + cboPintura.Text + ".png";
        }

        private void BtnPolarizado_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "D:/DANISA/AUDI/Q5/" + cboPolarizado.Text + ".png";
        }

        private void BtnLuces_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "D:/DANISA/AUDI/Q5/" + cboLuces.Text + ".png";
        }

        private void BtnExploradoras_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "D:/DANISA/AUDI/Q5/" + cboExploradoras.Text + ".png";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            VistaFinal vf = new VistaFinal();



            vf.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Marcas marc = new Marcas();
            marc.Show();
            this.Hide();
        }

        private void cboPintura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
