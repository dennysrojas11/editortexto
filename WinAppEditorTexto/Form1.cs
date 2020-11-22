using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEditorTexto
{
    public partial class FormEditorTexto : Form
    {
        public FormEditorTexto()
        {
            InitializeComponent();
        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            string texto;
            openFileDialogAbrir.ShowDialog();
            System.IO.StreamReader archivo = new System.IO.StreamReader(openFileDialogAbrir.FileName);
            texto = archivo.ReadLine();
            richTextBoxTexto.Text = texto.ToString();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            saveFileDialogGuardar.FileName = "ArchivoNuevo.txt";
            var guardar = saveFileDialogGuardar.ShowDialog();
            if (guardar == DialogResult.OK) {
                using (var guardarArchivo = new System.IO.StreamWriter(saveFileDialogGuardar.FileName)) {
                    guardarArchivo.WriteLine(richTextBoxTexto.Text);
                }
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void color_Click(object sender, EventArgs e)
        {
            var color = colorDialogColor.ShowDialog();
            if (color == DialogResult.OK) {
                richTextBoxTexto.ForeColor = colorDialogColor.Color;
            }
        }

        private void color2_Click(object sender, EventArgs e)
        {
            
        }

        private void tipofuente_Click(object sender, EventArgs e)
        {
            var fuente = fontDialogFuente.ShowDialog();
            if (fuente == DialogResult.OK)
            {
                richTextBoxTexto.Font = fontDialogFuente.Font;
            }
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void tamaño2_Click(object sender, EventArgs e)
        {

        }

        private void tamaño2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBoxTexto.SelectedText != "") {
                richTextBoxTexto.SelectionFont = new Font(richTextBoxTexto.Font.SystemFontName, float.Parse(tamaño2.SelectedItem.ToString()));
            }
        }

        private void negrita_Click(object sender, EventArgs e)
        {
            if (richTextBoxTexto.SelectedText != "") {
                richTextBoxTexto.SelectionFont = new Font(richTextBoxTexto.Font.SystemFontName, float.Parse(tamaño2.SelectedItem.ToString()),FontStyle.Bold);
            }
        }

        private void cursiva_Click(object sender, EventArgs e)
        {
            if (richTextBoxTexto.SelectedText != "")
            {
                richTextBoxTexto.SelectionFont = new Font(richTextBoxTexto.Font.SystemFontName, float.Parse(tamaño2.SelectedItem.ToString()), FontStyle.Italic);
            }
        }

        private void subrayado_Click(object sender, EventArgs e)
        {
            if (richTextBoxTexto.SelectedText != "")
            {
                richTextBoxTexto.SelectionFont = new Font(richTextBoxTexto.Font.SystemFontName, float.Parse(tamaño2.SelectedItem.ToString()), FontStyle.Underline);
            }
        }

        private void izquierda_Click(object sender, EventArgs e)
        {
            if (richTextBoxTexto.SelectedText != "")
            {
                richTextBoxTexto.SelectionAlignment=HorizontalAlignment.Left ;
            }
        }

        private void centro_Click(object sender, EventArgs e)
        {
            if (richTextBoxTexto.SelectedText != "")
            {
                richTextBoxTexto.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        private void derecha_Click(object sender, EventArgs e)
        {
            if (richTextBoxTexto.SelectedText != "")
            {
                richTextBoxTexto.SelectionAlignment = HorizontalAlignment.Right;
            }
        }
    }
}
