using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Xml.Linq;
using System.Threading;

namespace runnerManager
{
    public partial class runnerManagerForm : Form
    {
        private webappDBDataContext webappDB;
        private System.ServiceProcess.ServiceController sc;
        private Socket conexion;
        private Socket server;
        private int conexionesServidos;

        private static int puertoIn = 5959;
        private static int puertoOut = 1990;

        public runnerManagerForm()
        {
            InitializeComponent();
            sc = new System.ServiceProcess.ServiceController("runnerService");
            webappDB = new webappDBDataContext();
            conexionesServidos = 0;
            
            initServerSocketListener();
            Thread tServer = new Thread(new ThreadStart(serverSocketThread));
            tServer.Start();            
            timerUpdateSimGrid.Start();
        }

        private void setDisplay()
        {
            svcState_toolStripStatusLabel.Text = sc.Status.ToString();
            if (sc.Status == System.ServiceProcess.ServiceControllerStatus.Running)
            {
                startsvc_button.Enabled = false;
                stopsvc_button.Enabled = true;
            }
            else
            {
                startsvc_button.Enabled = true;
                stopsvc_button.Enabled = false;
            }
        }

        private void startsvc_button_Click(object sender, EventArgs e)
        {
            if (sc.Status != System.ServiceProcess.ServiceControllerStatus.Running)
            {
                try
                {
                    sc.Start();
                    svcState_toolStripStatusLabel.Text = "Iniciando...";
                    sc.WaitForStatus(System.ServiceProcess.ServiceControllerStatus.Running);
                    setDisplay();
                }
                catch (Exception error)
                {
                    svcState_toolStripStatusLabel.Text = "ERROR al iniciar:" + error;
                }
            }
        }

        private void stopsvc_button_Click(object sender, EventArgs e)
        {
            if (sc.Status != System.ServiceProcess.ServiceControllerStatus.Stopped)
            {
                try
                {
                    sc.Stop();
                    svcState_toolStripStatusLabel.Text = "Parando...";
                    sc.WaitForStatus(System.ServiceProcess.ServiceControllerStatus.Stopped);
                    setDisplay();
                }
                catch (Exception error)
                {
                    svcState_toolStripStatusLabel.Text = "ERROR al parar:" + error;
                }
            }

        }

        private void run_button_Click(object sender, EventArgs e)
        {
            Guid guidSimulacion = Guid.NewGuid();
            string respuesta;
            string comando = guidSimulacion.ToString();
            if (comando == null) comando = "vacio";

            Byte[] sBytes = Encoding.ASCII.GetBytes(comando);
            Byte[] rBytes = new Byte[1024];
            int raw;

            IPEndPoint ipep = new IPEndPoint(
               IPAddress.Parse("127.0.0.1"),
               puertoOut
            );
            conexion = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
            );
            try
            {
                // Conectamos con el servicio
                conexion.Connect(ipep);
                threadLog_listBox.Items.Add("Conectado");


                // Enviamos datos            
                threadLog_listBox.Items.Add("[" + comando + "] Enviando");
                conexion.Send(sBytes);

                // Esperamos confirmación
                threadLog_listBox.Items.Add("[" + comando + "] Esperando confirmación");
                raw = conexion.Receive(rBytes);
                respuesta = System.Text.Encoding.ASCII.GetString(rBytes, 0, raw);

                if (respuesta.Equals(comando))
                {
                    threadLog_listBox.Items.Add("[" + comando + "] Confirmación correcta");
                }
                else
                {
                    threadLog_listBox.Items.Add("[" + comando + "] Confirmación errónea");
                }

                // Cerrando conexión.
                conexion.Close();
            }
            catch (Exception error)
            {
                threadLog_listBox.Items.Add("[ERROR]" + error);
            }

        }

        private void runnerManagerForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_C__USERS_DANI_DOCUMENTS_VISUAL_STUDIO_2010_PROJECTS_RUNNERSVC_RUNNERSVC_BIN_DEBUG_WEBAPPDB_MDFDataSet1.EstadoSimulacion' Puede moverla o quitarla según sea necesario.
            this.estadoSimulacionTableAdapter.Fill(this._C__USERS_DANI_DOCUMENTS_VISUAL_STUDIO_2010_PROJECTS_RUNNERSVC_RUNNERSVC_BIN_DEBUG_WEBAPPDB_MDFDataSet1.EstadoSimulacion);
            // TODO: esta línea de código carga datos en la tabla '_C__USERS_DANI_DOCUMENTS_VISUAL_STUDIO_2010_PROJECTS_RUNNERSVC_RUNNERSVC_BIN_DEBUG_WEBAPPDB_MDFDataSet.VistaSimulación' Puede moverla o quitarla según sea necesario.
            this.vistaSimulaciónTableAdapter.Fill(this._C__USERS_DANI_DOCUMENTS_VISUAL_STUDIO_2010_PROJECTS_RUNNERSVC_RUNNERSVC_BIN_DEBUG_WEBAPPDB_MDFDataSet.VistaSimulación);
        }

        private void timerUpdateSimGrid_Tick(object sender, EventArgs e)
        {
            setDisplay();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = this.vistaSimulaciónBindingSource;
            dataGridView1.Refresh();
            simsState_toolStripStatusLabel.Text = DateTime.Now.ToShortTimeString();
            countSim_label.Text = conexionesServidos.ToString();
        }

        private void initServerSocketListener()
        {

            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, puertoIn);
            server = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp);

            server.Bind(ipep);
            server.Listen(10);
            threadLog_listBox.Items.Add("[SERVER SOCKET] Initialized");
        }

        private void serverSocketThread()
        {
            while (true)
            {
                try
                {
                    // Esperamos que el servicio Windows contacte con nosotros
                    conexion = server.Accept();
                    conexionesServidos += 1;

                    // Preparamos lo necesario para la recepción de datos
                    byte[] rBytes = new byte[1024];
                    byte[] sBytes = new byte[1024];
                    int raw;
                    string datos;

                    // Recibimos los datos
                    raw = conexion.Receive(rBytes);
                    datos = System.Text.Encoding.ASCII.GetString(rBytes, 0, raw);

                    // Confirmar al servicio la recepción de los datos
                    sBytes = Encoding.ASCII.GetBytes(datos);
                    conexion.Send(sBytes);

                    // Parseamos el XML y lo guardamos
                    XDocument datosSimulacion = XDocument.Parse(datos);                    
                    datosSimulacion.Save("C:\\demonio_received_xml.xml");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        private void changeState_button_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection filas = dataGridView1.SelectedRows;
            EstadoSimulacion es = webappDB.EstadoSimulacion.Where(state => state.idEstadoSimulacion.Equals(simStates_comboBox.SelectedValue)).Single();
            Simulacion simulation;
            String oldEs, newEs;
            foreach (DataGridViewRow f in filas)
            {
                simulation = webappDB.Simulacion
                    .Where( 
                        s=> 
                        s.nombre
                            .Equals( 
                            f.Cells[0].Value.ToString()
                        )
                    )
                    .Single();
                oldEs = simulation.EstadoSimulacion.nombre;
                newEs = es.nombre;
                simulation.EstadoSimulacion = es;
                threadLog_listBox.Items.Add(simulation.nombre + ": " + oldEs + " a " + newEs);
            }
            webappDB.SubmitChanges();
        }        
    }
}
