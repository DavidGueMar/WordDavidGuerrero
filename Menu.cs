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
     



        public Menu()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documento doc = new Documento();

          
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

        private void rehacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documento formActivo = (Documento)ActiveMdiChild;
            formActivo.rehacer();
        }

        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documento formActivo = (Documento)ActiveMdiChild;
            formActivo.deshacer();
        }

        private void formatoTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documento formActivo = (Documento)ActiveMdiChild;
            formActivo.formato();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documento formActivo = (Documento)ActiveMdiChild;
            formActivo.copiar();

        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documento formActivo = (Documento)ActiveMdiChild;
            formActivo.cortar();
        }

        private void seleccionartodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documento formActivo = (Documento)ActiveMdiChild;
            formActivo.seleccionarTodo();
        }

        private void borrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documento formActivo = (Documento)ActiveMdiChild;
            formActivo.borrarTodo();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documento formActivo = (Documento)ActiveMdiChild;
            formActivo.pegar();
        }

        private void colorTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documento formActivo = (Documento)ActiveMdiChild;
            formActivo.colorTexto(); 
        }

        private void colorFondoFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documento formActivo = (Documento)ActiveMdiChild;
            formActivo.colorFonfo();
        }

        //IMPORTANTE MARIMAR!! PARA CAMBIAR EL COLOR DEL "SUBRAYADO DEL TEXTO" Tienes que seleccionar primero el texto que quieres subrayar con el ratón 
        private void colorFondoTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documento formActivo = (Documento)ActiveMdiChild;
            formActivo.colorFondoTexto();
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void listaDeDocumentosAbiertosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.ArrangeIcons);
        }
    }
}
