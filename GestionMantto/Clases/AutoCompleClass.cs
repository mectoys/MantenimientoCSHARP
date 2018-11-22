using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestionMantto
{
    public static class AutoCompleClass
    {


        //metodo para cargar los datos de la bd
        public static DataTable Datos()
        {
            DataTable dt = new DataTable();
            recursos clase = new recursos();
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["connection_string"].ToString());//cadena conexion

            // string consulta = "select  CAST(idproducto AS NVARCHAR(4)) as idproducto ,descripcion FROM ADMI_PRODUCTO WHERE empresa_id='" + clase.tomacodempresa + "' AND ESTADO ='ACT' "; //consulta a la tabla paises
            SqlCommand comando = new SqlCommand(clase.tomaqueryGeneral, conexion);

            SqlDataAdapter adap = new SqlDataAdapter(comando);

            adap.Fill(dt);
            return dt;
        }

        //metodo para cargar la coleccion de datos para el autocomplete
        public static AutoCompleteStringCollection Autocomplete()
        {
            DataTable dt = Datos();

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["descripcion"]));
            }

            return coleccion;
        }
    }
}
