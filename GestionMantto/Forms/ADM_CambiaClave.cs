using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestionMantto.Forms
{
    public partial class ADM_CambiaClave : Form
    {
        conexion con = new conexion();
        recursos recurso = new recursos();

        public ADM_CambiaClave()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtclaveactual.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Clave");
                return;
            }
            if (txtnuevaclave.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Clave");
                return;

            }
            if (txtrepitaclave.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Clave");
                return;
            }

            if (txtnuevaclave.Text != txtrepitaclave.Text)
            {
                MessageBox.Show("Clave incorrecta, vuelva a ingresasr."); ;
                return;
            }

            string Cadena = "SELECT CO_USUA, NO_CLAV FROM  USUARIOS WHERE" +
                  " CO_USUA='" + recurso.tomacoduser + "'" +
                  " AND  NO_CLAV ='" + txtclaveactual.Text.ToString().Replace("'", "").Trim() + "'";

            con.ConectarSistema();

            SqlCommand cmd = new SqlCommand(Cadena, con.CON);

            SqlDataReader rdr = null;

            rdr = cmd.ExecuteReader();
            rdr.Read();

            if (!rdr.HasRows)
            {
                MessageBox.Show("Clave actual Incorrecta");
                rdr.Close();
                return;
            }

            ///actualizar nueva clave
            ///

            string SQLUPDATE = " UPDATE  USUARIOS SET NO_CLAV='" + txtnuevaclave.Text + "'" +
                   " WHERE CO_USUA ='" + recurso.tomacoduser + "'";

            SqlCommand CMD = new SqlCommand(SQLUPDATE, con.CON);

            CMD.ExecuteNonQuery();

            con.DesconectarSistema();

            MessageBox.Show("Cambios realizados");
        }

        private void ADM_CambiaClave_Load(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
