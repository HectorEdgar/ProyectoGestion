using ProyectoPlantillaPersonal.Controladores;
using ProyectoPlantillaPersonal.Formularios.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPlantillaPersonal.Formularios.Gestor
{
    public partial class GestorCargarDatos : Form
    {
        ControladorPlantillaPersonal controlador { get; set; }

        public String ruta;
        public bool visible;
        public GestorCargarDatos()
        {
            InitializeComponent();
            lblCarga.Visible = false;
            pnlCarga.Visible = false;
            btnCargarDatos.Enabled = false;
        }
        public Thread hilo;
        public Thread hilo2;

        public void cargarDatos()
        {


            controlador.obtenerDatos(ruta, visible, progressBar1, lblNum);



            controlador.AgregarPlantillaPersonal();

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "Archivos Excel|*.xlsx;*.xls";
            openFileDialog1.Title = "Selecciona un archivo Excel";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                //ControladorPlantillaPersonal control = new ControladorPlantillaPersonal();

                String ruta = openFileDialog1.FileName;
                this.ruta = ruta;
                txtRuta.Text = ruta;
                //Excel excel = new Excel(ruta,true);

                //control.AgregarPlantillaPersonal(ruta,true);

                controlador = new ControladorPlantillaPersonal();

                progressBar1.Maximum = controlador.ContarElementos(ruta) - 1;
                progressBar1.Minimum = 0;
                progressBar1.Value = 0;
                lblNum.Text = "" + progressBar1.Minimum + " / " + progressBar1.Maximum;
                pnlCarga.Visible = true;
                btnCargarDatos.Enabled = true;
                lblCarga.Text = "Presione el botón Cargar Datos para continuar...";
                lblCarga.Visible = true;
                openFileDialog1.Dispose();
            }
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            lblCarga.Visible = true;
            pnlCarga.Visible = true;
            lblCarga.Text = "Cargando datos...";
            cargarDatos();
            this.ruta = "";
            txtRuta.Text = "";
            lblCarga.Text = "Carga completa";
            //pnlCarga.Visible = false;
            btnCargarDatos.Enabled = false;
            MessageBox.Show("Se ha completado la carga de datos");
        }

        
        public void abrirGestorCargarDatos()
        {
            GestorCargarDatos form = new GestorCargarDatos();
            form.Show();
            this.Dispose();
        }
        public void abrirGestorBuscar()
        {
            BuscarGestor form = new BuscarGestor();
            form.Show();
            this.Dispose();
        }
        public void abrirGestorGenerarReportes()
        {
            GenerarReportes_Gestor form = new GenerarReportes_Gestor();
            form.Show();
            this.Dispose();
        }
        public void abrirVistasReportes()
        {
            VistasReportes_Gestor form = new VistasReportes_Gestor();
            form.Show();
            this.Dispose();
        }
        private void cerrarSesion()
        {
            Application.OpenForms["Loggin"].Visible = true;
            this.Visible = false;
            this.Dispose();
        }
        private void cerrarAplicacion(FormClosedEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }


        private void importarDatosEnExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirGestorCargarDatos();
        }

        private void plantillaDePersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirGestorBuscar();
        }

        private void generarReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirGestorGenerarReportes();
        }

        private void generarVistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirVistasReportes();
        }

        private void cerrarSesiónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cerrarSesion();
        }
    }
}
