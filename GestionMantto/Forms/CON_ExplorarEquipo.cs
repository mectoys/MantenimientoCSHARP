using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace GestionMantto.Forms
{
    public partial class CON_ExplorarEquipo : Form
    {
        conexion conex = new conexion();
        recursos clase = new recursos();
        string Key;
        TreeNode Hijo;
        public CON_ExplorarEquipo()
        {
            InitializeComponent();
        }

        private void CON_ExplorarEquipo_Load(object sender, EventArgs e)
        {
            //cargar clientes
            clase.DamequeryGeneral("select  idclie ,razonsoc +' ' + idclie as descripcion  from VTAS_CLIENTES where empresa_id =" + clase.tomacodempresa + " and estado='ACT' order by razonsoc");
            Clientes.DataSource = AutoCompleClass.Datos();
            Clientes.DisplayMember = "descripcion";
            Clientes.ValueMember = "idclie";
            Clientes.AutoCompleteCustomSource = AutoCompleClass.Autocomplete();
            Clientes.AutoCompleteMode = AutoCompleteMode.Suggest;
            Clientes.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private void Clientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            treeView1.Nodes.Clear();
            conex.ConectarSistema();
            treeView1.BeginUpdate();

            string Consultacliequip = " select D.iddireccion,D.tienda from VTAS_CLIENTES_DIRE D " +
                                        " where D.empresa_id = " + clase.tomacodempresa + "  " +
                                        " AND D.idclie = '" + Clientes.SelectedValue + "' AND D.tipodirec = 'COM' order by D.tienda";

            SqlCommand CMDCTIENDA = new SqlCommand(Consultacliequip, conex.CON);
            CMDCTIENDA.CommandType = CommandType.Text;
            SqlDataReader RDRTIENDA = null;
            RDRTIENDA = CMDCTIENDA.ExecuteReader();

            TreeNode Padre = new TreeNode();
            while (RDRTIENDA.Read())
            {
                Padre = new TreeNode(RDRTIENDA["tienda"].ToString());
                treeView1.ImageIndex = 0;
                treeView1.Nodes.Add( Padre);
               // Padre.Name = RDRTIENDA["tienda"].ToString();
              //  treeView1.Nodes.ContainsKey(RDRTIENDA["iddireccion"].ToString());
                //agregar los equipos 
                string RelacionEqp = "select VCE.idclientequi,ROW_NUMBER()OVER(PARTITION BY EQP.idequipo , " +
                                " EQP.descripcion ORDER BY EQP.descripcion) AS ORDEN,EQP.descripcion as Equipo" +
                                " from VTAS_CLIENTES_EQUIPOS VCE " +
                                " INNER JOIN ADMI_EQUIPOS EQP ON EQP.idequipo = VCE.idequipo AND EQP.empresa_id = VCE.empresa_id" +
                                " WHERE VCE.idclie='" + Clientes.SelectedValue + "' AND VCE.empresa_id='" + clase.tomacodempresa + "'" +
                                " AND VCE.iddireccion=" + RDRTIENDA["iddireccion"].ToString();

                SqlCommand CMDEQUIP = new SqlCommand(RelacionEqp, conex.CON);
                CMDEQUIP.CommandType = CommandType.Text;
                SqlDataReader RDREQUIP = null;
                RDREQUIP = CMDEQUIP.ExecuteReader();
                while (RDREQUIP.Read())
                {
                  
                  // Key = RDRTIENDA["iddireccion"].ToString();
                   Hijo= new TreeNode(RDREQUIP["Equipo"].ToString());

                   Hijo.ImageIndex = 1;

                    Padre.Nodes.Add( Hijo);
                    Hijo.Name = RDRTIENDA["iddireccion"].ToString();
                    
                    string key = "15";
                    string text = "New Node";
                    TreeNode tnRoot = this.treeView1.Nodes[0];
                    TreeNode tn = this.treeView1.Nodes.Add(key, text);

                }
                RDREQUIP.Close();
                CMDEQUIP.Dispose();
            }
            RDRTIENDA.Close();
            CMDCTIENDA.Dispose();
            treeView1.EndUpdate();
            conex.DesconectarSistema();

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedNodeText = treeView1.Nodes[66].Text;
            
            MessageBox.Show(selectedNodeText);
        }
    }
    }

