using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using GestionMantto;

namespace GestionMantto.Forms
{
    public partial class Man_ClientEquip : Form
    {
        conexion conex = new conexion();
        recursos clase = new recursos();
        DireccFacturacion Ubicacion = new DireccFacturacion();

        public Man_ClientEquip()
        {
            InitializeComponent();
        }

        private void Man_ClientEquip_Load(object sender, EventArgs e)
        {
            conex.ConectarSistema();

            //tipo de equipos
            /*
            SqlDataAdapter Adaptip = new SqlDataAdapter("select idcatequipo,descripcion from  ADMI_EQUIPOS_CATEGORIA", conex.CON);

            DataSet dsetip = new DataSet();
            Adaptip.Fill(dsetip, "tipoequipo");
            tipocat.DataSource = dsetip.Tables["tipoequipo"];
            tipocat.DisplayMember = "descripcion";
            tipocat.ValueMember = "idcatequipo";
            Adaptip.Dispose();
            dsetip.Dispose();

    */
            string QueryEquip = "SELECT E.idequipo,AEC.descripcion AS Tipo,E.descripcion " +
                                " from ADMI_EQUIPOS E " +
                                " INNER JOIN ADMI_EQUIPOS_CATEGORIA AEC ON AEC.idcatequipo = E.idcatequipo " +
                                " WHERE E.empresa_id='" + clase.tomacodempresa + "'" +
                                " ORDER BY AEC.descripcion ,E.descripcion";

            SqlDataAdapter AdapEqui = new SqlDataAdapter(QueryEquip, conex.CON);

            DataSet DsetEqui =new DataSet();
            AdapEqui.Fill(DsetEqui, "Equipo");
            if (DsetEqui.Tables.Count!=0)
            {
                SinTiendaEquipo.DataSource = DsetEqui;
                SinTiendaEquipo.DataMember = "Equipo";
            }

            DsetEqui.Dispose();
            AdapEqui.Dispose();
            conex.DesconectarSistema();
            SinTiendaEquipo.Columns[0].Visible = false;
            //auto resize
            SinTiendaEquipo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            //cargar clientes
            clase.DamequeryGeneral("select  idclie ,razonsoc +' ' + idclie as descripcion  from VTAS_CLIENTES where empresa_id =" + clase.tomacodempresa + " and estado='ACT' order by razonsoc");
            clientes.DataSource = AutoCompleClass.Datos();
            clientes.DisplayMember = "descripcion";
            clientes.ValueMember = "idclie";
            clientes.AutoCompleteCustomSource = AutoCompleClass.Autocomplete();
            clientes.AutoCompleteMode = AutoCompleteMode.Suggest;
            clientes.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void RelacionInsertarTiendasConEquipo( int idequipo)
        {
            conex.ConectarSistema();
            string InsertarConEquipo = "INSERT INTO VTAS_CLIENTES_EQUIPOS " +
                                    " (idclie,idequipo,iddireccion,user_modi,fe_modi,empresa_id)" +
                                    " VALUES('" + clientes.SelectedValue + "'," + idequipo + "," +
                                    " "+ Tienda.SelectedValue + ",'" + clase.tomacoduser + "',GETDATE(),'" + clase.tomacodempresa + "' )";

            SqlCommand CMDInsert = new SqlCommand(InsertarConEquipo, conex.CON);
            CMDInsert.CommandType = CommandType.Text;
            CMDInsert.ExecuteNonQuery();
            conex.DesconectarSistema();

        }


        private void RelacionEliminarTiendasConEquipo(int idclientequi)
        {
            conex.ConectarSistema();
            string BorrarConEquipo = "delete from VTAS_CLIENTES_EQUIPOS where idclientequi=" + idclientequi;

            SqlCommand CMDInsert = new SqlCommand(BorrarConEquipo, conex.CON);
            CMDInsert.CommandType = CommandType.Text;
            CMDInsert.ExecuteNonQuery();
            conex.DesconectarSistema();

        }

        private void RelacionTiendasConEquipo()
        {
            string ConsultaConEquipo = "select VCE.idclientequi,AEC.descripcion AS Tipo,ROW_NUMBER()OVER(PARTITION BY E.idequipo , E.descripcion ORDER BY  E.descripcion) AS ORDEN "+ 
                                       ", E.descripcion AS Equipo from VTAS_CLIENTES_EQUIPOS VCE " +
                                       "INNER JOIN ADMI_EQUIPOS E ON E.idequipo = VCE.idequipo AND E.empresa_id = VCE.empresa_id "+
                                       " INNER JOIN ADMI_EQUIPOS_CATEGORIA AEC ON AEC.idcatequipo = E.idcatequipo " +
                                       " WHERE VCE.empresa_id ='" + clase.tomacodempresa + "' and VCE.idclie =  '" + clientes.SelectedValue + "'" +
                                       " AND  VCE.iddireccion ="+ Tienda.SelectedValue  + "  ORDER BY E.descripcion";

            conex.ConectarSistema();
            SqlDataAdapter AdapEquip = new SqlDataAdapter(ConsultaConEquipo, conex.CON);
            DataSet Dset = new DataSet();
            AdapEquip.Fill(Dset, "ConEquipo");
            ConTiendaEquipo.DataSource = Dset;
            ConTiendaEquipo.DataMember = "ConEquipo";
            ConTiendaEquipo.Columns["idclientequi"].Visible = false;
            Dset.Dispose();
            AdapEquip.Dispose();
            conex.DesconectarSistema();
            //auto resize
            ConTiendaEquipo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void clientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //RelacionTiendasSinEquipo();
            //  RelacionTiendasConEquipo();
            Ubicacion.ClientesConTienda(clientes, Tienda);


        }

        private void add2_Click(object sender, EventArgs e)
        {
            for (int i = SinTiendaEquipo.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewCheckBoxCell chk = SinTiendaEquipo.Rows[i].Cells[1] as DataGridViewCheckBoxCell;

                if (SinTiendaEquipo[1, i].Selected == true)
                {
                    RelacionInsertarTiendasConEquipo(Convert.ToInt16(SinTiendaEquipo[0, i].Value.ToString()));

                }
            }
   
            RelacionTiendasConEquipo();
        }

        private void add4_Click(object sender, EventArgs e)
        {
            for (int i = ConTiendaEquipo.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewCheckBoxCell chk = ConTiendaEquipo.Rows[i].Cells[1] as DataGridViewCheckBoxCell;

                if (ConTiendaEquipo[1, i].Selected == true)
                {
                    RelacionEliminarTiendasConEquipo(Convert.ToInt16(ConTiendaEquipo[0, i].Value.ToString()));

                }

            }

            //RelacionTiendasSinEquipo();
            RelacionTiendasConEquipo();
        }

        private void equipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
      
        }

        private void tipocat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
           
            
        }

        private void Tienda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RelacionTiendasConEquipo();

        }

        private void Tienda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
