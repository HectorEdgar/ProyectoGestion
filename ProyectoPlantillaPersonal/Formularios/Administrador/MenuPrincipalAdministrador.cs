using ProyectoPlantillaPersonal.Controladores;
using ProyectoPlantillaPersonal.Formularios.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPlantillaPersonal.Formularios
{
    public partial class MenuPrincipalAdministrador : Form
    {
        public MenuPrincipalAdministrador()
        {
            InitializeComponent();
        }

        private void cerrarSesion() {
            Application.OpenForms["Loggin"].Visible = true;
            this.Visible = false;
            this.Dispose();
        }
        private void cerrarAplicacion(FormClosedEventArgs e) {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void cerrarSesiónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cerrarSesion();
        }

        private void MenuPrincipalAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarAplicacion(e);
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
        private void agregarCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirCuentaAgregar();
        }

        private void importarDatosEnExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {

            abrirAdministradorCargarDatos();
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
    }
}
