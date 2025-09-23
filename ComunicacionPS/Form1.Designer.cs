namespace ComunicacionPS
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.cmbPuerto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rchRecibido = new System.Windows.Forms.RichTextBox();
            this.txtEnviar = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serialPortArduino = new System.IO.Ports.SerialPort(this.components);
            this.btnActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbPuerto
            // 
            this.cmbPuerto.FormattingEnabled = true;
            this.cmbPuerto.Location = new System.Drawing.Point(31, 36);
            this.cmbPuerto.Name = "cmbPuerto";
            this.cmbPuerto.Size = new System.Drawing.Size(364, 28);
            this.cmbPuerto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puerto";
            // 
            // rchRecibido
            // 
            this.rchRecibido.Location = new System.Drawing.Point(31, 105);
            this.rchRecibido.Name = "rchRecibido";
            this.rchRecibido.Size = new System.Drawing.Size(641, 261);
            this.rchRecibido.TabIndex = 2;
            this.rchRecibido.Text = "";
            // 
            // txtEnviar
            // 
            this.txtEnviar.Location = new System.Drawing.Point(35, 413);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(502, 26);
            this.txtEnviar.TabIndex = 3;
            this.txtEnviar.TextChanged += new System.EventHandler(this.txtEnviar_TextChanged);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Enabled = false;
            this.btnEnviar.Location = new System.Drawing.Point(573, 403);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(99, 46);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(408, 28);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(129, 42);
            this.btnConectar.TabIndex = 5;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enviar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Respuesta";
            // 
            // serialPortArduino
            // 
            this.serialPortArduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortArduino_DataReceived);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(543, 28);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(129, 42);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 523);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtEnviar);
            this.Controls.Add(this.rchRecibido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPuerto);
            this.Name = "Form1";
            this.Text = "Comunicacion Serie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPuerto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rchRecibido;
        private System.Windows.Forms.TextBox txtEnviar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.IO.Ports.SerialPort serialPortArduino;
        private System.Windows.Forms.Button btnActualizar;
    }
}

