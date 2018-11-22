
namespace GestionMantto.Forms
{

    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Windows.Forms;


    public partial class PRO_Orden_Trabajo : Form
    {

        conexion conex = new conexion();
        recursos clase = new recursos();

         

        public PRO_Orden_Trabajo()
        {
            InitializeComponent();
        }

        private void PRO_Orden_Trabajo_Load(object sender, EventArgs e)
        {
            conex.ConectarSistema();


            #region PRIORIDAD
            SqlDataAdapter Adap = new SqlDataAdapter("select IdPrioridad,descripcion from ADMI_PRIORIDAD_OT", conex.CON);

            DataSet dset = new DataSet();
            Adap.Fill(dset, "PRIORIDAD");
            Prioridad.DataSource = dset.Tables["PRIORIDAD"];
            Prioridad.DisplayMember = "descripcion";
            Prioridad.ValueMember = "IdPrioridad";
            Adap.Dispose();
            dset.Dispose();
            #endregion


            #region TIPORODEN
            SqlDataAdapter Adaporden = new SqlDataAdapter("select IdPrioridad,descripcion from ADMI_PRIORIDAD_OT", conex.CON);

            DataSet dsetorden = new DataSet();
            Adaporden.Fill(dsetorden, "PRIORIDAD");
            Prioridad.DataSource = dset.Tables["PRIORIDAD"];
            Prioridad.DisplayMember = "descripcion";
            Prioridad.ValueMember = "IdPrioridad";
            Adaporden.Dispose();
            dsetorden.Dispose();
            #endregion

            conex.DesconectarSistema();
        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            PRO_Orden_Trabajo_reque requerimientos = new PRO_Orden_Trabajo_reque();
            requerimientos.ShowDialog();


        }
     
    }
}
