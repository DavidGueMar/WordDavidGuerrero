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
        public Documento(RichTextBox richTextBoxDoc)
        {
            this.rtbDocumento = richTextBoxDoc;
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

        public void rehacer()
        {
            rtbDocumento.Redo();
        }
        public void deshacer()
        {
            rtbDocumento.Undo();
        }
      

        public void copiar()
        {
            rtbDocumento.Copy();
        }

        public void cortar()
        {
            rtbDocumento.Cut();
        }

        public void seleccionarTodo()
        {
            rtbDocumento.SelectAll();
        }

        public void borrarTodo()
        {
            rtbDocumento.Clear();
        }

        public void pegar()
        {
            rtbDocumento.Paste();
        }


        public void colorTexto()
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                rtbDocumento.ForeColor = color.Color;
            }
        }

        public void colorFonfo()
        {
            ColorDialog fondo = new ColorDialog();
            if(fondo.ShowDialog()== DialogResult.OK)
            {
                rtbDocumento.BackColor = fondo.Color;
            }
        }

        public void colorFondoTexto()
        {
            ColorDialog fondoFuente = new ColorDialog();
            if (fondoFuente.ShowDialog() == DialogResult.OK)
            {
                rtbDocumento.SelectionBackColor = fondoFuente.Color;
                
            }
        }

        public void formato()
        {
            FontDialog fuente = new FontDialog();

            fuente.Font = rtbDocumento.Font;
            if (fuente.ShowDialog() == DialogResult.OK)
            {
                rtbDocumento.Font = fuente.Font;
            }
        }


    }
}
