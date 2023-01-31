
namespace WordDavidGuerrero
{
    partial class Documento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbDocumento = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbDocumento
            // 
            this.rtbDocumento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDocumento.Location = new System.Drawing.Point(0, 0);
            this.rtbDocumento.Name = "rtbDocumento";
            this.rtbDocumento.Size = new System.Drawing.Size(437, 341);
            this.rtbDocumento.TabIndex = 0;
            this.rtbDocumento.Text = "";
            // 
            // Documento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 341);
            this.Controls.Add(this.rtbDocumento);
            this.Name = "Documento";
            this.Text = "Documento";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDocumento;
    }
}