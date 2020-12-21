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
    public partial class VistaPrevia : Form
    {
        public VistaPrevia()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            VistaFinal vf = new VistaFinal();



            vf.Show();
            this.Hide();
        }

        private void VistaPrevia_Load(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:/Users/User/Documents/DANISA/AUDI/A3/" + cboPintura.Text + ".png";
            
        }

        private void CboPintura_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnPolarizado_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:/Users/User/Documents/DANISA/AUDI/A3/" + cboPolarizado.Text + ".png";
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BtnExploradora_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:/Users/User/Documents/DANISA/AUDI/A3/" + cboExploradoras.Text + ".png";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Marcas marc = new Marcas();
            marc.Show();
            this.Hide();
        }
    }
}
