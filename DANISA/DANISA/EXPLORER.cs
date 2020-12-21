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
    public partial class EXPLORER : Form
    {
        public EXPLORER()
        {
            InitializeComponent();
        }

        private void BtnPintura_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "D:/DANISA/FORD/FORD_EXPLORER/Capas_Finales/" + cboPintura.Text + ".png";
        }

        private void BtnLuces_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "D:/DANISA/FORD/FORD_EXPLORER/Capas_Finales/" + cboLuces.Text + ".png";
        }

        private void BtnPolarizado_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "D:/DANISA/FORD/FORD_EXPLORER/Capas_Finales/" + cboPolarizado.Text + ".png";
        }

        private void BtnColorRines_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "D:/DANISA/FORD/FORD_EXPLORER/Capas_Finales/" + cboColorRines.Text + ".png";
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
    }
}
