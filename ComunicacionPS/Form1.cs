using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics.Eventing.Reader;

namespace ComunicacionPS
{
    public partial class Form1 : Form
    {
        Datos data= new Datos();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActulizarPuerto();
        }

        private void ActulizarPuerto()
        {
            cmbPuerto.Items.Clear();
            String[] puertos = SerialPort.GetPortNames();
            if (puertos.Length > 0)
            {
                foreach (String puerto in puertos)
                {
                    cmbPuerto.Items.Add(puerto);
                }

            }
            else
            {
                MessageBox.Show("No se encontraron puertos COM " +
                    "disponibles", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                serialPortArduino.PortName = cmbPuerto.Text;
                serialPortArduino.Open();
                MessageBox.Show("Conexion Exitosa", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActulizarPuerto();
        }

        private void serialPortArduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string datos = serialPortArduino.ReadExisting();
                this.Invoke(new MethodInvoker(delegate ()
                {
                    rchRecibido.Text += datos;
                    data.GuardarDatos(datos);
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                serialPortArduino.WriteLine(txtEnviar.Text);
                rchRecibido.Text += rchRecibido.Text + txtEnviar.Text;
                txtEnviar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEnviar_TextChanged(object sender, EventArgs e)
        {
            if (txtEnviar.Text.Length > 0)
            {
                btnEnviar.Enabled = true;
            }
            else
            {
                btnEnviar.Enabled = false;
            }
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            bool f=data.GuardarDatos("20.00");
            if (f == true)
            {
                MessageBox.Show("Guardado Exitoso");

            }
            else
                MessageBox.Show("Error");

        }
    }
}
