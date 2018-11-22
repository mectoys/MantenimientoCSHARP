using System;
using System.Data;
using System.Data.SqlClient;

namespace GestionMantto
{
    public class Periodo
    {
        conexion conex = new conexion();
        recursos clase = new recursos();

        public Tuple<int, string> IndicarEstadoPeriodo(DateTime Fecha)
        {
            int EstadoPeriodo = 0;
            string MensajePeriodo = "";
            bool Exonerado;


            conex.ConectarSistema();

            string ConsultaExonerado = "select CO_USUA from ADMI_PERIODO_EXOUSER " +
                " WHERE CO_USUA ='" + clase.tomacoduser + "' AND EMPRESA_ID ='" + clase.tomacodempresa + "'";

            SqlCommand CMDEXOPERI = new SqlCommand(ConsultaExonerado, conex.CON);
            CMDEXOPERI.CommandType = CommandType.Text;
            SqlDataReader RDREXOPERI = null;
            RDREXOPERI = CMDEXOPERI.ExecuteReader();
            RDREXOPERI.Read();

            if (RDREXOPERI.HasRows == true)
            {
                Exonerado = true;
            }
            else
            {
                Exonerado = false;
            }
            RDREXOPERI.Close();
            CMDEXOPERI.Dispose();

            //COMPROBAR SI EXISTE USUARIO EXONERADO PARA EVITAR 
            if (Exonerado == false)
            {
                #region VerificarEstadoPeridodo
                //VERIFICAR ESTADO PERIODO

                string Seleccion = "SELECT cerrado, CASE  WHEN cerrado =0 THEN 'Periodo Clausurado' ELSE  'Periodo Aperturado' END ESTADO FROM admi_PERIODOS " +
                               " where mes = " + Convert.ToInt32(Fecha.ToShortDateString().Split('/')[1]) + " " +
                                         " and ANIO = " + Fecha.ToShortDateString().Split('/')[2] + " AND EMPRESA_ID =" + clase.tomacodempresa;


                SqlCommand CMDPERIODO = new SqlCommand(Seleccion, conex.CON);
                CMDPERIODO.CommandType = CommandType.Text;
                CMDPERIODO.ExecuteNonQuery();
                SqlDataReader RDRPERIODO = null;
                RDRPERIODO = CMDPERIODO.ExecuteReader();
                RDRPERIODO.Read();
                if (RDRPERIODO.HasRows == true)
                {

                    if (RDRPERIODO["cerrado"].ToString() == "0")
                    {
                        MensajePeriodo = RDRPERIODO["ESTADO"].ToString();
                        EstadoPeriodo = 1;
                        RDRPERIODO.Close();
                        CMDPERIODO.Dispose();
                        conex.DesconectarSistema();
                    }
                }
                else
                {
                    EstadoPeriodo = 1;
                    MensajePeriodo = "Periodo no Existe";
                    RDRPERIODO.Close();
                    CMDPERIODO.Dispose();
                    conex.DesconectarSistema();
                }

                RDRPERIODO.Close();
                CMDPERIODO.Dispose();
                conex.DesconectarSistema();
                #endregion
            }
            else
            {
                EstadoPeriodo = 0;
            }

            return new Tuple<int, string>(EstadoPeriodo, MensajePeriodo);
        }


    }
}