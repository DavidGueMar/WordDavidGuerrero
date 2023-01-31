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
    public partial class Menu : Form
    {
        int contador = 1;

        public Menu()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contador++;
            Documento doc = new Documento();
            // doc.Text = "Documento " + contador;
            doc.MdiParent = this;
            doc.Text = "Documento " + this.MdiChildren.Length.ToString();
            doc.Show();
        }


        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guardarcomoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*   Form hijoActivo = this.ActiveMdiChild;
               Documento formActivo = (Documento)ActiveMdiChild;
               String texto = formActivo.rtbDocumento.Text;
            */
            Documento doc = new Documento();
            String texto = doc.getRtbDocumento();

            SaveFileDialog archivo = new SaveFileDialog();
            StreamWriter miArchivo = null;

            archivo.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            archivo.Title = "Guardar como...";
            archivo.ShowDialog();

            String ruta = archivo.FileName;
            miArchivo = File.AppendText(ruta);
            miArchivo.Write(texto);
            miArchivo.Flush();

            MessageBox.Show(texto);
        }


    }
}
