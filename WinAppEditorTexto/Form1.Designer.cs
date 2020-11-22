
namespace WinAppEditorTexto
{
    partial class FormEditorTexto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditorTexto));
            this.richTextBoxTexto = new System.Windows.Forms.RichTextBox();
            this.menuStripEditor = new System.Windows.Forms.MenuStrip();
            this.archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.Abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.Guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.Cerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.estilo = new System.Windows.Forms.ToolStripMenuItem();
            this.negrita = new System.Windows.Forms.ToolStripMenuItem();
            this.cursiva = new System.Windows.Forms.ToolStripMenuItem();
            this.subrayado = new System.Windows.Forms.ToolStripMenuItem();
            this.fuente = new System.Windows.Forms.ToolStripMenuItem();
            this.tipofuente = new System.Windows.Forms.ToolStripMenuItem();
            this.color = new System.Windows.Forms.ToolStripMenuItem();
            this.alineación = new System.Windows.Forms.ToolStripMenuItem();
            this.izquierda = new System.Windows.Forms.ToolStripMenuItem();
            this.centro = new System.Windows.Forms.ToolStripMenuItem();
            this.derecha = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEditor = new System.Windows.Forms.ToolStrip();
            this.negrita2 = new System.Windows.Forms.ToolStripButton();
            this.cursiva2 = new System.Windows.Forms.ToolStripButton();
            this.subrayado2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tamaño2 = new System.Windows.Forms.ToolStripComboBox();
            this.color2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.izquierda2 = new System.Windows.Forms.ToolStripButton();
            this.centro2 = new System.Windows.Forms.ToolStripButton();
            this.derecha2 = new System.Windows.Forms.ToolStripButton();
            this.openFileDialogAbrir = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogGuardar = new System.Windows.Forms.SaveFileDialog();
            this.fontDialogFuente = new System.Windows.Forms.FontDialog();
            this.colorDialogColor = new System.Windows.Forms.ColorDialog();
            this.menuStripEditor.SuspendLayout();
            this.toolStripEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxTexto
            // 
            this.richTextBoxTexto.Location = new System.Drawing.Point(17, 85);
            this.richTextBoxTexto.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxTexto.Name = "richTextBoxTexto";
            this.richTextBoxTexto.Size = new System.Drawing.Size(873, 405);
            this.richTextBoxTexto.TabIndex = 4;
            this.richTextBoxTexto.Text = "";
            // 
            // menuStripEditor
            // 
            this.menuStripEditor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivo,
            this.estilo,
            this.fuente,
            this.alineación});
            this.menuStripEditor.Location = new System.Drawing.Point(0, 0);
            this.menuStripEditor.Name = "menuStripEditor";
            this.menuStripEditor.Size = new System.Drawing.Size(908, 28);
            this.menuStripEditor.TabIndex = 5;
            this.menuStripEditor.Text = "menuStrip1";
            // 
            // archivo
            // 
            this.archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Abrir,
            this.Guardar,
            this.Cerrar});
            this.archivo.Image = global::WinAppEditorTexto.Properties.Resources.archivo;
            this.archivo.Name = "archivo";
            this.archivo.Size = new System.Drawing.Size(93, 24);
            this.archivo.Text = "&Archivo";
            // 
            // Abrir
            // 
            this.Abrir.Image = global::WinAppEditorTexto.Properties.Resources.abrir;
            this.Abrir.Name = "Abrir";
            this.Abrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.Abrir.Size = new System.Drawing.Size(197, 26);
            this.Abrir.Text = "Abrir";
            this.Abrir.Click += new System.EventHandler(this.Abrir_Click);
            // 
            // Guardar
            // 
            this.Guardar.Image = global::WinAppEditorTexto.Properties.Resources.guardar;
            this.Guardar.Name = "Guardar";
            this.Guardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.Guardar.Size = new System.Drawing.Size(197, 26);
            this.Guardar.Text = "Guardar";
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Image = global::WinAppEditorTexto.Properties.Resources.cerrar;
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.Cerrar.Size = new System.Drawing.Size(197, 26);
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // estilo
            // 
            this.estilo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negrita,
            this.cursiva,
            this.subrayado});
            this.estilo.Image = global::WinAppEditorTexto.Properties.Resources.estilo;
            this.estilo.Name = "estilo";
            this.estilo.Size = new System.Drawing.Size(79, 24);
            this.estilo.Text = "&Estilo";
            // 
            // negrita
            // 
            this.negrita.Image = global::WinAppEditorTexto.Properties.Resources.negrita;
            this.negrita.Name = "negrita";
            this.negrita.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.negrita.Size = new System.Drawing.Size(224, 26);
            this.negrita.Text = "Negrita";
            this.negrita.Click += new System.EventHandler(this.negrita_Click);
            // 
            // cursiva
            // 
            this.cursiva.Image = global::WinAppEditorTexto.Properties.Resources.cursiva;
            this.cursiva.Name = "cursiva";
            this.cursiva.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.cursiva.Size = new System.Drawing.Size(224, 26);
            this.cursiva.Text = "Cursiva";
            this.cursiva.Click += new System.EventHandler(this.cursiva_Click);
            // 
            // subrayado
            // 
            this.subrayado.Image = global::WinAppEditorTexto.Properties.Resources.subrayado;
            this.subrayado.Name = "subrayado";
            this.subrayado.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.subrayado.Size = new System.Drawing.Size(224, 26);
            this.subrayado.Text = "Subrayado";
            this.subrayado.Click += new System.EventHandler(this.subrayado_Click);
            // 
            // fuente
            // 
            this.fuente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipofuente,
            this.color});
            this.fuente.Image = global::WinAppEditorTexto.Properties.Resources.fuente;
            this.fuente.Name = "fuente";
            this.fuente.Size = new System.Drawing.Size(87, 24);
            this.fuente.Text = "&Fuente";
            // 
            // tipofuente
            // 
            this.tipofuente.Image = global::WinAppEditorTexto.Properties.Resources.tipofuente;
            this.tipofuente.Name = "tipofuente";
            this.tipofuente.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tipofuente.Size = new System.Drawing.Size(238, 26);
            this.tipofuente.Text = "Tipo de fuente";
            this.tipofuente.Click += new System.EventHandler(this.tipofuente_Click);
            // 
            // color
            // 
            this.color.Image = global::WinAppEditorTexto.Properties.Resources.color;
            this.color.Name = "color";
            this.color.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.color.Size = new System.Drawing.Size(238, 26);
            this.color.Text = "Color";
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // alineación
            // 
            this.alineación.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izquierda,
            this.centro,
            this.derecha});
            this.alineación.Image = global::WinAppEditorTexto.Properties.Resources.alineacion;
            this.alineación.Name = "alineación";
            this.alineación.Size = new System.Drawing.Size(113, 24);
            this.alineación.Text = "Alineación";
            // 
            // izquierda
            // 
            this.izquierda.Image = global::WinAppEditorTexto.Properties.Resources.izquierda;
            this.izquierda.Name = "izquierda";
            this.izquierda.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.izquierda.Size = new System.Drawing.Size(224, 26);
            this.izquierda.Text = "Izquierda";
            this.izquierda.Click += new System.EventHandler(this.izquierda_Click);
            // 
            // centro
            // 
            this.centro.Image = global::WinAppEditorTexto.Properties.Resources.centro;
            this.centro.Name = "centro";
            this.centro.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.centro.Size = new System.Drawing.Size(224, 26);
            this.centro.Text = "Centro";
            this.centro.Click += new System.EventHandler(this.centro_Click);
            // 
            // derecha
            // 
            this.derecha.Image = global::WinAppEditorTexto.Properties.Resources.derecha;
            this.derecha.Name = "derecha";
            this.derecha.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.derecha.Size = new System.Drawing.Size(224, 26);
            this.derecha.Text = "Derecha";
            this.derecha.Click += new System.EventHandler(this.derecha_Click);
            // 
            // toolStripEditor
            // 
            this.toolStripEditor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negrita2,
            this.cursiva2,
            this.subrayado2,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.tamaño2,
            this.color2,
            this.toolStripSeparator2,
            this.izquierda2,
            this.centro2,
            this.derecha2});
            this.toolStripEditor.Location = new System.Drawing.Point(0, 28);
            this.toolStripEditor.Name = "toolStripEditor";
            this.toolStripEditor.Size = new System.Drawing.Size(908, 28);
            this.toolStripEditor.TabIndex = 6;
            this.toolStripEditor.Text = "toolStrip1";
            // 
            // negrita2
            // 
            this.negrita2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.negrita2.Image = global::WinAppEditorTexto.Properties.Resources.negrita;
            this.negrita2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.negrita2.Name = "negrita2";
            this.negrita2.Size = new System.Drawing.Size(29, 25);
            this.negrita2.Text = "Negrita";
            this.negrita2.Click += new System.EventHandler(this.negrita_Click);
            // 
            // cursiva2
            // 
            this.cursiva2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cursiva2.Image = global::WinAppEditorTexto.Properties.Resources.cursiva;
            this.cursiva2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cursiva2.Name = "cursiva2";
            this.cursiva2.Size = new System.Drawing.Size(29, 25);
            this.cursiva2.Text = "Cursiva";
            this.cursiva2.Click += new System.EventHandler(this.cursiva_Click);
            // 
            // subrayado2
            // 
            this.subrayado2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.subrayado2.Image = global::WinAppEditorTexto.Properties.Resources.subrayado;
            this.subrayado2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.subrayado2.Name = "subrayado2";
            this.subrayado2.Size = new System.Drawing.Size(29, 25);
            this.subrayado2.Text = "Subrayado";
            this.subrayado2.Click += new System.EventHandler(this.subrayado_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::WinAppEditorTexto.Properties.Resources.tipofuente;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.tipofuente_Click);
            // 
            // tamaño2
            // 
            this.tamaño2.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "24",
            "28",
            "36",
            "48",
            "72"});
            this.tamaño2.Name = "tamaño2";
            this.tamaño2.Size = new System.Drawing.Size(160, 28);
            this.tamaño2.SelectedIndexChanged += new System.EventHandler(this.tamaño2_SelectedIndexChanged);
            this.tamaño2.Click += new System.EventHandler(this.tamaño2_Click);
            // 
            // color2
            // 
            this.color2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.color2.Image = global::WinAppEditorTexto.Properties.Resources.color;
            this.color2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(29, 25);
            this.color2.Text = "Color";
            this.color2.Click += new System.EventHandler(this.color_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // izquierda2
            // 
            this.izquierda2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.izquierda2.Image = global::WinAppEditorTexto.Properties.Resources.izquierda;
            this.izquierda2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.izquierda2.Name = "izquierda2";
            this.izquierda2.Size = new System.Drawing.Size(29, 25);
            this.izquierda2.Text = "Izquierda";
            this.izquierda2.Click += new System.EventHandler(this.izquierda_Click);
            // 
            // centro2
            // 
            this.centro2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.centro2.Image = global::WinAppEditorTexto.Properties.Resources.centro;
            this.centro2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.centro2.Name = "centro2";
            this.centro2.Size = new System.Drawing.Size(29, 25);
            this.centro2.Text = "Centro";
            this.centro2.Click += new System.EventHandler(this.centro_Click);
            // 
            // derecha2
            // 
            this.derecha2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.derecha2.Image = global::WinAppEditorTexto.Properties.Resources.derecha;
            this.derecha2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.derecha2.Name = "derecha2";
            this.derecha2.Size = new System.Drawing.Size(29, 25);
            this.derecha2.Text = "Derecha";
            this.derecha2.Click += new System.EventHandler(this.derecha_Click);
            // 
            // openFileDialogAbrir
            // 
            this.openFileDialogAbrir.FileName = "openFileDialog1";
            // 
            // FormEditorTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(908, 506);
            this.Controls.Add(this.toolStripEditor);
            this.Controls.Add(this.richTextBoxTexto);
            this.Controls.Add(this.menuStripEditor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripEditor;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEditorTexto";
            this.Text = "Editor de texto";
            this.menuStripEditor.ResumeLayout(false);
            this.menuStripEditor.PerformLayout();
            this.toolStripEditor.ResumeLayout(false);
            this.toolStripEditor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBoxTexto;
        private System.Windows.Forms.MenuStrip menuStripEditor;
        private System.Windows.Forms.ToolStripMenuItem archivo;
        private System.Windows.Forms.ToolStripMenuItem Abrir;
        private System.Windows.Forms.ToolStripMenuItem Guardar;
        private System.Windows.Forms.ToolStripMenuItem Cerrar;
        private System.Windows.Forms.ToolStripMenuItem estilo;
        private System.Windows.Forms.ToolStripMenuItem negrita;
        private System.Windows.Forms.ToolStripMenuItem cursiva;
        private System.Windows.Forms.ToolStripMenuItem subrayado;
        private System.Windows.Forms.ToolStripMenuItem fuente;
        private System.Windows.Forms.ToolStripMenuItem tipofuente;
        private System.Windows.Forms.ToolStripMenuItem color;
        private System.Windows.Forms.ToolStripMenuItem alineación;
        private System.Windows.Forms.ToolStripMenuItem izquierda;
        private System.Windows.Forms.ToolStripMenuItem centro;
        private System.Windows.Forms.ToolStripMenuItem derecha;
        private System.Windows.Forms.ToolStrip toolStripEditor;
        private System.Windows.Forms.ToolStripButton negrita2;
        private System.Windows.Forms.ToolStripButton cursiva2;
        private System.Windows.Forms.ToolStripButton subrayado2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox tamaño2;
        private System.Windows.Forms.ToolStripButton color2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton izquierda2;
        private System.Windows.Forms.ToolStripButton centro2;
        private System.Windows.Forms.ToolStripButton derecha2;
        private System.Windows.Forms.OpenFileDialog openFileDialogAbrir;
        private System.Windows.Forms.SaveFileDialog saveFileDialogGuardar;
        private System.Windows.Forms.FontDialog fontDialogFuente;
        private System.Windows.Forms.ColorDialog colorDialogColor;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

