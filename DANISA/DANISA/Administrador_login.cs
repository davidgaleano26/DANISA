using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace DANISA
{
    public partial class Administrador_login : Form
    {
        public Administrador_login()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                string envio = string.Format("Select * from USUARIO where Id_Usuario = '{0}' and Contraseña = '{1}'", txtUsuario.Text.Trim(), txtContraseña.Text.Trim());
                DANISADataSet ej = Utilidades.ejecutar(envio);
                string cuenta = ej.Tables[2].Rows[0]["Id_Usuario"].ToString().Trim();
                string clave = ej.Tables[2].Rows[0]["Contraseña"].ToString().Trim();
                if (cuenta == txtUsuario.Text.Trim() && clave == txtContraseña.Text.Trim())
                {
                    MessageBox.Show("Ingreso correcto");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error en la conexion" + error);
            }
        }

        private void Administrador_login_Load(object sender, EventArgs e)
        {

        }
    }
}
