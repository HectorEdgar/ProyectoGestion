using ProyectoPlantillaPersonal.Controladores;
using ProyectoPlantillaPersonal.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPlantillaPersonal.Formularios.Administrador
{
    public partial class GenerarReportes : Form
    {
        private ModeloPlantilla modeloPlantilla;
        private ModeloPlantillaHistorial modeloPlantillaHistorial;

        public GenerarReportes()
        {
            InitializeComponent();
            modeloPlantilla = new ModeloPlantilla();
            modeloPlantillaHistorial = new ModeloPlantillaHistorial();
        }

        private void cmdReporte_Click(object sender, EventArgs e)
        {
            List<Plantilla> listaPlantilla = new List<Plantilla>();
            List<PlantillaHistorial> listaPlantillaHistorial = new List<PlantillaHistorial>();

            if (comboPlantilla.SelectedIndex == 0)
            {
                listaPlantilla =
                modeloPlantilla.seleccionarPorPropiedad(
                    txtNup.Text, txtNup.Text != "" ? true : false,
                    txtRfc.Text, txtRfc.Text != "" ? true : false,
                    txtCp.Text, txtCp.Text != "" ? true : false
                );

                Func<Plantilla, bool> funcSeleccionAno = p => {
                    if (radioDesde.Checked)
                    {
                        if (p.NMFING.Year >= nudAno.Value)
                        {
                            return true;
                        }
                    }

                    if (radioHasta.Checked)
                    {
                        if (p.NMFING.Year <= nudAno.Value)
                        {
                            return true;
                        }
                    }

                    return false;
                };

                listaPlantilla = listaPlantilla.Where(funcSeleccionAno).ToList();
                configurarDGVVistaP(listaPlantilla);
            }
            else if (comboPlantilla.SelectedIndex == 1)
            {
                listaPlantillaHistorial =
                modeloPlantillaHistorial.seleccionarPorPropiedad(
                    txtNup.Text, txtNup.Text != "" ? true : false,
                    txtNup.Text, txtNup.Text != "" ? true : false,
                    txtRfc.Text, txtRfc.Text != "" ? true : false,
                    txtCp.Text, txtCp.Text != "" ? true : false
                );

                Func<PlantillaHistorial, bool> funcSeleccionAno = ph => {
                    if (radioDesde.Checked)
                    {
                        if (ph.NMFING.Year >= nudAno.Value)
                        {
                            return true;
                        }
                    }

                    if (radioHasta.Checked)
                    {
                        if (ph.NMFING.Year <= nudAno.Value)
                        {
                            return true;
                        }
                    }

                    return false;
                };

                listaPlantillaHistorial = listaPlantillaHistorial.Where(funcSeleccionAno).ToList();
                configurarDGVVistaPH(listaPlantillaHistorial);
            }

            if (MessageBox.Show("¿Son correctos los datos mostrados en la\ntabla para generar el reporte?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Entramos!");
                ControladorReportes controladorReportes = new ControladorReportes();
                controladorReportes.generarReporte(listaPlantilla);
                
            }
        }

        private void configurarDGVVistaP(List<Plantilla> listaPlantilla)
        {
            dgvVista.DataSource = listaPlantilla;

            dgvVista.Columns["idClavePresupuestal"].Visible = false;
            dgvVista.Columns["idRelacionLaboral"].Visible = false;
            dgvVista.Columns["idSector"].Visible = false;
            dgvVista.Columns["idStatus"].Visible = false;
        }

        private void configurarDGVVistaPH(List<PlantillaHistorial> listaPlantillaHistorial)
        {
            dgvVista.DataSource = listaPlantillaHistorial;

            dgvVista.Columns["idClavePresupuestal"].Visible = false;
            dgvVista.Columns["idRelacionLaboral"].Visible = false;
            dgvVista.Columns["idSector"].Visible = false;
            dgvVista.Columns["idStatus"].Visible = false;
        }

        private void cerrarAplicacion(FormClosedEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void cerrarSesion()
        {
            Application.OpenForms["Loggin"].Visible = true;
            this.Visible = false;
            this.Dispose();
        }

        private void GenerarReportes_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarAplicacion(e);
        }

        private void cerrarSesiónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cerrarSesion();
        }

        private void GenerarReportes_Load(object sender, EventArgs e)
        {
            nudAno.Maximum = DateTime.Today.Year;
            nudAno.Value = DateTime.Today.Year;
        }

        private void cerrarSesiónToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            cerrarSesion();
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
        

        private void importarDatosEnExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //List<List<String>> listas = new List<List<String>>();
            //for (int i = 0; i < 10; i++)
            //{
            //    List<string> lista = new List<string>();
            //    for (int j = 0; j < 10; j++)
            //    {
            //        lista.Add(""+i+"-"+j);
            //    }
            //    listas.Add(lista);
            //}
            //Excel ex = new Excel();
            //ex.cargarDatos(listas);
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
    }
}
