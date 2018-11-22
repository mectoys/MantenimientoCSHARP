using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestionMantto
{



   public class DireccFacturacion
    {
        conexion conex = new conexion();
        recursos clase = new recursos();

        public void DireccionCliente(ComboBox direccion, ComboBox clientes, string Tipodire)
        {
            direccion.Items.Clear();
            direccion.Text = "";

            conex.ConectarSistema();
            string ConsultaDire = " select iddireccion,direccion from VTAS_CLIENTES_DIRE  where tipodirec = '" + Tipodire + "'" +
                        " AND empresa_id = '" + clase.tomacodempresa + "' AND idclie ='" + clientes.SelectedValue + "' ";
            ///Clieretencion
            SqlCommand CMDDIRE = new SqlCommand(ConsultaDire, conex.CON);
            CMDDIRE.CommandType = CommandType.Text;
            SqlDataReader RDR = null;
            RDR = CMDDIRE.ExecuteReader();

            if (RDR.HasRows == true)
            {
                while (RDR.Read())
                {
                    direccion.Items.Add(RDR["direccion"].ToString());
                }
            }

            CMDDIRE.Dispose();
            RDR.Close();
            conex.DesconectarSistema();

        }

        public void ClientesConTienda(ComboBox Clientes, ComboBox Ubicacion)
        {
            //MEOTODO QUE MUESTRA LAS TIENDAS O DIRECCIONES  DE SUCURSALES
            conex.ConectarSistema();

            string Consultacliequip = " select D.iddireccion,D.tienda from VTAS_CLIENTES_DIRE D " +
                                         " where D.empresa_id = " + clase.tomacodempresa + "  " +
                                         " AND D.idclie = '" + Clientes.SelectedValue + "' AND D.tipodirec = 'COM' order by D.tienda";

            SqlDataAdapter adap = new SqlDataAdapter(Consultacliequip, conex.CON);

            DataSet dset = new DataSet();
            adap.Fill(dset, "tienda");
            Ubicacion.DataSource = dset.Tables["tienda"];
            Ubicacion.DisplayMember = "tienda";
            Ubicacion.ValueMember = "iddireccion";
            adap.Dispose();
            dset.Dispose();

            conex.DesconectarSistema();


        }
    }
}
