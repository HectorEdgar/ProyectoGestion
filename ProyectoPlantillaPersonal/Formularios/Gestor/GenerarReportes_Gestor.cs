﻿using ProyectoPlantillaPersonal.Controladores;
using ProyectoPlantillaPersonal.Formularios.Gestor;
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
    public partial class GenerarReportes_Gestor : Form
    {
        private ModeloPlantilla modeloPlantilla;
        private ModeloPlantillaHistorial modeloPlantillaHistorial;

        private List<Plantilla> listaPlantilla = new List<Plantilla>();
        private List<PlantillaHistorial> listaPlantillaHistorial = new List<PlantillaHistorial>();

        private bool isPlantilla = true;

        public GenerarReportes_Gestor()
        {
            InitializeComponent();
            modeloPlantilla = new ModeloPlantilla();
            modeloPlantillaHistorial = new ModeloPlantillaHistorial();
        }

        private void cmdReporte_Click(object sender, EventArgs e)
        {
            listaPlantilla = new List<Plantilla>();
            listaPlantillaHistorial = new List<PlantillaHistorial>();

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

                isPlantilla = true;
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

                isPlantilla = false;
            }
        }

        private void configurarDGVVistaP(List<Plantilla> listaPlantilla)
        {
            dgvVista.DataSource = listaPlantilla;

            cmdReporte.Enabled = listaPlantilla.Count > 0;

            dgvVista.Columns["idPlantilla"].Visible = false;
            dgvVista.Columns["idClavePresupuestal"].Visible = false;
            dgvVista.Columns["idRelacionLaboral"].Visible = false;
            dgvVista.Columns["idSector"].Visible = false;
            dgvVista.Columns["idStatus"].Visible = false;
        }

        private void configurarDGVVistaPH(List<PlantillaHistorial> listaPlantillaHistorial)
        {
            dgvVista.DataSource = listaPlantillaHistorial;

            cmdReporte.Enabled = listaPlantillaHistorial.Count > 0;

            dgvVista.Columns["idPlantillaHistorial"].Visible = false;
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

            comboPlantilla.SelectedIndex = 0;
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

        private void cmdVista_Click(object sender, EventArgs e)
        {
            listaPlantilla = new List<Plantilla>();
            listaPlantillaHistorial = new List<PlantillaHistorial>();

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

                isPlantilla = true;
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

                isPlantilla = false;
            }

            if (listaPlantilla.Count > 0 || listaPlantillaHistorial.Count > 0)
            {
                cmdReporte.Enabled = true;
            }
        }

        private void cmdReporte_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Son correctos los datos mostrados en la\ntabla para generar el reporte?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ControladorReportes controladorReportes = new ControladorReportes();
                if (isPlantilla)
                {
                    controladorReportes.generarReporte(listaPlantilla);
                }
                else
                {
                    controladorReportes.generarReporte(listaPlantillaHistorial);
                }
            }
        }
    }
}
