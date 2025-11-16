namespace ArbolesyGrafos
{
    partial class FrmGrafo
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
            this.lblEdificio = new System.Windows.Forms.Label();
            this.tbEdificio = new System.Windows.Forms.TextBox();
            this.btnAgregarEdificio = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblDist = new System.Windows.Forms.Label();
            this.tbDistancia = new System.Windows.Forms.TextBox();
            this.btnAgregarConexion = new System.Windows.Forms.Button();
            this.btnMostrarAdyacencias = new System.Windows.Forms.Button();
            this.btnValidarConexidad = new System.Windows.Forms.Button();
            this.btnRutaCorta = new System.Windows.Forms.Button();
            this.cmbEdificioA = new System.Windows.Forms.ComboBox();
            this.cmbEdificioB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblEdificio
            // 
            this.lblEdificio.AutoSize = true;
            this.lblEdificio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdificio.Location = new System.Drawing.Point(33, 70);
            this.lblEdificio.Name = "lblEdificio";
            this.lblEdificio.Size = new System.Drawing.Size(85, 25);
            this.lblEdificio.TabIndex = 0;
            this.lblEdificio.Text = "Edificio: ";
            // 
            // tbEdificio
            // 
            this.tbEdificio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEdificio.Location = new System.Drawing.Point(124, 70);
            this.tbEdificio.Name = "tbEdificio";
            this.tbEdificio.Size = new System.Drawing.Size(354, 30);
            this.tbEdificio.TabIndex = 1;
            // 
            // btnAgregarEdificio
            // 
            this.btnAgregarEdificio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEdificio.Location = new System.Drawing.Point(525, 54);
            this.btnAgregarEdificio.Name = "btnAgregarEdificio";
            this.btnAgregarEdificio.Size = new System.Drawing.Size(147, 62);
            this.btnAgregarEdificio.TabIndex = 2;
            this.btnAgregarEdificio.Text = "Agregar Edificio";
            this.btnAgregarEdificio.UseVisualStyleBackColor = true;
            this.btnAgregarEdificio.Click += new System.EventHandler(this.btnAgregarEdificio_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(27, 220);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(104, 25);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "Edificio A: ";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(27, 287);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(103, 25);
            this.lblB.TabIndex = 4;
            this.lblB.Text = "Edificio B: ";
            // 
            // lblDist
            // 
            this.lblDist.AutoSize = true;
            this.lblDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDist.Location = new System.Drawing.Point(27, 344);
            this.lblDist.Name = "lblDist";
            this.lblDist.Size = new System.Drawing.Size(98, 25);
            this.lblDist.TabIndex = 7;
            this.lblDist.Text = "Distancia:";
            // 
            // tbDistancia
            // 
            this.tbDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDistancia.Location = new System.Drawing.Point(124, 344);
            this.tbDistancia.Name = "tbDistancia";
            this.tbDistancia.Size = new System.Drawing.Size(354, 30);
            this.tbDistancia.TabIndex = 8;
            // 
            // btnAgregarConexion
            // 
            this.btnAgregarConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarConexion.Location = new System.Drawing.Point(525, 325);
            this.btnAgregarConexion.Name = "btnAgregarConexion";
            this.btnAgregarConexion.Size = new System.Drawing.Size(147, 62);
            this.btnAgregarConexion.TabIndex = 9;
            this.btnAgregarConexion.Text = "Agregar Conexión";
            this.btnAgregarConexion.UseVisualStyleBackColor = true;
            this.btnAgregarConexion.Click += new System.EventHandler(this.btnAgregarConexion_Click);
            // 
            // btnMostrarAdyacencias
            // 
            this.btnMostrarAdyacencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarAdyacencias.Location = new System.Drawing.Point(70, 553);
            this.btnMostrarAdyacencias.Name = "btnMostrarAdyacencias";
            this.btnMostrarAdyacencias.Size = new System.Drawing.Size(147, 62);
            this.btnMostrarAdyacencias.TabIndex = 10;
            this.btnMostrarAdyacencias.Text = "Mostrar Adyacencias";
            this.btnMostrarAdyacencias.UseVisualStyleBackColor = true;
            this.btnMostrarAdyacencias.Click += new System.EventHandler(this.btnMostrarAdyacencias_Click);
            // 
            // btnValidarConexidad
            // 
            this.btnValidarConexidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidarConexidad.Location = new System.Drawing.Point(289, 553);
            this.btnValidarConexidad.Name = "btnValidarConexidad";
            this.btnValidarConexidad.Size = new System.Drawing.Size(147, 62);
            this.btnValidarConexidad.TabIndex = 11;
            this.btnValidarConexidad.Text = "Validar Conexidad";
            this.btnValidarConexidad.UseVisualStyleBackColor = true;
            this.btnValidarConexidad.Click += new System.EventHandler(this.btnValidarConexidad_Click);
            // 
            // btnRutaCorta
            // 
            this.btnRutaCorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRutaCorta.Location = new System.Drawing.Point(525, 553);
            this.btnRutaCorta.Name = "btnRutaCorta";
            this.btnRutaCorta.Size = new System.Drawing.Size(147, 62);
            this.btnRutaCorta.TabIndex = 12;
            this.btnRutaCorta.Text = "Ruta mas corta";
            this.btnRutaCorta.UseVisualStyleBackColor = true;
            this.btnRutaCorta.Click += new System.EventHandler(this.btnRutaCorta_Click);
            // 
            // cmbEdificioA
            // 
            this.cmbEdificioA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEdificioA.FormattingEnabled = true;
            this.cmbEdificioA.Location = new System.Drawing.Point(126, 224);
            this.cmbEdificioA.Name = "cmbEdificioA";
            this.cmbEdificioA.Size = new System.Drawing.Size(352, 33);
            this.cmbEdificioA.TabIndex = 13;
            // 
            // cmbEdificioB
            // 
            this.cmbEdificioB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEdificioB.FormattingEnabled = true;
            this.cmbEdificioB.Location = new System.Drawing.Point(126, 284);
            this.cmbEdificioB.Name = "cmbEdificioB";
            this.cmbEdificioB.Size = new System.Drawing.Size(352, 33);
            this.cmbEdificioB.TabIndex = 14;
            // 
            // FrmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 701);
            this.Controls.Add(this.cmbEdificioB);
            this.Controls.Add(this.cmbEdificioA);
            this.Controls.Add(this.btnRutaCorta);
            this.Controls.Add(this.btnValidarConexidad);
            this.Controls.Add(this.btnMostrarAdyacencias);
            this.Controls.Add(this.btnAgregarConexion);
            this.Controls.Add(this.tbDistancia);
            this.Controls.Add(this.lblDist);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnAgregarEdificio);
            this.Controls.Add(this.tbEdificio);
            this.Controls.Add(this.lblEdificio);
            this.Name = "FrmGrafo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGrafo";
            this.Load += new System.EventHandler(this.FrmGrafo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEdificio;
        private System.Windows.Forms.TextBox tbEdificio;
        private System.Windows.Forms.Button btnAgregarEdificio;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblDist;
        private System.Windows.Forms.TextBox tbDistancia;
        private System.Windows.Forms.Button btnAgregarConexion;
        private System.Windows.Forms.Button btnMostrarAdyacencias;
        private System.Windows.Forms.Button btnValidarConexidad;
        private System.Windows.Forms.Button btnRutaCorta;
        private System.Windows.Forms.ComboBox cmbEdificioA;
        private System.Windows.Forms.ComboBox cmbEdificioB;
    }
}