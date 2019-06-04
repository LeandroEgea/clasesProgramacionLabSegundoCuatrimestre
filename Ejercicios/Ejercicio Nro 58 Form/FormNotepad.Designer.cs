namespace Ejercicio_Nro_56
{
    partial class FormNotepad
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.archivoMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GuardarMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.caracteresStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainMenuStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoMenuStripItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(568, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // archivoMenuStripItem
            // 
            this.archivoMenuStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirMenuStripItem,
            this.GuardarMenuStripItem,
            this.guardarComoMenuStripItem});
            this.archivoMenuStripItem.Name = "archivoMenuStripItem";
            this.archivoMenuStripItem.Size = new System.Drawing.Size(60, 20);
            this.archivoMenuStripItem.Text = "Archivo";
            // 
            // abrirMenuStripItem
            // 
            this.abrirMenuStripItem.Name = "abrirMenuStripItem";
            this.abrirMenuStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrirMenuStripItem.Size = new System.Drawing.Size(231, 22);
            this.abrirMenuStripItem.Text = "Abrir";
            this.abrirMenuStripItem.Click += new System.EventHandler(this.abrirMenuStripItem_Click);
            // 
            // GuardarMenuStripItem
            // 
            this.GuardarMenuStripItem.Name = "GuardarMenuStripItem";
            this.GuardarMenuStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.GuardarMenuStripItem.Size = new System.Drawing.Size(231, 22);
            this.GuardarMenuStripItem.Text = "Guardar";
            this.GuardarMenuStripItem.Click += new System.EventHandler(this.GuardarMenuStripItem_Click);
            // 
            // guardarComoMenuStripItem
            // 
            this.guardarComoMenuStripItem.Name = "guardarComoMenuStripItem";
            this.guardarComoMenuStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.guardarComoMenuStripItem.Size = new System.Drawing.Size(231, 22);
            this.guardarComoMenuStripItem.Text = "Guardar como...";
            this.guardarComoMenuStripItem.Click += new System.EventHandler(this.guardarComoMenuStripItem_Click);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caracteresStatusStrip});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 313);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(568, 22);
            this.mainStatusStrip.TabIndex = 1;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // caracteresStatusStrip
            // 
            this.caracteresStatusStrip.Name = "caracteresStatusStrip";
            this.caracteresStatusStrip.Size = new System.Drawing.Size(0, 17);
            // 
            // mainRichTextBox
            // 
            this.mainRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainRichTextBox.Location = new System.Drawing.Point(0, 24);
            this.mainRichTextBox.Name = "mainRichTextBox";
            this.mainRichTextBox.Size = new System.Drawing.Size(568, 289);
            this.mainRichTextBox.TabIndex = 2;
            this.mainRichTextBox.Text = "";
            this.mainRichTextBox.TextChanged += new System.EventHandler(this.mainRichTextBox_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Archivos de texto(.txt)|*.txt|Archivos de datos (.dat)|*.dat|Archivos XML(.xml)|*" +
    ".xml";
            this.openFileDialog.InitialDirectory = "c:\\\\";
            this.openFileDialog.RestoreDirectory = true;
            this.openFileDialog.ShowReadOnly = true;
            this.openFileDialog.Title = "Open";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "Archivos de texto(.txt)|*.txt|Archivos de datos (.dat)|*.dat|Archivos XML(.xml)|*" +
    ".xml";
            this.saveFileDialog.Title = "Guardar como";
            // 
            // FormNotepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 335);
            this.Controls.Add(this.mainRichTextBox);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "FormNotepad";
            this.Text = "Notepad";
            this.Load += new System.EventHandler(this.FormNotepad_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem archivoMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem abrirMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem GuardarMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoMenuStripItem;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.RichTextBox mainRichTextBox;
        private System.Windows.Forms.ToolStripStatusLabel caracteresStatusStrip;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

