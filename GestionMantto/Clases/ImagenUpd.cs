using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace GestionMantto
{


    public class ImagenUpd
    {
        conexion conex = new conexion();
        recursos clase = new recursos();
        string SqlImagenes;
        SqlCommand CMDUpdImagen;

        public void ActualizarImagenes(string tabla, string Ruta, string campo1, string variable, int VarFoto, TextBox text1,Label label1)
        {
            if (VarFoto == 1)
            {
                //IMAGEN 
                Image imgA;
                if (Ruta != null)
                {
                    imgA = Image.FromFile(Ruta);
                }
                else
                {
                    imgA = Properties.Resources.no_imagen;
                }
                MemoryStream msA = new MemoryStream();
                imgA.Save(msA, imgA.RawFormat);

                conex.ConectarSistema();

                //actualizar las imagenes
                switch (tabla)
                {
                    //TABLA EQUIPOS
                    case "ADMI_EQUIPOS":

                        SqlImagenes = "UPDATE " + tabla + " SET " + campo1 + "=@" + variable + "  " +
                                   " WHERE idequipo = @idequipo and empresa_id = @empresa_id";
                        CMDUpdImagen = new SqlCommand(SqlImagenes, conex.CON);
                        CMDUpdImagen.Parameters.Add("@imagen", SqlDbType.Image).Value = msA.ToArray();
                        CMDUpdImagen.Parameters.Add("@idequipo", SqlDbType.Int).Value = text1.Text;
                        CMDUpdImagen.Parameters.Add("@empresa_id", SqlDbType.NVarChar, 4).Value = clase.tomacodempresa;
                        CMDUpdImagen.CommandType = CommandType.Text;
                        CMDUpdImagen.ExecuteNonQuery();

                        break;
                    //TABLA RELACION CLIENTE -EQUIPO-TIENDA
                    case "VTAS_CLIENTES_EQUIPOS":

                        SqlImagenes = "UPDATE " + tabla + " SET " + campo1 + "=@" + variable + "  " +
                                   "where idclientequi = @idclientequi";
                        CMDUpdImagen = new SqlCommand(SqlImagenes, conex.CON);
                        CMDUpdImagen.Parameters.Add("@imagen", SqlDbType.Image).Value = msA.ToArray();
                        CMDUpdImagen.Parameters.Add("@idclientequi", SqlDbType.Int).Value = label1.Text;
                        CMDUpdImagen.CommandType = CommandType.Text;
                        CMDUpdImagen.ExecuteNonQuery();

                        break;

                    //TABLA EMPRESA
                    case "RRHH_EMPRESA":

                        SqlImagenes = "UPDATE " + tabla + " SET " + campo1 + "=@" + variable + "  " +
                                   "where empresa_id = @empresa_id";
                        CMDUpdImagen = new SqlCommand(SqlImagenes, conex.CON);
                        CMDUpdImagen.Parameters.Add("@imagen", SqlDbType.Image).Value = msA.ToArray();
                        CMDUpdImagen.Parameters.Add("@empresa_id", SqlDbType.NVarChar,4).Value = label1.Text;
                        CMDUpdImagen.CommandType = CommandType.Text;
                        CMDUpdImagen.ExecuteNonQuery();

                        break;
                }


                conex.DesconectarSistema();
            }

        }
    }
}
