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
    public partial class MenuPrincipalVisor : Form
    {
        public MenuPrincipalVisor()
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

        private void MenuPrincipalVisor_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarAplicacion(e);
        }

        private void generarVistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistasReportes_Visor form = new VistasReportes_Visor();
            form.Show();
            this.Dispose();
        }
    }
}
