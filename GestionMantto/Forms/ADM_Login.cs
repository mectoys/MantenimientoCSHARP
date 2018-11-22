using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestionMantto.Forms
{
    public partial class ADM_Login : Form
    {
        conexion conec = new conexion();

        public ADM_Login()
        {
            InitializeComponent();
        }

        private void ADM_Login_Load(object sender, EventArgs e)
        {

            conec.ConectarSistema();
            SqlDataAdapter adapempresa = new SqlDataAdapter("select empresa_id,descripcion from rrhh_empresa where estado=1", conec.CON);

            DataSet dataempresa = new DataSet();
            adapempresa.Fill(dataempresa, "empresas");
            empresa.DataSource = dataempresa.Tables["empresas"];
            empresa.DisplayMember = "descripcion";
            empresa.ValueMember = "empresa_id";
            adapempresa.Dispose();


            conec.DesconectarSistema();

        }

        private void aceptar_Click(object sender, EventArgs e)
        {

            conec.ConectarSistema();

            SqlCommand COMANDO = new SqlCommand("select u.CO_USUA, u.NO_CLAV " +
              " From USUARIOS u inner JOIN  USUARIOS_SISTEMAS su on su.ID_USER = u.ID_USER " +
             " WHERE su.ID_SISTEMA = 4 and Su.EMPRESA_ID = '" + empresa.SelectedValue.ToString() + "'" +
             " and u.CO_USUA='" + user.Text.ToString().Trim() + "' AND u.NO_CLAV='" + clave.Text.ToString().Trim() + "' ", conec.CON);

            recursos clase = new recursos();
            clase.Damecodempresa(empresa.SelectedValue.ToString());
            clase.Damenombrempresa(empresa.Text);
            //Principal.NorificadorBalloonTexto("Bienvenido " + nombre.Text + " al Sistema");              
            clase.Damecoduser(user.Text.ToUpper());

            COMANDO.CommandType = CommandType.Text;
            SqlDataReader UREADER = null;
            UREADER = COMANDO.ExecuteReader();
            UREADER.Read();

            if (UREADER.HasRows == false)
            {
                MessageBox.Show("Datos de usuario incorrecto...", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //errorProvider1.SetError(user, "Credenciales incorrectas o Sin permiso para acceder al sistema...");
                //conec.Desconectar_ARDISA_SISTEMA();
                return;
            }
            else
            {
                //VERIFICAR EL TIPO DE CAMBIO 
                SqlCommand CMDTC = new SqlCommand("select id from ADMI_TIPOCAMBIO WHERE CAST(FECHA AS DATE) " +
                    " =CAST((SELECT GETDATE()) AS DATE)", conec.CON);
                CMDTC.CommandType = CommandType.Text;
                SqlDataReader RDRTC = null;

                RDRTC = CMDTC.ExecuteReader();
                RDRTC.Read();
                if (RDRTC.HasRows == false)
                {
                    this.Hide();
                    Forms.ADM_TipoCambio tc = new ADM_TipoCambio();
                    tc.Show();
                    CMDTC.Dispose();
                    RDRTC.Close();
                }
                else
                {
                    Forms.Principal Principal = new Principal();
                    Principal.Show();
                    conec.DesconectarSistema();
                    this.Hide();
                }

                CMDTC.Dispose();
                RDRTC.Close();
                conec.DesconectarSistema();
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                clave.Focus();
            }
        }

        private void clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                aceptar.Focus();
            }
        }


    }
}
