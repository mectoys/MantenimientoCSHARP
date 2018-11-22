using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;


namespace GestionMantto.Forms
{
    public partial class ADM_TipoCambio : Form
    {
        conexion conex = new conexion();
        recursos clase = new recursos();
        public ADM_TipoCambio()
        {
            InitializeComponent();
        }

        private void ADM_TipoCambio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void compra_TextChanged(object sender, EventArgs e)
        {
            compra.Text = new string(compra.Text.Where(c => (char.IsDigit(c)) || (c == '.')).ToArray());
        }

        private void venta_TextChanged(object sender, EventArgs e)
        {
            venta.Text = new string(venta.Text.Where(c => (char.IsDigit(c)) || (c == '.')).ToArray());
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (compra.Text.Length == 0)
            {
                MessageBox.Show("Ingrese valor Compra", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                compra.Focus();
                return;
            }

            string MensajeAviso = "AVISO!, está ingresando un valor muy elevado... " + System.Environment.NewLine + " de igual manera se contnuará";

            if (Convert.ToDecimal(compra.Text) >= 10)
                MessageBox.Show(MensajeAviso, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);


            if (venta.Text.Length == 0)
            {
                MessageBox.Show("Ingrese valor Venta", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                venta.Focus();
                return;
            }

            if (Convert.ToDecimal(venta.Text) >= 10)
                MessageBox.Show(MensajeAviso, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);


            //validar que no se ingrese tc exagerados
            // string Queryvalidar = "select top 1 compra,venta from  ADMI_TIPOCAMBIO WHERE IDMONE='DOL' order by fecha desc";
            

            using (SqlConnection connection = new SqlConnection(conex.CadenaConexion))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;
                //iniciar una transaccion local
                transaction = connection.BeginTransaction("TransaccionTC");
                //debemos asignar ambas transacciones objeto y conexion al
                //objeto comando por una pendiente transaccion local
                command.Connection = connection;
                command.Transaction = transaction;
                try
                {
                    command.CommandText =
                        "INSERT INTO ADMI_TIPOCAMBIO  (idmone,compra,venta,fecha,user_crea,fe_crea)" +
                        "VALUES('DOL'," + compra.Text + "," + venta.Text + ",'" + fecha.Value.Date.ToShortDateString() + "'" +
                         ",'" + clase.tomacoduser + "',getdate()) ";
                    command.ExecuteNonQuery();

                    //commit transaccion
                    transaction.Commit();

                    Forms.Principal Principal = new Principal();
                    Principal.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Commit Exception Type: {0}" + ex.GetType());
                    MessageBox.Show("  Message: {0}" + ex.Message);
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show("Commit Exception Type: {0}" + ex2.GetType());
                        MessageBox.Show("  Message: {0}" + ex2.Message);

                    }
                }

                connection.Close();
            }


        }
        
        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ProcessStartInfo sInfo = new ProcessStartInfo(link.Text);
            Process.Start(sInfo);

        }

        private void compra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                venta.Focus();

        }

        private void venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                aceptar.Focus();


        }

        private void ADM_TipoCambio_Load(object sender, EventArgs e)
        {

        }
    }
}
