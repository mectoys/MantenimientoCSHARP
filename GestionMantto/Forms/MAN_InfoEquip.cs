using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;


namespace GestionMantto.Forms
{
    public partial class MAN_InfoEquip : Form
    {
        conexion conex = new conexion();
        recursos clase = new recursos();
        LoadImage limage = new LoadImage();
        ADM_Preview preview = new ADM_Preview();
        ImagenUpd imaUpd = new ImagenUpd();
        DireccFacturacion Ubicacion = new DireccFacturacion();

        //string Rutaima1, Rutaima2;
        //int Foto1, Foto2;
        decimal d;
        public MAN_InfoEquip()
        {
            InitializeComponent();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MAN_InfoEquip_Load(object sender, EventArgs e)
        {
            conex.ConectarSistema();


            #region MARCA
            SqlDataAdapter Adap = new SqlDataAdapter("SELECT IDMARCA,DESCRIPCION FROM  ADMI_MARCAS ORDER BY DESCRIPCION", conex.CON);

            DataSet dset = new DataSet();
            Adap.Fill(dset, "marca");
            Marca.DataSource = dset.Tables["marca"];
            Marca.DisplayMember = "DESCRIPCION";
            Marca.ValueMember = "IDMARCA";
            Adap.Dispose();
            dset.Dispose();
            #endregion


            #region AREA
            //AREA
            SqlDataAdapter Adaptip = new SqlDataAdapter("SELECT idarea,descripcion FROM ADMI_EQUIPOS_AREA", conex.CON);

            DataSet dsetip = new DataSet();
            Adaptip.Fill(dsetip, "Area");
            Area.DataSource = dsetip.Tables["Area"];
            Area.DisplayMember = "descripcion";
            Area.ValueMember = "idarea";
            Adaptip.Dispose();
            dsetip.Dispose(); 
            #endregion

            /*
            SqlDataAdapter Adap = new SqlDataAdapter("select idequipo,descripcion from ADMI_EQUIPOS where empresa_id='" + clase.tomacodempresa + "'", conex.CON);

            DataSet dset = new DataSet();
            Adap.Fill(dset, "equipo");
            equipo.DataSource = dset.Tables["equipo"];
            equipo.DisplayMember = "descripcion";
            equipo.ValueMember = "idequipo";
            Adap.Dispose();
            dset.Dispose();
            */
            conex.DesconectarSistema();

            //cargar clientes
            clase.DamequeryGeneral("select  idclie ,razonsoc +' ' + idclie as descripcion  from VTAS_CLIENTES where empresa_id =" + clase.tomacodempresa + " and estado='ACT' order by razonsoc");
            clientes.DataSource = AutoCompleClass.Datos();
            clientes.DisplayMember = "descripcion";
            clientes.ValueMember = "idclie";
            clientes.AutoCompleteCustomSource = AutoCompleClass.Autocomplete();
            clientes.AutoCompleteMode = AutoCompleteMode.Suggest;
            clientes.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void EquiposEnTienda()
        {
            string RelacionEqp = "select VCE.idclientequi,ROW_NUMBER()OVER(PARTITION BY EQP.idequipo , "+ 
                                " EQP.descripcion ORDER BY EQP.descripcion) AS ORDEN,EQP.descripcion as Equipo" +
                                " from VTAS_CLIENTES_EQUIPOS VCE " +
                                " INNER JOIN ADMI_EQUIPOS EQP ON EQP.idequipo = VCE.idequipo AND EQP.empresa_id = VCE.empresa_id" +
                                " WHERE VCE.idclie='" + clientes.SelectedValue + "' AND VCE.empresa_id='" + clase.tomacodempresa + "'" +
                                " AND VCE.iddireccion=" + Tienda.SelectedValue;

            conex.ConectarSistema();
            SqlDataAdapter ADAPequip = new SqlDataAdapter(RelacionEqp, conex.CON);
            DataSet Dset = new DataSet();
            ADAPequip.Fill(Dset,"Equipos");
            if (Dset.Tables.Count!=0)
            {
                ConTiendaEquipo.DataSource = Dset;
                ConTiendaEquipo.DataMember = "Equipos";
            }
            ConTiendaEquipo.Columns["idclientequi"].Visible = false;
                Dset.Dispose();
            ADAPequip.Dispose();
            conex.DesconectarSistema();
            //auto resize
            ConTiendaEquipo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void RelacionTiendasConEquipo()
        {

           // Limpiar();
           // string ConsultaConEquipo = "select VCE.idclientequi,VCD.tienda " +
           //                            " from VTAS_CLIENTES_EQUIPOS VCE " +
           //                            " inner  join VTAS_CLIENTES_DIRE VCD ON VCD.iddireccion = VCE.iddireccion  and VCD.idclie = vce.idclie " +
           //                            " WHERE VCE.empresa_id ='" + clase.tomacodempresa + "' and VCE.idclie =  '" + clientes.SelectedValue + "'" +
           //                            " AND VCE.idequipo = '" + equipo.SelectedValue + "'";

           // conex.ConectarSistema();
           // SqlDataAdapter AdapEquip = new SqlDataAdapter(ConsultaConEquipo, conex.CON);
           // DataSet Dset = new DataSet();
           // AdapEquip.Fill(Dset, "ConEquipo");
           // if (Dset.Tables.Count!=0)
           // {
           //     ConTiendaEquipo.DataSource = Dset;
           //     ConTiendaEquipo.DataMember = "ConEquipo";
           //     ConTiendaEquipo.Columns["idclientequi"].Visible = false;
           // }
           // else
           // {
           //     Limpiar();
           // }
           
           // Dset.Dispose();
           // AdapEquip.Dispose();
           // conex.DesconectarSistema();

           //;
        }

        private void equipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
         
        }

        private void clientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //RelacionTiendasConEquipo();
            ConTiendaEquipo.DataSource = null;
            ConTiendaEquipo.Refresh();
            Ubicacion.ClientesConTienda(clientes, Tienda);
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            
            if (Area.Text.Length == 0)
            {
                MessageBox.Show("Seleccione Area", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Area.Focus();
                return;
            }

            if (Marca.Text.Length == 0)
            {
                MessageBox.Show("Seleccione Marca", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Area.Focus();
                return;
            }

            if (NumUbica.Text.Length==0)
            {
                MessageBox.Show("Ingrese Num. Ubicación", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NumUbica.Focus();
                return;
            }
            if (Temperatura.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Temperatura", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Temperatura.Focus();
                return;
            }


            if (Amperaje.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Amperaje", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Amperaje.Focus();
                return;
            }
            
            if (!decimal.TryParse(Amperaje.Text, out d))
            {
                MessageBox.Show("Ingrese un valor correcto para Amperaje", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Amperaje.Focus();
                return;
            }
            
            if (Presion.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Presión", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Presion.Focus();
                return;
            }

            if (cantidad.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Cantidad", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cantidad.Focus();
                return;
            }

            if (potencia.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Potencia", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                potencia.Focus();
                return;
            }

            if (pozo.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Pozo", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                pozo.Focus();
                return;
            }

            if (tapas.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Tapas", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tapas.Focus();
                return;
            }

            if (tipopotencia.Text.Length == 0)
            {
                MessageBox.Show("Seleccione Tipo de Potencia", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tipopotencia.Focus();
                return;
            }

            if (iddirecc.Text.Length == 0)
            {
                MessageBox.Show("Seleccione una Tienda", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                iddirecc.Focus();
                return;
            }

            conex.ConectarSistema();
            string UpdateEquipo;
            UpdateEquipo = "update VTAS_CLIENTES_EQUIPOS set cantidad=@cantidad,observacion=@ubicacion,potencia=@potencia,tipotenc=@tipotenc,"+
                "pozocantidad=@pozocantidad,pozotapas=@pozotapas,user_modi=@user_modi,fe_modi=getdate() "+
                ",codigointerno=@codigointerno,idarea=@idarea,numubicar=@numubicar,temperatura=@temperatura,"+
                "amperaje=@amperaje,presion=@presion,tipogas=@tipogas, " +
                 "idmarca=@idmarca,tipoEquipo=@tipoEquipo,serie=@serie,modelo=@modelo " +
                "where idclientequi=@idclientequi";
            SqlCommand CMDEquipo = new SqlCommand(UpdateEquipo, conex.CON);            
        
            CMDEquipo.Parameters.Add("@cantidad", SqlDbType.Int).Value =Convert.ToInt16(cantidad.Text);
            CMDEquipo.Parameters.Add("@ubicacion", SqlDbType.NVarChar,200).Value = Observacion.Text;
            CMDEquipo.Parameters.Add("@potencia", SqlDbType.Decimal).Value = (potencia.Text.Trim().Length == 0 ? 0 : Convert.ToDecimal(potencia.Text)); 
            CMDEquipo.Parameters.Add("@tipotenc", SqlDbType.VarChar,2).Value = tipopotencia.Text;
            CMDEquipo.Parameters.Add("@pozocantidad", SqlDbType.Int).Value =Convert.ToInt16(pozo.Text);
            CMDEquipo.Parameters.Add("@pozotapas", SqlDbType.Int).Value = Convert.ToInt16(tapas.Text);
            CMDEquipo.Parameters.Add("@user_modi", SqlDbType.VarChar,8).Value = clase.tomacoduser;   
            CMDEquipo.Parameters.Add("@idclientequi", SqlDbType.Int).Value =Convert.ToInt16(iddirecc.Text);
            CMDEquipo.Parameters.Add("@codigointerno", SqlDbType.NVarChar, 20).Value = Codigo.Text;
            CMDEquipo.Parameters.Add("@idarea", SqlDbType.Int).Value = Area.SelectedValue;
            CMDEquipo.Parameters.Add("@numubicar", SqlDbType.NVarChar, 3).Value = NumUbica.Text;
            CMDEquipo.Parameters.Add("@temperatura", SqlDbType.Decimal).Value = Convert.ToDecimal(Temperatura.Text);
            CMDEquipo.Parameters.Add("@amperaje", SqlDbType.Decimal).Value = Convert.ToDecimal(Amperaje.Text);
            CMDEquipo.Parameters.Add("@presion", SqlDbType.NVarChar,5).Value = Presion.Text;
            CMDEquipo.Parameters.Add("@tipogas", SqlDbType.NChar,4).Value = Tipogas.Text;
            CMDEquipo.Parameters.Add("@tipoEquipo", SqlDbType.NVarChar, 40).Value = Tipoequipo.Text;
            CMDEquipo.Parameters.Add("@idmarca", SqlDbType.Int).Value = Marca.SelectedValue;
            CMDEquipo.Parameters.Add("@serie", SqlDbType.NVarChar, 20).Value = Serie.Text;
            CMDEquipo.Parameters.Add("@modelo", SqlDbType.NVarChar, 20).Value = Modelo.Text;
            CMDEquipo.CommandType = CommandType.Text;
            CMDEquipo.ExecuteNonQuery();
            CMDEquipo.Dispose();
            conex.DesconectarSistema();
            
            MessageBox.Show("Actualización Realizada", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //            imaUpd.ActualizarImagenes("VTAS_CLIENTES_EQUIPOS", Rutaima1, "imagen1", "imagen", Foto1,null ,iddirecc);
            //          imaUpd.ActualizarImagenes("VTAS_CLIENTES_EQUIPOS", Rutaima2, "imagen2", "imagen", Foto2, null, iddirecc);

            // Foto1 = 0;
            //  Foto2 = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloudinaryDotNet.Account account =
             new CloudinaryDotNet.Account("tecnicor", "145824563393643", "lO63XX0pBVtq0-EFdnS-7wt0_6g");

            CloudinaryDotNet.Cloudinary cloudinary = new CloudinaryDotNet.Cloudinary(account);
            /*
            CloudinaryDotNet.Actions.ImageUploadParams uploadParams = new CloudinaryDotNet.Actions.ImageUploadParams()
            {
               // File = new CloudinaryDotNet.FileDescription(@"c:\menumaster.jpg"),
                PublicId = "Hornos/menumaster012018",
                Invalidate=true
            };
            */
            cloudinary.DeleteResources("Hornos/menumaster012018");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CloudinaryDotNet.Account account =
          new CloudinaryDotNet.Account("tecnicor", "145824563393643", "lO63XX0pBVtq0-EFdnS-7wt0_6g");

            CloudinaryDotNet.Cloudinary cloudinary = new CloudinaryDotNet.Cloudinary(account);

            CloudinaryDotNet.Actions.ImageUploadParams uploadParams = new CloudinaryDotNet.Actions.ImageUploadParams()
            {
                File = new CloudinaryDotNet.FileDescription(@"c:\hornoparante.jpg"),
                // UseFilename=true,

                PublicId = "Hornos/hornoparante",
                //Invalidate = true,
                Tags = "hornoparante, hornos"
            };

            CloudinaryDotNet.Actions.ImageUploadResult uploadResult = cloudinary.Upload(uploadParams);
            string url = cloudinary.Api.UrlImgUp.BuildUrl("hornoparante.jpg");
            Observacion.Text = url;
            //hornoparante.jpg
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CloudinaryDotNet.Account account =
               new CloudinaryDotNet.Account("tecnicor", "145824563393643", "lO63XX0pBVtq0-EFdnS-7wt0_6g");

            CloudinaryDotNet.Cloudinary cloudinary = new CloudinaryDotNet.Cloudinary(account);

            CloudinaryDotNet.Actions.ImageUploadParams uploadParams = new CloudinaryDotNet.Actions.ImageUploadParams()
            {
                File = new CloudinaryDotNet.FileDescription(@"c:\menumaster.jpg"),
                PublicId = "Hornos/menumaster012018",
                //Invalidate = true,
                Tags = "menumasters, hornos"
            };

            CloudinaryDotNet.Actions.ImageUploadResult uploadResult = cloudinary.Upload(uploadParams);
            string url = cloudinary.Api.UrlImgUp.BuildUrl("Hornos/menumaster012018.jpg");
            Observacion.Text = url;
            //hornoparante.jpg
            //picture2.Load(url);
        }

        private void ConTiendaEquipo_Click(object sender, EventArgs e)
        {
            if (ConTiendaEquipo.RowCount == 0)
                return;
            try
            {
                iddirecc.Text = ConTiendaEquipo[0, ConTiendaEquipo.CurrentCell.RowIndex].Value.ToString();

                string SQLSelect = "select ISNULL(VCE.cantidad,0)cantidad,VCE.observacion,ISNULL(VCE.potencia,0)potencia," +
                    " VCE.tipotenc,ISNULL(VCE.pozocantidad,0)pozocantidad,ISNULL(VCE.pozotapas,0)pozotapas " + ""+
                    ",VCE.codigointerno,ISNULL(VCE.idarea,'') AS idarea,AEA.descripcion,VCE.numubicar,VCE.temperatura,VCE.amperaje,VCE.presion,isnull(VCE.tipogas,'')tipogas " +
                    ", VCE.modelo,VCE.serie,VCE.tipoEquipo,ISNULL(MAR.idmarca,'')idmarca,ISNULL(MAR.descripcion,'') Marca" +
                    " from VTAS_CLIENTES_EQUIPOS VCE" +
                    " LEFT JOIN ADMI_EQUIPOS_AREA AEA ON AEA.idarea =VCE.idarea " +
                    "  LEFT JOIN ADMI_MARCAS  MAR ON MAR.idmarca= VCE.idmarca" +
                    " WHERE VCE.idclientequi=@idclientequi and VCE.empresa_id=@empresa_id ";

                conex.ConectarSistema();

                SqlCommand cmdSelect = new SqlCommand(SQLSelect, conex.CON);
                cmdSelect.Parameters.Add("@idclientequi", SqlDbType.Int).Value = iddirecc.Text;
                cmdSelect.Parameters.Add("@empresa_id", SqlDbType.NVarChar,2).Value = clase.tomacodempresa;
                cmdSelect.CommandType = CommandType.Text;
                SqlDataReader RDRSelect = null;
                RDRSelect = cmdSelect.ExecuteReader();
                RDRSelect.Read();
                if (RDRSelect.HasRows == true)
                {
                    cantidad.Text =         RDRSelect["cantidad"    ].ToString();
                    Observacion.Text =      RDRSelect["observacion" ].ToString();
                    potencia.Text =         RDRSelect["potencia"    ].ToString();
                    tipopotencia.Text =     RDRSelect["tipotenc"    ].ToString();
                    pozo.Text =             RDRSelect["pozocantidad"].ToString();
                    tapas.Text =            RDRSelect["pozotapas"].ToString();
                    Codigo.Text =           RDRSelect["codigointerno"].ToString();
                    Area.SelectedValue =    RDRSelect["idarea"].ToString();
                    Area.Text =             RDRSelect["descripcion"].ToString();
                    NumUbica.Text =         RDRSelect["numubicar"].ToString();
                    Temperatura.Text =      RDRSelect["temperatura"].ToString();
                    Amperaje.Text =         RDRSelect["amperaje"].ToString();
                    Presion.Text =          RDRSelect["presion"].ToString();
                    Tipogas.Text =          RDRSelect["tipogas"].ToString();
                    Modelo.Text =           RDRSelect["modelo"].ToString();
                    Serie.Text =            RDRSelect["serie"].ToString();
                    Tipoequipo.Text =       RDRSelect["tipoEquipo"].ToString();
                    Marca.SelectedValue=    RDRSelect["idmarca"].ToString();
                    Tipogas.Text =          RDRSelect["Marca"].ToString();

                    Codigo.Focus();

                    /*
                    //    IMAGEN A
                    if (RDRSelect["imagen1"] != System.DBNull.Value)
                    {
                        byte[] arrA = (byte[])RDRSelect["imagen1"];
                        MemoryStream msA = new MemoryStream(arrA);
                        msA.Seek(0, SeekOrigin.Begin);
                        picture1.Image = Image.FromStream(msA);
                    }
                    else
                    {
                        picture1.Image = null;
                    }

                    //    IMAGEN B

                    if (RDRSelect["imagen2"] != System.DBNull.Value)
                    {
                        byte[] arrB = (byte[])RDRSelect["imagen2"];
                        MemoryStream msB = new MemoryStream(arrB);
                        msB.Seek(0, SeekOrigin.Begin);
                        picture2.Image = Image.FromStream(msB);
                    }
                    else
                    {
                        picture2.Image = null;
                    }
                    */

                }
                RDRSelect.Close();
                cmdSelect.Dispose();
                conex.DesconectarSistema();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
           

        }

        private void cantidad_TextChanged(object sender, EventArgs e)
        {
            cantidad.Text = new string(cantidad.Text.Where(c => (char.IsDigit(c)) || (c == '.')).ToArray());
        }

        private void potencia_TextChanged(object sender, EventArgs e)
        {
            potencia.Text = new string(potencia.Text.Where(c => (char.IsDigit(c)) || (c == '.')).ToArray());
        }

        private void pozo_TextChanged(object sender, EventArgs e)
        {
            pozo.Text = new string(pozo.Text.Where(c => (char.IsDigit(c)) || (c == '.')).ToArray());
        }

        private void tapas_TextChanged(object sender, EventArgs e)
        {
            tapas.Text = new string(tapas.Text.Where(c => (char.IsDigit(c)) || (c == '.')).ToArray());
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // var TuplaImagen = limage.DialogoImagen(picture2);
          //  Rutaima2 = TuplaImagen.Item1;
           // Foto2 = 1;
        }

        private void picture1_DoubleClick(object sender, EventArgs e)
        {
         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void picture2_DoubleClick(object sender, EventArgs e)
        {
    
        }

        private void tipocat_SelectionChangeCommitted(object sender, EventArgs e)
        {
     
        }

        private void Tienda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EquiposEnTienda();
        }

        private void Temperatura_TextChanged(object sender, EventArgs e)
        {
            Temperatura.Text = new string(Temperatura.Text.Where(c => (char.IsDigit(c)) || (c == '.')|| (c=='-')).ToArray());
        }

        private void Amperaje_TextChanged(object sender, EventArgs e)
        {
            Amperaje.Text = new string(Amperaje.Text.Where(c => (char.IsDigit(c)) || (c == '.')).ToArray());
        }

        private void Presion_TextChanged(object sender, EventArgs e)
        {
          //  Presion.Text = new string(Presion.Text.Where(c => (char.IsDigit(c)) || (c == '.') || (c == '-')).ToArray());
        }

        private void cargar_Click(object sender, EventArgs e)
        {
          //  var TuplaImagen = limage.DialogoImagen(picture1);
          //  Rutaima1 = TuplaImagen.Item1;
          //  Foto1 = 1;

        }
        private void Limpiar()
        {
            cantidad.Clear();
            Observacion.Clear();
            potencia.Clear();
            pozo.Clear();
            tapas.Clear();
          //  picture1.Image = null;
            //picture2.Image = null;
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Serie_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
