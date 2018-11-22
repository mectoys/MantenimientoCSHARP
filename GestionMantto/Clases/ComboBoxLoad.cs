using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestionMantto
{
    public class ComboBoxLoad
    {
        conexion conex = new conexion();
        recursos clase = new recursos();

        public void ComboxSerie(ComboBox serie, string tipodocument, Label correlativo, string Tipo)
        {

            //serie documento de venta
            conex.ConectarSistema();
            SqlDataAdapter Adap = new SqlDataAdapter("select serie from ADMI_CORRELATIVO_SUNAT where empresa_id =" + clase.tomacodempresa + " and " + Tipo + "=1 and  " +
                " tipodoc='" + tipodocument + "'", conex.CON);

            DataSet dset = new DataSet();
            Adap.Fill(dset, "tserie");
            serie.DataSource = dset.Tables["tserie"];
            serie.DisplayMember = "serie";
            serie.ValueMember = "serie";
            Adap.Dispose();
            dset.Dispose();
            conex.DesconectarSistema();
            serie.Text = "";
            correlativo.Text = "";

        }

        public void ComboxCorrelativo(Label correlativo, ComboBox tipodocu, ComboBox serie, string Tipo)
        {

            //NUMERO documento de venta
            conex.ConectarSistema();
            SqlCommand cmd = new SqlCommand("select correlativo + 1 as correlativo  from ADMI_CORRELATIVO_SUNAT where empresa_id =" + clase.tomacodempresa + " and " + Tipo + "= 1 and  " +
                 " tipodoc='" + tipodocu.SelectedValue + "' AND serie = '" + serie.SelectedValue + "'", conex.CON);
            cmd.CommandType = CommandType.Text;
            SqlDataReader RDR = null;
            RDR = cmd.ExecuteReader();

            while (RDR.Read())
            {
                correlativo.Text = RDR["correlativo"].ToString();
            }
            RDR.Close();
            cmd.Dispose();
            conex.DesconectarSistema();


        }



    }


}
