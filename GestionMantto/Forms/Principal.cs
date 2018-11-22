using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace GestionMantto.Forms
{
    public partial class Principal : Form
    {
        recursos clase = new recursos();
        conexion conec = new conexion();
        recursos users = new recursos();
        Accesos access = new Accesos();
        public Principal()
        {
            InitializeComponent();
        }

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var TuplaAcceso = access.AccesoOpcion(clase.tomacoduser,12, 26, 4);

            if (TuplaAcceso.Item1 == false)
            {
                MessageBox.Show(TuplaAcceso.Item2, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }

            Forms.ADM_Equipo equipo = new ADM_Equipo();
            equipo.MdiParent = this;
            equipo.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.Text = "Principal: " + clase.tomanombrempresa;

            barra.Items[0].Text = users.tomacoduser;

            //OBTENER porcent retencion
            conec.ConectarSistema();
            SqlCommand CMDReten = new SqlCommand("SELECT porcentreten FROM   ADMI_PORCENTRETENER", conec.CON);
            CMDReten.CommandType = CommandType.Text;
            SqlDataReader RDRReten = null;
            RDRReten = CMDReten.ExecuteReader();
            RDRReten.Read();

            if (RDRReten.HasRows == true)
            {
                clase.RetencionPorcent = Convert.ToDecimal(RDRReten["porcentreten"]) / 100;
            }
            RDRReten.Close();
            CMDReten.Dispose();
            conec.DesconectarSistema();

            //OBTENER PARAISOFISCAL
            conec.ConectarSistema();
            SqlCommand CMDParaiso = new SqlCommand("select paraisofiscal from  RRHH_EMPRESA where empresa_id ='" + clase.tomacodempresa + "'", conec.CON);
            CMDParaiso.CommandType = CommandType.Text;
            SqlDataReader RDRParaiso = null;
            RDRParaiso = CMDParaiso.ExecuteReader();
            RDRParaiso.Read();

            if (RDRParaiso.HasRows == true)
            {
                clase.ParaisoFiscal = Convert.ToBoolean(RDRParaiso["paraisofiscal"]);
            }
            RDRParaiso.Close();
            CMDParaiso.Dispose();
            conec.DesconectarSistema();

            //OBTENER IGV
            conec.ConectarSistema();
            SqlCommand CMD = new SqlCommand("select igv from ADMI_IGV  where defecto=1", conec.CON);
            CMD.CommandType = CommandType.Text;
            SqlDataReader RDR = null;
            RDR = CMD.ExecuteReader();
            RDR.Read();

            if (RDR.HasRows == true)
            {
                clase.Igv = Convert.ToDecimal(RDR["igv"]);
            }
            RDR.Close();
            CMD.Dispose();


            //mostrar el tipo de cambio
            SqlCommand CMDTC = new SqlCommand("SELECT compra,venta FROM ADMI_TIPOCAMBIO where idmone='DOL' AND fecha=cast( getdate()as date)", conec.CON);
            SqlDataReader RDRTC = null;
            RDRTC = CMDTC.ExecuteReader();
            RDRTC.Read();
            clase.Compra = Convert.ToDecimal(RDRTC["compra"]);
            clase.Venta = Convert.ToDecimal(RDRTC["venta"]);
            RDRTC.Close();
            CMDTC.Dispose();

            ToolStripItem subItem = toolStrip1.Items[4];
            subItem.Text = "Compra: " + clase.Compra + " Venta: " + clase.Venta;

            //actualizar los periodos
            SqlCommand CMDCLOSEPER = new SqlCommand("ADMI_ACTUALIZAR_PERIODOS", conec.CON);
            CMDCLOSEPER.CommandType = CommandType.StoredProcedure;
            CMDCLOSEPER.Parameters.Add("@empresa_id", SqlDbType.NVarChar, 3).Value = clase.tomacodempresa;
            CMDCLOSEPER.ExecuteNonQuery();
            CMDCLOSEPER.Dispose();

            conec.DesconectarSistema();

        }

        private void clienteConEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var TuplaAcceso = access.AccesoOpcion(clase.tomacoduser, 12, 27, 4);

            if (TuplaAcceso.Item1 == false)
            {
                MessageBox.Show(TuplaAcceso.Item2, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }

            Man_ClientEquip cliequi = new Man_ClientEquip();
            cliequi.MdiParent = this;
            cliequi.Show();

        }

        private void informaciónEquiposEnTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var TuplaAcceso = access.AccesoOpcion(clase.tomacoduser, 12, 28, 4);

            if (TuplaAcceso.Item1 == false)
            {
                MessageBox.Show(TuplaAcceso.Item2, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }

            MAN_InfoEquip infoequi = new MAN_InfoEquip();
            infoequi.MdiParent = this;
            infoequi.Show();

        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void generarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PRO_Incidencia incidencia = new PRO_Incidencia();
            incidencia.MdiParent = this;
            incidencia.Show();


        }

        private void requerimientosMensualesDeEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CON_Graficos Grafics = new CON_Graficos();

            Grafics.MdiParent = this;
            Grafics.Show();

        }

        private void exploradorDeEquiposEnTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CON_ExplorarEquipo Explorar = new CON_ExplorarEquipo();
            Explorar.MdiParent = this;
            Explorar.Show();

        }

        private void generarOrdenDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Asignación Acceso para ver si esta permito o no Consultar Por su Login
            access.VarAccesoXsuLogin = access.AccesoConsultaXsuLogin(clase.tomacoduser, 2, 29, 1);


            PRO_Orden_Trabajo OT = new PRO_Orden_Trabajo();
            OT.MdiParent = this;
            OT.Show();
        }
    }
}
