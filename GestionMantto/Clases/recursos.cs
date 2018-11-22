using Microsoft.Win32;
using System;
using System.Windows.Forms;


namespace GestionMantto
{
    public class recursos
    {
        public static string CODUSUARIO;
        private static string CODEMPRESA;
        private static string NOMBREEMPRESA;
        private static string QUERYGENERAL;
        private static decimal compra, venta;
        private static int numsolicitud;
        private static int tipoaprobacion;
        private static decimal igv;
        private static bool paraisofiscal;
        private static decimal retencionporcent;
        public int ConsultaFechas;
        //variable para el formulario de consulta entre fechas 
        public static int TipoConsultFecha;
        //variable para el formulario CON_FactMensual doble funcion
        public static int TipoConsultaxAño;

        NotifyIcon Notificar = new NotifyIcon();



        public string GetSetting(string appName, string section, string Key, string sDefault)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"Software\VB and VBA Program Settings\" +
                                                                  appName + "\\" + section);

            string s = sDefault;
            if (rk != null)
                s = (string)rk.GetValue(Key);
            return s;
        }


        public void Validar_progvaca_1(DataGridView dgriddatos)
        {
            if (dgriddatos.Rows.Count == 0)
            {
                MessageBox.Show("Sin registros para continuar.");
                return;
            }


        }
        public void NorificadorBalloonTextoEX(String Mensaje)
        {
            Notificar.BalloonTipText = Mensaje;
            Notificar.BalloonTipIcon = ToolTipIcon.Info;
            Notificar.BalloonTipTitle = Application.ProductName;
            Notificar.ShowBalloonTip(1000);
        }

        public decimal RetencionPorcent
        {
            get { return retencionporcent; }
            set { retencionporcent = value; }
        }

        public decimal Compra
        {

            get { return compra; }
            set { compra = value; }

        }
        public decimal Venta
        {

            get { return venta; }
            set { venta = value; }

        }

        public bool ParaisoFiscal
        {

            get { return paraisofiscal; }
            set { paraisofiscal = value; }

        }

        public decimal Igv
        {

            get { return igv; }

            set { igv = value; }

        }

        public int TipoAprobacion
        {
            get { return tipoaprobacion; }
            set { tipoaprobacion = value; }
        }

        public int Numsolicitud
        {
            get { return numsolicitud; }

            set { numsolicitud = value; }

        }

        public string tomaqueryGeneral
        {
            get
            {
                return QUERYGENERAL;
            }
        }

        public void DamequeryGeneral(string varquerygeneral)
        {
            QUERYGENERAL = varquerygeneral;
        }

        public string tomacodempresa
        {
            get
            {
                return CODEMPRESA;
            }
        }

        public void Damecodempresa(String varcodempresa)
        {
            CODEMPRESA = varcodempresa;
        }

        public string tomanombrempresa
        {
            get
            {
                return NOMBREEMPRESA;
            }
        }
        public void Damenombrempresa(String varnombrempresa)
        {
            NOMBREEMPRESA = varnombrempresa;
        }

        public string tomacoduser
        {
            get
            {
                return CODUSUARIO;
            }
        }

        public void Damecoduser(String varcodusuario)
        {
            CODUSUARIO = varcodusuario;
        }


        private string Mycodusua;

        public string Mypropcodusua
        {
            get { return Mycodusua; }
            set { Mycodusua = value; }

        }


    }
}
