using System;
using System.Data;
using System.Data.SqlClient;

namespace GestionMantto
{
    public class Accesos
    {

        private string QueryAcceso, MensajeAcceso;
        private bool Acceso = false;
        conexion conex = new conexion();
        recursos clase = new recursos();

        public Tuple<bool, string> AccesoOpcion(string CODUSUA, int IDMAINMENU, int IDMENU, int idsistema)
        {
            conex.ConectarSistema();

            QueryAcceso = "select U.idacceso,U.co_usua,UMAIN.idsupermenu,UMAIN.DESCRIPCION AS [MAIN MENU]," +
                            "  u.idmenu, MENU.descripcion, U.acceso" +
                            " from USUARIOS_ACCESO U" +
                            " INNER JOIN USUARIOS_MENU MENU ON MENU.idmenu = u.idmenu " +
                            " iNNER JOIN USUARIOS_MENUMAIN UMAIN ON UMAIN.idsupermenu = Menu.idsupermenu " +
                            " WHERE U.co_usua = '" + CODUSUA + "' and UMAIN.idsupermenu = " + IDMAINMENU + " " +
                            " AND U.empresa_id ='" + clase.tomacodempresa + "' AND" +
                            " U.idmenu = " + IDMENU + " AND MENU.idsistema =" + idsistema;

            SqlCommand CMDACCESO = new SqlCommand(QueryAcceso, conex.CON);
            CMDACCESO.CommandType = CommandType.Text;
            //CMDACCESO.Parameters.Add

            SqlDataReader RDRACCESO = null;
            RDRACCESO = CMDACCESO.ExecuteReader();
            RDRACCESO.Read();
            if (RDRACCESO.HasRows)
            {
                bool BoolAccess = Convert.ToBoolean(RDRACCESO["acceso"]);

                if (BoolAccess == false)
                {
                    MensajeAcceso = "Acceso no permitido.";
                    Acceso = Convert.ToBoolean(RDRACCESO["acceso"]);
                }
                else
                {
                    Acceso = true;
                }
            }
            else
            {
                MensajeAcceso = "Acceso no permitido.";
                Acceso = false;
            }

            RDRACCESO.Close();
            CMDACCESO.Dispose();
            conex.DesconectarSistema();

            return new Tuple<bool, string>(Acceso, MensajeAcceso);
        }

    }
}
