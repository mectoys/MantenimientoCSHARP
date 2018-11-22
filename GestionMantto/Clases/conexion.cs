using System.Data.SqlClient;


namespace GestionMantto
{
    public class conexion
    {
        public SqlConnection CON = null;
        public SqlDataReader RDR = null;
        string connectionstring;
        public string CadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
        public void ConectarSistema()
        {
            connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
            CON = new SqlConnection(connectionstring);
            CON.Open();


        }
        public void DesconectarSistema()
        {
            CON.Close();
        }
    }
}
