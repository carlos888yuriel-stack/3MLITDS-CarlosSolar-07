using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;//libreria de comunicacion serial

namespace _3MLITDS_CarlosSolar_06_262
{
    public partial class Form1 : Form
    {

        public SerialPort ArduinoPort { get; }
        public Form1()
        {
            InitializeComponent();
            //configuracion de comunicacion SERIAL
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM9"; //verificar con la configuracion de su equipo
            ArduinoPort.BaudRate = 9600; 
            ArduinoPort.Open();
            //manejador de eventos
            this.FormClosing += CerrandoForm1;
            this.btnencender.Click += btnencender_Click;
            this.btnapagar.Click += btnapagar_Click;
        }   
        private void CerrandoForm1(object sender, EventArgs e)
        {
         if (ArduinoPort.IsOpen)
            {
                ArduinoPort.Close();
            }
        }

        private void btnapagar_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("a");
        }

        private void btnencender_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("b");
        }
    }
}
