namespace Ejercicio_Nro_40_Form
{
    partial class FrmLlamador
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
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbFranja = new System.Windows.Forms.ComboBox();
            this.grbPanel = new System.Windows.Forms.GroupBox();
            this.btnNumeral = new System.Windows.Forms.Button();
            this.btnAsterisco = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.grbPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDestino
            // 
            this.txtDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.Location = new System.Drawing.Point(22, 30);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(288, 26);
            this.txtDestino.TabIndex = 0;
            this.txtDestino.Text = "Numero Destino";
            // 
            // btnLlamar
            // 
            this.btnLlamar.Location = new System.Drawing.Point(218, 77);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(92, 23);
            this.btnLlamar.TabIndex = 1;
            this.btnLlamar.Text = "Llamar";
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(218, 106);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 23);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(218, 135);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(92, 20);
            this.txtOrigen.TabIndex = 3;
            this.txtOrigen.Text = "Origen";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(218, 162);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cmbFranja
            // 
            this.cmbFranja.FormattingEnabled = true;
            this.cmbFranja.Location = new System.Drawing.Point(13, 204);
            this.cmbFranja.Name = "cmbFranja";
            this.cmbFranja.Size = new System.Drawing.Size(297, 21);
            this.cmbFranja.TabIndex = 5;
            // 
            // grbPanel
            // 
            this.grbPanel.Controls.Add(this.btnNumeral);
            this.grbPanel.Controls.Add(this.btnAsterisco);
            this.grbPanel.Controls.Add(this.btn0);
            this.grbPanel.Controls.Add(this.btn9);
            this.grbPanel.Controls.Add(this.btn8);
            this.grbPanel.Controls.Add(this.btn7);
            this.grbPanel.Controls.Add(this.btn6);
            this.grbPanel.Controls.Add(this.btn5);
            this.grbPanel.Controls.Add(this.btn4);
            this.grbPanel.Controls.Add(this.btn3);
            this.grbPanel.Controls.Add(this.btn2);
            this.grbPanel.Controls.Add(this.btn1);
            this.grbPanel.Location = new System.Drawing.Point(22, 77);
            this.grbPanel.Name = "grbPanel";
            this.grbPanel.Size = new System.Drawing.Size(117, 108);
            this.grbPanel.TabIndex = 6;
            this.grbPanel.TabStop = false;
            this.grbPanel.Text = "Panel";
            // 
            // btnNumeral
            // 
            this.btnNumeral.Location = new System.Drawing.Point(90, 77);
            this.btnNumeral.Name = "btnNumeral";
            this.btnNumeral.Size = new System.Drawing.Size(22, 23);
            this.btnNumeral.TabIndex = 11;
            this.btnNumeral.Text = "#";
            this.btnNumeral.UseVisualStyleBackColor = true;
            this.btnNumeral.Click += new System.EventHandler(this.botonPanel_Click);
            // 
            // btnAsterisco
            // 
            this.btnAsterisco.Location = new System.Drawing.Point(62, 77);
            this.btnAsterisco.Name = "btnAsterisco";
            this.btnAsterisco.Size = new System.Drawing.Size(22, 23);
            this.btnAsterisco.TabIndex = 10;
            this.btnAsterisco.Text = "*";
            this.btnAsterisco.UseVisualStyleBackColor = true;
            this.btnAsterisco.Click += new System.EventHandler(this.botonPanel_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(34, 77);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(22, 23);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.botonPanel_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(6, 77);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(22, 23);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.botonPanel_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(90, 48);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(22, 23);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.botonPanel_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(62, 48);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(22, 23);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.botonPanel_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(34, 48);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(22, 23);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.botonPanel_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(6, 48);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(22, 23);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.botonPanel_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(90, 19);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(22, 23);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.botonPanel_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(62, 19);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(22, 23);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.botonPanel_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(34, 19);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(22, 23);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.botonPanel_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(6, 19);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(22, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.botonPanel_Click);
            // 
            // FrmLlamador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 248);
            this.Controls.Add(this.grbPanel);
            this.Controls.Add(this.cmbFranja);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnLlamar);
            this.Controls.Add(this.txtDestino);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLlamador";
            this.ShowIcon = false;
            this.Text = "Llamador";
            this.Load += new System.EventHandler(this.FrmLlamador_Load);
            this.grbPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbFranja;
        private System.Windows.Forms.GroupBox grbPanel;
        private System.Windows.Forms.Button btnNumeral;
        private System.Windows.Forms.Button btnAsterisco;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
    }
}