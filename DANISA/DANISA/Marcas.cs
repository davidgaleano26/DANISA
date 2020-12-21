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
    public partial class Marcas : Form
    {
        
        
        public Marcas()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            VistaPrevia vistaprev = new VistaPrevia();
            vistaprev.Show();
            this.Close();

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Marcas_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Q5 q = new Q5();
            q.Show();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            EXPLORER exp = new EXPLORER();
            exp.Show();
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            CAMARO ca = new CAMARO();
            ca.Show();
            this.Close();
        }
    }
}
