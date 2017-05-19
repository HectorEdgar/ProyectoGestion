using ProyectoPlantillaPersonal.Controladores;
using ProyectoPlantillaPersonal.Eventos;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ProyectoPlantillaPersonal.Formularios.Administrador
{
    public partial class GestorCargarDatos2 : Form
    {
        

        ControladorPlantillaPersonal controlador { get; set; }

        public String ruta;
        public bool visible;
        public GestorCargarDatos2()
        {
            InitializeComponent();
            lblCarga.Visible = false;
            pnlCarga.Visible = false;
            btnCargarDatos.Enabled = false;
            
        }

        public Thread hilo;
        public Thread hilo2;

        public void cargarDatos() {
            
            
            controlador.obtenerDatos(ruta, visible, progressBar1,lblNum);
            
            
            
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
        public void abrirCuentaAgregar()
        {
            CuentaAgregar form = new CuentaAgregar();
            form.Visible = true;
            this.Dispose();
        }
        public void abrirAdministradorCargarDatos()
        {
            GestorCargarDatos2 form = new GestorCargarDatos2();
            form.Show();
            this.Dispose();
        }
        public void abrirAdministradorBuscar()
        {
            AdministradorBuscar form = new AdministradorBuscar();
            form.Show();
            this.Dispose();
        }
        public void abrirAdministradorGenerarReportes()
        {
            GenerarReportes form = new GenerarReportes();
            form.Show();
            this.Dispose();
        }
        public void abrirVistasReportes()
        {
            VistasReportes form = new VistasReportes();
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
            abrirAdministradorCargarDatos();
        }

        private void agregarCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirCuentaAgregar();
        }

        private void plantillaDePersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirAdministradorBuscar();
        }

        private void generarReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirAdministradorGenerarReportes();
        }

        private void generarVistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirVistasReportes();
        }

        private void cerrarSesiónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cerrarSesion();
        }

        private void AdministradorCargarDatos_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarAplicacion(e);
        }
    }
}