using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace GestionMantto.Forms
{
    public partial class ADM_Equipo : Form
    {
        private int TIPO, TIPOPARTE;
        string SQLINSERT;
        string Rutaima1, Rutaima2;
        int Foto1, Foto2;
        conexion conex = new conexion();
        recursos clase = new recursos();
        LoadImage limage = new LoadImage();
        loadFiles lfile = new loadFiles();
        ImagenUpd imaUpd = new ImagenUpd();
        ADM_Preview preview = new ADM_Preview();

        public ADM_Equipo()
        {
            InitializeComponent();
        }

        private void ADM_Equipo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            LimpiarTextEquipos();
            tabdata.SelectTab(1);
        }
        private void LIMPIARPARTES()
        {
            item.Clear();
            codparte.Clear();
            nombre.Clear();
            unidad.Text = "";
            cantidad.Clear();
            TIPOPARTE = 0;
        }
        private void LimpiarTextEquipos()
        {         
            categoria.Text = "";
            estado.Text = "";
            descrip.Clear();
            marcas.Text = "";
            //marcas.ValueMember = null;
            modelo.Clear();
            Serie.Clear();
            peso.Clear();
            unmedpeso.Text = "";
            altura.Clear();
            largo.Clear();
            ancho.Clear();
            umeddimen.Text = "";
            caracteristica.Clear();
            funcion.Clear();
            TIPO = 0;
            GenerarCorrelativo();
            picture1.Image=null;
            picture2.Image = null;
            Rutaima1 = "";
            Rutaima2 = "";
            Foto1 = 0;
            Foto2 = 0;

        }
        private void GenerarCorrelativo()
        {
            //generar el correlativo
            conex.ConectarSistema();
            SqlCommand cmd = new SqlCommand("SELECT (isnull(MAX(idequipo),0) + 1) as idequipo FROM ADMI_EQUIPOS " +
                                            "where  empresa_id ='"+ clase.tomacodempresa +"' ", conex.CON);
            SqlDataReader reader = null;
            reader = cmd.ExecuteReader();
            reader.Read();
            idequipo.Text = reader["idequipo"].ToString();

            cmd.Dispose();
            reader.Close();
            conex.DesconectarSistema();
        }
        private void GestionArchivo(string RutaIncial)
        {
            SqlCommand CMDArchivo = new SqlCommand("select nombreservidor,carpetaprincipal  from  ADMI_CARPETARCHIVOS", conex.CON);
            CMDArchivo.CommandType = CommandType.Text;
            SqlDataReader RDRArchivo = null;
            RDRArchivo = CMDArchivo.ExecuteReader();
            RDRArchivo.Read();

            string FolderDestino = "@" + RDRArchivo["nombreservidor"] + "\\" + RDRArchivo["carpetaprincipal"] + "\\" + "Equipos" + "\\" + clase.tomacodempresa + "\\" + idequipo.Text;
         }

        private void guardar_Click(object sender, EventArgs e)
        {
            Double V;

            if (idequipo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Genere Codigo de Equipo", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                idequipo.Focus();
                return;
            }
            //validar los datos de Peso
            //peso Equipo
            if (peso.Text.Length == 0)
            {
                MessageBox.Show("Debe existir un valor peso para continuar.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                peso.Focus();
                return;
            }

            if (double.TryParse(peso.Text, out V) == false)
            {
                MessageBox.Show("Ingresar valor numerico", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                peso.Focus();
                return;
            }

            if (double.Parse(peso.Text) == 0)
            {
                MessageBox.Show("Ingresar valor mayor a cero", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                peso.Focus();
                return;
            }
            //peso Envío
            if (pesoenvio.Text.Length == 0)
            {
                MessageBox.Show("Debe existir un valor peso para continuar.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                pesoenvio.Focus();
                return;
            }

            if (double.TryParse(pesoenvio.Text, out V) == false)
            {
                MessageBox.Show("Ingresar valor numerico", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                pesoenvio.Focus();
                return;
            }

            if (double.Parse(pesoenvio.Text) == 0)
            {
                MessageBox.Show("Ingresar valor mayor a cero", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                pesoenvio.Focus();
                return;
            }
            //copiar archivo y generar nueva ruta        


            conex.ConectarSistema();
            SqlCommand cmd = new SqlCommand("ADMI_PROCESO_EQUIPOS", conex.CON);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TIPO", SqlDbType.Int).Value = TIPO;
            cmd.Parameters.Add("@idequipo", SqlDbType.Int).Value = idequipo.Text;
            cmd.Parameters.Add("@descripcion", SqlDbType.NVarChar, 200).Value = descrip.Text;
            cmd.Parameters.Add("@idmarca", SqlDbType.Int).Value = marcas.SelectedValue.ToString();
            cmd.Parameters.Add("@idpais", SqlDbType.Int).Value = pais.SelectedValue;
            cmd.Parameters.Add("@modelo", SqlDbType.NVarChar, 200).Value = modelo.Text;
            cmd.Parameters.Add("@serie", SqlDbType.NVarChar, 100).Value = Serie.Text;
            cmd.Parameters.Add("@idcatequipo", SqlDbType.Int).Value = categoria.SelectedValue;
            cmd.Parameters.Add("@peso", SqlDbType.Decimal).Value = (peso.Text.Trim().Length == 0 ? 0 : Convert.ToDecimal(peso.Text));
            cmd.Parameters.Add("@peso_envio", SqlDbType.Decimal).Value = (pesoenvio.Text.Trim().Length == 0 ? 0 : Convert.ToDecimal(pesoenvio.Text));
            cmd.Parameters.Add("@umedpeso", SqlDbType.NChar, 3).Value = unmedpeso.SelectedValue;
            cmd.Parameters.Add("@altura", SqlDbType.Decimal).Value = (altura.Text.Trim().Length == 0 ? 0 : Convert.ToDecimal(altura.Text));
            cmd.Parameters.Add("@ancho", SqlDbType.Decimal).Value = (ancho.Text.Trim().Length == 0 ? 0 : Convert.ToDecimal(ancho.Text));
            cmd.Parameters.Add("@largo", SqlDbType.Decimal).Value = (largo.Text.Trim().Length == 0 ? 0 : Convert.ToDecimal(largo.Text));
            cmd.Parameters.Add("@umedimens", SqlDbType.NChar, 3).Value = umeddimen.SelectedValue;
            cmd.Parameters.Add("@caracteristicatecnica", SqlDbType.VarChar, 4000).Value = caracteristica.Text;   
            cmd.Parameters.Add("@funcion", SqlDbType.VarChar, 4000).Value = funcion.Text;           
            cmd.Parameters.Add("@usuario", SqlDbType.NVarChar, 100).Value = clase.tomacoduser;
            cmd.Parameters.Add("@estado", SqlDbType.NChar, 3).Value = "ACT";
            cmd.Parameters.Add("@empresa_id", SqlDbType.NVarChar, 4).Value = clase.tomacodempresa;
            SqlParameter Vsalida = cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 100);
            SqlParameter Vsalida2 = cmd.Parameters.Add("@idoutput", SqlDbType.Int);
            Vsalida.Direction = ParameterDirection.Output;
            Vsalida2.Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();
            MessageBox.Show(Vsalida.Value.ToString());
            TIPO = int.Parse(Vsalida2.Value.ToString());

            //  ActualizarImagenes(Rutaima1, "imagenA", "imagen",Foto1);

            //  ActualizarImagenes(Rutaima2, "imagenB", "imagen",Foto2);
            imaUpd.ActualizarImagenes("ADMI_EQUIPOS", Rutaima1, "imagenA", "imagen", Foto1, idequipo,null);
            imaUpd.ActualizarImagenes("ADMI_EQUIPOS", Rutaima2, "imagenB", "imagen", Foto2, idequipo,null);

            cmd.Dispose();
            conex.DesconectarSistema();
            
        }

        private void LoadMarca()
        {
            SqlDataAdapter AdapC = new SqlDataAdapter("SELECT IDMARCA,DESCRIPCION FROM  ADMI_MARCAS  ORDER BY DESCRIPCION", conex.CON);

            DataSet dsetC = new DataSet();
            AdapC.Fill(dsetC, "marca");
            marcas.DataSource = dsetC.Tables["marca"];
            marcas.DisplayMember = "DESCRIPCION";
            marcas.ValueMember = "IDMARCA";
            AdapC.Dispose();
            dsetC.Dispose();
        }
        private void ADM_Equipo_Load(object sender, EventArgs e)
        {
            tabdata.SelectTab(1);

            conex.ConectarSistema();

            #region MARCA
            LoadMarca();
    
            #endregion

            //paises

            SqlDataAdapter Adapais = new SqlDataAdapter("SELECT idpais,paisnombre FROM  ADMI_PAISES", conex.CON);

            DataSet dsetpais = new DataSet();
            Adapais.Fill(dsetpais, "pais");
            pais.DataSource = dsetpais.Tables["pais"];
            pais.DisplayMember = "paisnombre";
            pais.ValueMember = "idpais";
            Adapais.Dispose();
            dsetpais.Dispose();


            SqlDataAdapter AdapCateg = new SqlDataAdapter("select idcatequipo,descripcion from ADMI_EQUIPOS_CATEGORIA", conex.CON);
            DataSet dsetCateg = new DataSet();
            AdapCateg.Fill(dsetCateg, "CATEG");
            categoria.DataSource = dsetCateg.Tables["CATEG"];
            categoria.DisplayMember = "descripcion";
            categoria.ValueMember = "idcatequipo";
            AdapCateg.Dispose();
            dsetCateg.Dispose();

            //Unidad de Medida Peso       
            SqlDataAdapter Adapumedpeso = new SqlDataAdapter("select conumed,descripcion from  ADMI_UNIDADMEDIDA order by conumed desc", conex.CON);

            DataSet dsetumedpeso = new DataSet();
            Adapumedpeso.Fill(dsetumedpeso, "umedpeso");
            unmedpeso.DataSource = dsetumedpeso.Tables["umedpeso"];
            unmedpeso.DisplayMember = "conumed";
            unmedpeso.ValueMember = "conumed";
            //Unidad medida de envio
            unmedpesoenvio.DataSource = dsetumedpeso.Tables["umedpeso"];
            unmedpesoenvio.DisplayMember = "conumed";
            unmedpesoenvio.ValueMember = "conumed";            
            Adapumedpeso.Dispose();
            dsetumedpeso.Dispose();         

            
            //Unidad de Medida Dimension       
            SqlDataAdapter Adapumeddimen = new SqlDataAdapter("select conumed,descripcion from  ADMI_UNIDADMEDIDA order by conumed desc", conex.CON);

            DataSet dsetumeddimen = new DataSet();
            Adapumeddimen.Fill(dsetumeddimen, "umeddimen");
            umeddimen.DataSource = dsetumeddimen.Tables["umeddimen"];
            umeddimen.DisplayMember = "conumed";
            umeddimen.ValueMember = "conumed";
            Adapumeddimen.Dispose();
            dsetumeddimen.Dispose();

            conex.DesconectarSistema();

            GenerarCorrelativo();
            TIPO = 0;
        }

        private void tabdata_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabdata.SelectedIndex == 0)
            {
                string ConsultaEquipos = "SELECT e.idequipo,e.descripcion,e.idmarca,M.descripcion as Marca,e.modelo," +
                    " e.serie,CAT.idcatequipo,CAT.descripcion as Categoria," +
                    " e.peso,e.peso_envio,e.umedpeso,e.altura,e.ancho,e.largo,e.umedimens,e.caracteristicatecnica,e.funcion, " +
                    "e.user_crea,e.fe_crea,e.user_modi,e.fe_modi,e.estado " +
                    " from ADMI_EQUIPOS e INNER JOIN ADMI_MARCAS M ON M.idmarca = e.idmarca " +
                    " INNER JOIN ADMI_EQUIPOS_CATEGORIA CAT ON CAT.idcatequipo = e.idcatequipo " +
                    " WHERE e.estado = 'ACT' and e.empresa_id ='" + clase.tomacodempresa + "'";

                conex.ConectarSistema();

                SqlDataAdapter adap = new SqlDataAdapter(ConsultaEquipos, conex.CON);
                DataSet dset = new DataSet();
                adap.Fill(dset, "equipo");
                consulta.DataSource = dset;
                consulta.DataMember = "equipo";

                adap.Dispose();
                dset.Dispose();

                conex.DesconectarSistema();

            }
        }

        private void consulta_DoubleClick(object sender, EventArgs e)
        {
            if (consulta.RowCount == 0)
                return;
            idequipo.Text = consulta["idequipo", consulta.CurrentCell.RowIndex].Value.ToString();
            descrip.Text = consulta["descripcion", consulta.CurrentCell.RowIndex].Value.ToString();
            marcas.Text = consulta["Marca", consulta.CurrentCell.RowIndex].Value.ToString();
            marcas.SelectedValue = consulta["idmarca", consulta.CurrentCell.RowIndex].Value.ToString();
            categoria.Text = consulta["Categoria", consulta.CurrentCell.RowIndex].Value.ToString();
            categoria.SelectedValue = consulta["idcatequipo", consulta.CurrentCell.RowIndex].Value.ToString();
            peso.Text = consulta["peso", consulta.CurrentCell.RowIndex].Value.ToString();
            pesoenvio.Text = consulta["peso_envio", consulta.CurrentCell.RowIndex].Value.ToString();
            unmedpeso.SelectedValue = consulta["umedpeso", consulta.CurrentCell.RowIndex].Value.ToString();
            unmedpeso.Text = consulta["umedpeso", consulta.CurrentCell.RowIndex].Value.ToString();
            unmedpesoenvio.SelectedValue = consulta["umedpeso", consulta.CurrentCell.RowIndex].Value.ToString();
            unmedpesoenvio.Text = consulta["umedpeso", consulta.CurrentCell.RowIndex].Value.ToString();
            altura.Text = consulta["altura", consulta.CurrentCell.RowIndex].Value.ToString();
            ancho.Text = consulta["ancho", consulta.CurrentCell.RowIndex].Value.ToString();
            largo.Text = consulta["largo", consulta.CurrentCell.RowIndex].Value.ToString();
            umeddimen.Text = consulta["umedimens", consulta.CurrentCell.RowIndex].Value.ToString();
            umeddimen.SelectedValue = consulta["umedimens", consulta.CurrentCell.RowIndex].Value.ToString();
            caracteristica.Text = consulta["caracteristicatecnica", consulta.CurrentCell.RowIndex].Value.ToString();
            funcion.Text = consulta["funcion", consulta.CurrentCell.RowIndex].Value.ToString();
            modelo.Text = consulta["modelo", consulta.CurrentCell.RowIndex].Value.ToString();
            Serie.Text = consulta["serie", consulta.CurrentCell.RowIndex].Value.ToString();
            estado.Text = consulta["estado", consulta.CurrentCell.RowIndex].Value.ToString();


            try
            {
                conex.ConectarSistema();
                SqlCommand CMDImage = new SqlCommand(" select isnull(imagenA,'')as imagenA ,isnull(imagenB ,'') as imagenB from ADMI_EQUIPOS "+  
                                        " where empresa_id='"+ clase.tomacodempresa +"' and  idequipo=" + idequipo.Text, conex.CON);
                CMDImage.CommandType = CommandType.Text;
                SqlDataReader RDRImage = null;
                RDRImage = CMDImage.ExecuteReader();
                RDRImage.Read();
                picture1.Image = null;
                picture2.Image = null;

                if (RDRImage.HasRows == true)
                {
                    if (RDRImage["imagenA"] != System.DBNull.Value)
                    {
                        //    IMAGEN A
                        byte[] arrA = (byte[])RDRImage["imagenA"];
                        MemoryStream msA = new MemoryStream(arrA);
                        msA.Seek(0, SeekOrigin.Begin);
                        picture1.Image = Image.FromStream(msA);
                    }

                    if (RDRImage["imagenA"] != System.DBNull.Value)
                    {
                        //    IMAGEN B                
                        if (RDRImage["imagenB"].ToString() != "")
                        {
                            byte[] arrB = (byte[])RDRImage["imagenB"];
                            MemoryStream msB = new MemoryStream(arrB);
                            msB.Seek(0, SeekOrigin.Begin);
                            picture2.Image = Image.FromStream(msB);
                        }
                    }
                }

                RDRImage.Close();
                CMDImage.Dispose();
                conex.DesconectarSistema();
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            //modo edicion
            TIPO = 1;
            tabdata.SelectTab(1);
        }

        private void anular_Click(object sender, EventArgs e)
        {
            if (idequipo.Text.Length == 0)
            {
                MessageBox.Show("Seleccione un registro", Application.CompanyName);
                return;
            }

            DialogResult resultado = MessageBox.Show("Desea Anular el registro actual", Application.ProductName, MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                conex.ConectarSistema();

                string AnularCliente = "UPDATE ADMI_EQUIPOS SET estado ='ANU' WHERE idequipo ='" + idequipo.Text + "'" +
                    " and  empresa_id =" + clase.tomacodempresa + "";

                SqlCommand cmd = new SqlCommand(AnularCliente, conex.CON);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conex.DesconectarSistema();
                LimpiarTextEquipos();
            }
        }

        private void consulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //item
            if (item.Text.ToString().Trim().Length == 0)
            {
                MessageBox.Show("Ingrese Item", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                item.Focus();
                return;
            }
            //cod parte
            if (codparte.Text.ToString().Trim().Length == 0)
            {
                MessageBox.Show("Ingrese Código Parte", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                codparte.Focus();
                return;
            }

            //nombre
            if (nombre.Text.ToString().Trim().Length == 0)
            {
                MessageBox.Show("Ingrese Código Parte", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                nombre.Focus();
                return;
            }

            //cantidad
            if (cantidad.Text.ToString().Trim().Length == 0)
            {
                MessageBox.Show("Ingrese Cantidad", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cantidad.Focus();
                return;
            }

            conex.ConectarSistema();

            if (TIPOPARTE == 0)
            {
                SQLINSERT = "INSERT INTO ADMI_EQUIPOS_PARTES VALUES(" + idequipo.Text + ",'" + item.Text + "','" + codparte.Text + "','" + nombre.Text + "'" +
                      ",'" + unidad.SelectedValue + "'," + cantidad.Text + " )";
            }
            else
            {
                SQLINSERT = "UPDATE ADMI_EQUIPOS_PARTES SET  correlativo='" + item.Text + "' ,codigoparte='" + codparte.Text + "'" +
                    ", nombre='" + nombre.Text + "',conumed='" + unidad.SelectedValue + "',cantidad =" + cantidad.Text + "" +
                    " where IDEQUIPO ='" + idequipo.Text + "' and item =" + partes["item", partes.CurrentCell.RowIndex].Value + "";
            }

            SqlCommand CMD = new SqlCommand(SQLINSERT, conex.CON);
            CMD.CommandType = CommandType.Text;
            CMD.ExecuteNonQuery();

            CMD.Dispose();
            conex.DesconectarSistema();
            MOSTRARPARTES();

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                textBox1.Text = "Id: " + idequipo.Text + " Descrip: " + descrip.Text;
                //Insertar los departamento

                conex.ConectarSistema();
                string ConsultaDepa = "SELECT conumed FROM ADMI_UNIDADMEDIDA";

                SqlDataAdapter adap = new SqlDataAdapter(ConsultaDepa, conex.CON);

                DataSet dset = new DataSet();
                adap.Fill(dset, "umed");
                unidad.DataSource = dset.Tables["umed"];
                unidad.DisplayMember = "conumed";
                unidad.ValueMember = "conumed";
                adap.Dispose();
                dset.Dispose();
                conex.DesconectarSistema();

                TIPOPARTE = 0;
                //LimpiarTextoDireccion();
                // MostrarDirCliente();
                MOSTRARPARTES();
            }
        }

        private void btnremo_Click(object sender, EventArgs e)
        {

        }

        private void MOSTRARPARTES()
        {
            //evaluar si esta con datos el codigo de cliente

            if (idequipo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Seleccione o Ingrese un Equipo.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabControl1.SelectTab(0);
                idequipo.Focus();
                return;
            }
            //Evaluar si equipo  existe
            conex.ConectarSistema();
            String ValidarClient = "select idequipo FROM ADMI_EQUIPOS where idequipo='" + idequipo.Text + "'";

            SqlCommand CMD = new SqlCommand(ValidarClient, conex.CON);
            SqlDataReader READ = null;
            READ = CMD.ExecuteReader();
            READ.Read();

            if (READ.HasRows == true)
            {
                string SQLCONSULTA = "SELECT item,correlativo,codigoparte, nombre,conumed,cantidad FROM ADMI_EQUIPOS_PARTES A" +
                " WHERE IDEQUIPO=" + idequipo.Text + "";

                SqlDataAdapter adapB = new SqlDataAdapter(SQLCONSULTA, conex.CON);

                DataSet dsetB = new DataSet();
                adapB.Fill(dsetB, "partes");
                partes.DataSource = dsetB;
                partes.DataMember = "partes";
                dsetB.Dispose();
                adapB.Dispose();
            }
            else
            {
                MessageBox.Show("Equipo no está registrado.", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabControl1.SelectTab(0);
            }

            READ.Close();
            CMD.Dispose();
            conex.DesconectarSistema();
        }

        private void partes_SelectionChanged(object sender, EventArgs e)
        {
            REFRESCARPARTES();
        }

        private void cantidad_TextChanged(object sender, EventArgs e)
        {
            cantidad.Text = new string(cantidad.Text.Where(c => (char.IsDigit(c)) || (c == '.')).ToArray());
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            LIMPIARPARTES();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Reportes.reportes reporte = new Reportes.reportes();

            conexion conex = new conexion();


            if (idequipo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Seleccione Equipo", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                descrip.Focus();
                return;
            }

            conex.ConectarSistema();

            string ruta = "" + Application.StartupPath + "\\Reportes\\" + "ADMI_Equipos.rpt";
            reporte.cryRpt.Load(ruta);
            SqlDataAdapter sda = new SqlDataAdapter("ADMI_PROCESO_EQUIPOS_REPORTE", conex.CON);

            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("@idequipo", SqlDbType.Int).Value = idequipo.Text;
            sda.SelectCommand.Parameters.Add("@empresa_id", SqlDbType.NVarChar, 2).Value = clase.tomacodempresa;

            DataSet st = new System.Data.DataSet();
            sda.Fill(st, "Equipos");

            reporte.cryRpt.SetDataSource(st);
            reporte.Show();
            conex.DesconectarSistema();
            sda.Dispose();
            st.Dispose();
        }

        private void peso_TextChanged(object sender, EventArgs e)
        {
            peso.Text = new string(peso.Text.Where(c => (char.IsDigit(c)) || (c == '.')).ToArray());
        }

        private void altura_TextChanged(object sender, EventArgs e)
        {
            altura.Text = new string(altura.Text.Where(c => (char.IsDigit(c)) || (c == '.')).ToArray());
        }

        private void largo_TextChanged(object sender, EventArgs e)
        {
            largo.Text = new string(largo.Text.Where(c => (char.IsDigit(c)) || (c == '.')).ToArray());
        }

        private void ancho_TextChanged(object sender, EventArgs e)
        {
            ancho.Text = new string(ancho.Text.Where(c => (char.IsDigit(c)) || (c == '.')).ToArray());
        }

        private void picture_DoubleClick(object sender, EventArgs e)
        {          
            //preview.MdiChildren = this;            
            preview.Origen = picture1.Image;
            preview.ShowDialog();

            /*
             * 
             * 
                byte[] arr = (byte[])RDRImage["imagenMain"];
                MemoryStream ms1 = new MemoryStream(arr);
                ms1.Seek(0, SeekOrigin.Begin);
                picture.Image = Image.FromStream(ms1);
             * 
             * */

        }

        private void cargar_Click(object sender, EventArgs e)
        {
            var TuplaImagen = limage.DialogoImagen(picture1);
            Rutaima1= TuplaImagen.Item1;
            Foto1 = 1;
     
        }

        private void picture2_DoubleClick(object sender, EventArgs e)
        {
            preview.Origen = picture2.Image;
            preview.ShowDialog();
        }

        private void cargarfile_Click(object sender, EventArgs e)
        {
    
        }

        private void picture1_Click(object sender, EventArgs e)
        {

        }

        private void linkconcep_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadMarca();
        }

        private void pesoenvio_TextChanged(object sender, EventArgs e)
        {
            pesoenvio.Text = new string(pesoenvio.Text.Where(c => (char.IsDigit(c)) || (c == '.')).ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            var TuplaImagen = limage.DialogoImagen(picture2);
            Rutaima2 = TuplaImagen.Item1;
            Foto2 = 1;
        }

       
        private void REFRESCARPARTES()
        {
            if (partes.RowCount == 0)
                return;

            TIPOPARTE = 1;

            item.Text = partes["correlativo", partes.CurrentCell.RowIndex].Value.ToString();
            codparte.Text = partes["codigoparte", partes.CurrentCell.RowIndex].Value.ToString();
            nombre.Text = partes["nombre", partes.CurrentCell.RowIndex].Value.ToString();
            unidad.SelectedValue = partes["conumed", partes.CurrentCell.RowIndex].Value.ToString();
            unidad.Text = partes["conumed", partes.CurrentCell.RowIndex].Value.ToString();
            cantidad.Text = partes["cantidad", partes.CurrentCell.RowIndex].Value.ToString();

        }

    }
}