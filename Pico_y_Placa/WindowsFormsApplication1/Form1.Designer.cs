namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblmensaje2 = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.mTxtFecha = new System.Windows.Forms.MaskedTextBox();
            this.mTxtHora = new System.Windows.Forms.MaskedTextBox();
            this.mTxtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFormatoFecha = new System.Windows.Forms.Label();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.lblFormatoFecha);
            this.grpDatos.Controls.Add(this.lblmensaje2);
            this.grpDatos.Controls.Add(this.lblMensaje);
            this.grpDatos.Controls.Add(this.mTxtFecha);
            this.grpDatos.Controls.Add(this.mTxtHora);
            this.grpDatos.Controls.Add(this.mTxtPlaca);
            this.grpDatos.Controls.Add(this.btnSalir);
            this.grpDatos.Controls.Add(this.btnConsultar);
            this.grpDatos.Controls.Add(this.lblHora);
            this.grpDatos.Controls.Add(this.lblFecha);
            this.grpDatos.Controls.Add(this.lblPlaca);
            this.grpDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatos.Location = new System.Drawing.Point(25, 61);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(426, 233);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Ingreso de datos";
            // 
            // lblmensaje2
            // 
            this.lblmensaje2.AutoSize = true;
            this.lblmensaje2.Location = new System.Drawing.Point(36, 174);
            this.lblmensaje2.Name = "lblmensaje2";
            this.lblmensaje2.Size = new System.Drawing.Size(0, 13);
            this.lblmensaje2.TabIndex = 14;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(36, 150);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 13;
            // 
            // mTxtFecha
            // 
            this.mTxtFecha.Location = new System.Drawing.Point(194, 47);
            this.mTxtFecha.Mask = "00-00-0000";
            this.mTxtFecha.Name = "mTxtFecha";
            this.mTxtFecha.Size = new System.Drawing.Size(100, 20);
            this.mTxtFecha.TabIndex = 2;
            this.mTxtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mTxtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // mTxtHora
            // 
            this.mTxtHora.Location = new System.Drawing.Point(194, 73);
            this.mTxtHora.Mask = "00:00";
            this.mTxtHora.Name = "mTxtHora";
            this.mTxtHora.Size = new System.Drawing.Size(100, 20);
            this.mTxtHora.TabIndex = 3;
            this.mTxtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mTxtPlaca
            // 
            this.mTxtPlaca.Location = new System.Drawing.Point(194, 20);
            this.mTxtPlaca.Mask = "AAA - 0000";
            this.mTxtPlaca.Name = "mTxtPlaca";
            this.mTxtPlaca.Size = new System.Drawing.Size(100, 20);
            this.mTxtPlaca.TabIndex = 1;
            this.mTxtPlaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(231, 109);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(135, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(57, 109);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(135, 23);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(44, 73);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(38, 13);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "Hora:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(44, 48);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(44, 22);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(118, 13);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa del vehículo:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(127, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(222, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Verificador de Pico y Placa";
            // 
            // lblFormatoFecha
            // 
            this.lblFormatoFecha.AutoSize = true;
            this.lblFormatoFecha.Location = new System.Drawing.Point(304, 51);
            this.lblFormatoFecha.Name = "lblFormatoFecha";
            this.lblFormatoFecha.Size = new System.Drawing.Size(89, 13);
            this.lblFormatoFecha.TabIndex = 15;
            this.lblFormatoFecha.Text = "MM/DD/YYYY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 307);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grpDatos);
            this.Name = "Form1";
            this.Text = "Verificador Pico y Placa";
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.MaskedTextBox mTxtPlaca;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MaskedTextBox mTxtHora;
        private System.Windows.Forms.MaskedTextBox mTxtFecha;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblmensaje2;
        private System.Windows.Forms.Label lblFormatoFecha;
    }
}

