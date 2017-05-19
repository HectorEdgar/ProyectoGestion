using ProyectoPlantillaPersonal.Formularios.Administrador;
using ProyectoPlantillaPersonal.Formularios.Gestor;
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
    public partial class MenuPrincipalGestor : Form
    {
        public MenuPrincipalGestor()
        {
            InitializeComponent();
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

        private void cerrarSesiónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cerrarSesion();
        }

        private void MenuPrincipalGestor_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarAplicacion(e);
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

        private void cerrarSesiónToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            cerrarSesion();
        }
    }
}
