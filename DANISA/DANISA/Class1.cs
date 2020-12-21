using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DANISA
{
    public class Utilidades
    {
        public static DANISADataSet ejecutar (String dato)
        {
            SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=DANISA;User ID=sa;Password=1234");
            conexion.Open();
            DANISADataSet ds = new DANISADataSet();
            SqlDataAdapter dp = new SqlDataAdapter(dato, conexion);
            dp.Fill(ds.USUARIO);
            conexion.Close();
            return ds;
        }
    }
}
