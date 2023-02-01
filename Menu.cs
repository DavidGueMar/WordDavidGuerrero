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


            Documento doc = new Documento();
            doc.MdiParent = this;
            doc.Text = doc.abrir();
            //doc.abrir();
            doc.Show();




        }



        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instancia necesaria para acceder a la propiedad text del rtb del documento con el focus
            Documento formActivo = (Documento)ActiveMdiChild;


            SaveFileDialog archivo = new SaveFileDialog();
            StreamWriter miArchivo = null;

            archivo.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            archivo.Title = "Guardar como...";
            archivo.ShowDialog();

            String ruta = archivo.FileName;
            miArchivo = File.AppendText(ruta);
            miArchivo.Write(formActivo.getRtbDocumento());
            miArchivo.Flush();



            MessageBox.Show(formActivo.getRtbDocumento());
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar el formulario", "Salir del la aplicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }

        }
    }
}
