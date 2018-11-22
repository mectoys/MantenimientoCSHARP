using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMantto
{
    class loadFiles
    {
        private const int Megas = (1024 * 1024);
        string RutaImagen;
        string Extension;
        string NombreFile;
        public Tuple<string, string,string> DialogoArchivo()
        {

            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Archivo|*.docx;*.doc;*.pdf;*.xls;*.xlsx";

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                var len = new FileInfo(openfile.FileName).Length;
                // NombreArchivo = new FileInfo(openfile.FileName).Name;
              
                //evaluo que no sea mas de un mega el archivo
                if (len > Megas)
                {
                    MessageBox.Show("Se admite archivos menores a 1MB", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    // picture.Image = null;

                }
                else
                {                   
                    NombreFile = Path.GetFileName(openfile.FileName);
                    Extension = Path.GetExtension(openfile.FileName);
                    RutaImagen = openfile.FileName;
                }


            }

            return new Tuple<string, string, string>(NombreFile, Extension, RutaImagen);
        }


    }
}
