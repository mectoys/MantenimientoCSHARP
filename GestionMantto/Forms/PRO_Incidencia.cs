using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace GestionMantto.Forms
{
    public partial class PRO_Incidencia : Form
    {
        conexion conex = new conexion();
        recursos clase = new recursos();
        Periodo periodo = new Periodo();

        public PRO_Incidencia()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, EventArgs e)
        {

        }

        private void PRO_Incidencia_Load(object sender, EventArgs e)
        {

        }
        private void CargarClientes()
        {
            //cargar clientes
            clase.DamequeryGeneral("select  idclie ,razonsoc +' ' + idclie as descripcion  from VTAS_CLIENTES where empresa_id =" + clase.tomacodempresa + " and estado='ACT' order by razonsoc");
            cliente.DataSource = AutoCompleClass.Datos();
            cliente.DisplayMember = "descripcion";
            cliente.ValueMember = "idclie";
            cliente.AutoCompleteCustomSource = AutoCompleClass.Autocomplete();
            cliente.AutoCompleteMode = AutoCompleteMode.Suggest;
            cliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void anular_Click(object sender, EventArgs e)
        {

        }
    }
}
