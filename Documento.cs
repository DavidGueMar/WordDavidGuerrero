using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordDavidGuerrero
{
    public partial class Documento : Form
    {
        public Documento()
        {
            InitializeComponent();
        }

      public string getRtbDocumento()
        {
            String texto = rtbDocumento.Text.ToString();
            return texto;

        }

        public void setRtbDocumento(String texto)
        {
            rtbDocumento.Text = texto;
        }
        public string nombre = " ";

        public string abrir()
        {
            try {
                OpenFileDialog miFichero = new OpenFileDialog();
                StreamReader myLector = null;

                miFichero.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                miFichero.Title = "Abrir archivo";
                miFichero.ShowDialog();
                miFichero.OpenFile();
                String ruta = miFichero.FileName;

                myLector = File.OpenText(ruta);
                rtbDocumento.Text = myLector.ReadToEnd();

                nombre = miFichero.FileName;
                return nombre;
            }
            catch
            {
                MessageBox.Show("No puedes abrir ese fichero");
                return nombre;
            }
            
        }

        public void cerrar()
        {
            Close();
        }
    }
}
