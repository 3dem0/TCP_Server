using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO.Ports;
using System.Threading;
namespace Test_TPC_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] puertos = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(puertos);
        }

        TcpListener server = null;

        System.IO.Ports.SerialPort ArduinoPort;

        Int32 port = 13000;

        String codigoVerificacion = "ABD123";
        String CodigoRecibido = "";
        int Servo = 1;
        int Angulo = 90;
        String CadenaRecibida;
        Boolean ServidorOn = false;

        String puerto;
        String baudRateCom;
        String cadena = null;
        Boolean conectadoOk = false;
        int count = 0;
        int Encabezado = 255;
        int Cierre = 254;

        IPAddress localAddr = IPAddress.Parse("127.0.0.1");
        
        
        System.Threading.Thread t;


        private void Form1_Load(object sender, EventArgs e)
        {
            server = new TcpListener(port);
            // TcpListener server = new TcpListener(port);
            server.Start();

            /*
            t = new System.Threading.Thread(recibe);
            t.Start();
            */

        }



        public void recibe()
        {
            if (ServidorOn == true)
            {
                try
                {

                    // Buffer for reading data
                    Byte[] bytes = new Byte[262144];
                    String data = null;
                    // Perform a blocking call to accept requests.
                    // You could also use server.AcceptSocket() here.
                    TcpClient client = server.AcceptTcpClient();
                    //Console.WriteLine("Connected!");
                    data = null;
                    // Get a stream object for reading and writing
                    NetworkStream stream = client.GetStream();
                    int i;
                    // Loop to receive all the data sent by the client.
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        // Translate data bytes to a ASCII string.
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        CadenaRecibida = data;
                        string phrase = CadenaRecibida;
                        string[] words = phrase.Split(',');
                        int contadorSeparador = 0;
                        foreach (var word in words)
                        {
                            if (contadorSeparador == 0)
                            {
                                CodigoRecibido = $"{word}";
                            }
                            if (contadorSeparador == 1)
                            {
                                Servo = Int32.Parse($"{word}");
                            }
                            if (contadorSeparador == 2)
                            {
                                Angulo = Int32.Parse($"{word}");
                                contadorSeparador = 0;
                            }
                            contadorSeparador++;
                        }


                            consola_texto.Text = consola_texto.Text + "\n" + CodigoRecibido;
                            consola_texto.Text = consola_texto.Text + "\n" + Servo;
                            consola_texto.Text = consola_texto.Text + "\n" + Angulo;

                        /*
                        // Process the data sent by the client.
                        data = data.ToUpper();

                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                        */
                        // Send back a response.
                        //stream.Write(msg, 0, msg.Length);
                        //Console.WriteLine("Sent: {0}", data);

                        if (conectadoOk == true)
                        {
                            byte[] EncabezadoByte = { Convert.ToByte(Encabezado) };
                            byte[] ServoByte = { Convert.ToByte(Servo) };
                            byte[] AnguloByte = { Convert.ToByte(Angulo) };
                            byte[] CierreByte = { Convert.ToByte(Cierre) };

                            ArduinoPort.Write(EncabezadoByte, 0, EncabezadoByte.Length);
                            ArduinoPort.Write(ServoByte, 0, ServoByte.Length);
                            ArduinoPort.Write(AnguloByte, 0, AnguloByte.Length);
                            ArduinoPort.Write(CierreByte, 0, CierreByte.Length);
                        }
                    }
                }

                catch
                {
                    //Console.WriteLine("SocketException: {0}", e);
                }
                finally
                {
                    // Stop listening for new clients.
                      server.Stop();
                }


            }

            //return true;
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            recibe();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            ServidorOn = true;
        }

        private void conectar_serie_Click(object sender, EventArgs e)
        {
            conectar();
        }

        private void conectar()
        {
            //crear Serial Port
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = puerto;  //sustituir por vuestro 
            ArduinoPort.BaudRate = Int32.Parse(baudRate.Text);
            ArduinoPort.Open();

            if (ArduinoPort.IsOpen)
            {
                MessageBox.Show("Conectado");
                conectadoOk = true;
            }
            else
            {
                MessageBox.Show("Desconectado");
                conectadoOk = false;
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            puerto = comboBox1.SelectedItem.ToString();
        }
    }
}
