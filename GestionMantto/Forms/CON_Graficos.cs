using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace GestionMantto.Forms
{
    public partial class CON_Graficos : Form
    {

        conexion conex = new conexion();
        recursos clase = new recursos();
        DireccFacturacion Ubicacion = new DireccFacturacion();
        public CON_Graficos()
        {
            InitializeComponent();
        }

        private void CON_Graficos_Load(object sender, EventArgs e)
        {
            //cargar clientes
            clase.DamequeryGeneral("select  idclie ,razonsoc as descripcion  from VTAS_CLIENTES where empresa_id =" + clase.tomacodempresa + " and estado='ACT'");
            clientes.DataSource = AutoCompleClass.Datos();
            clientes.DisplayMember = "descripcion";
            clientes.ValueMember = "idclie";
            clientes.AutoCompleteCustomSource = AutoCompleClass.Autocomplete();
            clientes.AutoCompleteMode = AutoCompleteMode.Suggest;
            clientes.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void ubicacion_SelectionChangeCommitted(object sender, EventArgs e)
        {
          
        }

        private void clientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Ubicacion.ClientesConTienda(clientes, Tienda);
        }
    }
}
