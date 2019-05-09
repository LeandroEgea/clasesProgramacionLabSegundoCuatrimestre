namespace Ejercicio_Nro_40_Form
{
    partial class FrmMenu
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
            this.btnLlamada = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnLocal = new System.Windows.Forms.Button();
            this.btnProvincial = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLlamada
            // 
            this.btnLlamada.Location = new System.Drawing.Point(12, 32);
            this.btnLlamada.Name = "btnLlamada";
            this.btnLlamada.Size = new System.Drawing.Size(286, 58);
            this.btnLlamada.TabIndex = 0;
            this.btnLlamada.Text = "Generar Llamada";
            this.btnLlamada.UseVisualStyleBackColor = true;
            this.btnLlamada.Click += new System.EventHandler(this.btnLlamada_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(12, 96);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(286, 58);
            this.btnTotal.TabIndex = 1;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnLocal
            // 
            this.btnLocal.Location = new System.Drawing.Point(12, 160);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(286, 58);
            this.btnLocal.TabIndex = 2;
            this.btnLocal.Text = "Local";
            this.btnLocal.UseVisualStyleBackColor = true;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // btnProvincial
            // 
            this.btnProvincial.Location = new System.Drawing.Point(12, 224);
            this.btnProvincial.Name = "btnProvincial";
            this.btnProvincial.Size = new System.Drawing.Size(286, 58);
            this.btnProvincial.TabIndex = 3;
            this.btnProvincial.Text = "Provincial";
            this.btnProvincial.UseVisualStyleBackColor = true;
            this.btnProvincial.Click += new System.EventHandler(this.btnProvincial_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 288);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(286, 58);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 379);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnProvincial);
            this.Controls.Add(this.btnLocal);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnLlamada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central Telefonica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLlamada;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.Button btnProvincial;
        private System.Windows.Forms.Button btnSalir;
    }
}

