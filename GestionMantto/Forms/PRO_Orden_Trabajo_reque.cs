 

namespace GestionMantto.Forms
{

    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Windows.Forms;


    public partial class PRO_Orden_Trabajo_reque : Form
    {

        conexion conex = new conexion();
        recursos clase = new recursos();

        string CadenasConsulta, SubCadena;

        //Variable de acceso consulta por su login de cada formulario
        bool AccesoXsuLoginPro_RendirGastos;
        //variable donde almacena el usuario que solo vera sus datos consultados
        string AccesoXsuLoginConsultaUser;

        public PRO_Orden_Trabajo_reque()
        {
            InitializeComponent();
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            FichaConsultaGastos(2);
        }

        private void PRO_Orden_Trabajo_reque_Load(object sender, EventArgs e)
        {

        }

        private void FichaConsultaGastos(int Tipo)
        {
            //detalleconsulta.Rows.Clear();
            switch (Tipo)
            {
                //fecha de hoy
                case 1:

                    CadenasConsulta = " and cast( R.fecha as date)= cast((select getdate()) as date) ";
                    break;
                //entre fechas
                case 2:

                    CadenasConsulta = "  AND cast(R.fecha as date)between '" + desde.Value.Date.ToShortDateString() + "'" +
                                      "and '" + Hasta.Value.Date.ToShortDateString() + "' ";

                    break;
                //por ruc o nro doc
                case 3:

                    /*
                    switch (campos.SelectedIndex)
                    {
                        case 0:
                            SubCadena = " and R.idrendir ='" + datos.Text + "'";
                            break;
                        case 1:
                            SubCadena = "and R.idclie='" + datos.Text + "'";
                            break;
                        case 2:
                            SubCadena = "and R.idrendir='" + datos.Text + "'";
                            break;
                        case 3:
                            SubCadena = "and  DIR.tienda like '%" + datos.Text + "%'";
                            break;
                    }
                    */
                    //  LIKE '%" + datos.Text + "%'"+
                  //  CadenasConsulta = SubCadena;
                    break;

            }

            if (AccesoXsuLoginPro_RendirGastos == true)
            {
                AccesoXsuLoginConsultaUser = " AND R.user_crea='" + clase.tomacoduser + "'";

            }
            else
            {
                AccesoXsuLoginConsultaUser = "";
            }

            string ConsultaCABECERA = "select R.idrendir,R.fecha,C.idclie, C.razonsoc,DIR.direccion,R.tipofac,TF.descripcion as TipoFacturacion," +
                                     " R.iddireccion,DIR.tienda,DIR.encargado,R.idconstancia, R.observacion,R.estado ,R.moneda, " +
                                     " R.user_crea, R.fe_crea, R.user_modi, R.fe_modi from VTAS_RENDICION_GASTOS R" +
                                     " INNER JOIN VTAS_CLIENTES C ON C.idclie = R.idclie AND C.empresa_id = R.empresa_id " +
                                     " INNER JOIN VTAS_CLIENTES_DIRE DIR ON DIR.iddireccion = R.iddireccion AND DIR.empresa_id = R.empresa_id AND DIR.idclie = R.idclie" +
                                     " INNER JOIN ADMI_TIPOFACTURACION TF ON TF.tipofac = R.tipofac " +
                                     " where R.estado != 'ANU' and R.empresa_id = '" + clase.tomacodempresa + "'" + CadenasConsulta + AccesoXsuLoginConsultaUser;

            conex.ConectarSistema();

            SqlDataAdapter ADAPT = new SqlDataAdapter(ConsultaCABECERA, conex.CON);
            DataSet dset = new DataSet();
            ADAPT.Fill(dset, "cabecera");
            consulta.DataSource = dset;
            consulta.DataMember = "cabecera";

            consulta.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dset.Dispose();
            ADAPT.Dispose();
            conex.DesconectarSistema();
        }
    }
}
