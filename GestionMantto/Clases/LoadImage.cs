using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMantto
{
    class LoadImage
    {
        private const int Megas = (1024 * 1024);
        string RutaImagen;
        string Extension;
        public Tuple<string, string> DialogoImagen(PictureBox pic)
        {

            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "JPG Imagen|*.jpg;*.png;*.gif";

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                var len = new FileInfo(openfile.FileName).Length;
                // NombreArchivo = new FileInfo(openfile.FileName).Name;
                Extension = Path.GetExtension(openfile.FileName);
                //evaluo que no sea mas de un mega el archivo
                if (len > Megas)
                {
                    MessageBox.Show("Se admite imagenes menores a 1MB", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    // picture.Image = null;

                }
                else
                {
                    pic.Image = Image.FromFile(openfile.FileName);
                    RutaImagen = openfile.FileName;

                }


            }

            return new Tuple<string, string>(RutaImagen, Extension);
        }
    }
}