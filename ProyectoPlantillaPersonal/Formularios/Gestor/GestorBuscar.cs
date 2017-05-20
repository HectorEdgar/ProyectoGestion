using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPlantillaPersonal.Modelos;
using ProyectoPlantillaPersonal.Formularios.Administrador;

namespace ProyectoPlantillaPersonal.Formularios.Gestor
{
    



    public partial class BuscarGestor : Form
    {


        public int idPlantillaPo;
        public int idRelacionPo;
        public int idStatusPo;
        public int idSectorPo;
        public int idClavePo;


        public void bloquearCajas()
        {
            cajaNUP2.ReadOnly = true;
            cajaRFC2.ReadOnly = true;
            cajaNMAPP2.ReadOnly = true;
            cajaNMAPM2.ReadOnly = true;
            cajaNIVEL2.ReadOnly = true;
            cajaNMFING2.ReadOnly = true;
            cajaNMNOM2.ReadOnly = true;
            cajaNMNOMB2.ReadOnly = true;
            cajaCVEDEP2.ReadOnly = true;
            cajaCTICCVE2.ReadOnly = true;
            cajaCNOMTIP2.ReadOnly = true;
            cajaCNOMCVE2.ReadOnly = true;
            cajaNQS2.ReadOnly = true;
            cajaSTATUS2.ReadOnly = true;
            cajaCLAVE2.ReadOnly = true;
            cajaSECTOR2.ReadOnly = true;
            cajaRELACION2.ReadOnly = true;
        }

        public AdministradorBuscar()
        {
            ModeloClavePresupuestal m1 = new ModeloClavePresupuestal();
            ModeloRelacionLaboral m2 = new ModeloRelacionLaboral();
            ModeloSector m3 = new ModeloSector();
            ModeloStatus m4 = new ModeloStatus();
            InitializeComponent();
            bloquearCajas();
            //EVENTO PARA EL SCROOLL DE LOS PANELES 1 Y 3
            panel3.TabIndex = 0;
            panel1.TabIndex = 0;

            panel3.AutoScroll = true;
            panel1.AutoScroll = true;

            this.MouseWheel += new MouseEventHandler(panel3_MouseDown);
            this.MouseWheel += new MouseEventHandler(panel1_MouseDown);

            List<ClavePresupuestal> listaClavePresupuesta = m1.seleccionarClavePresupuestal();
            List<Sector> listaSector = m3.seleccionarSector();
            List<Status> listaStatus = m4.seleccionarStatus();
            List<RelacionLaboral> listaRelaciones = m2.seleccionarRelacionLaboral();

            for (int i = 0; i < listaClavePresupuesta.Count(); i++)
            {
                comboClave.Items.Add(listaClavePresupuesta[i].clavePresupuestal1);
            }
            for (int i = 0; i < listaSector.Count(); i++)
            {
                comboSector.Items.Add(listaSector[i].sector1);
            }
            for (int i = 0; i < listaStatus.Count(); i++)
            {
                comboStatus.Items.Add(listaStatus[i].nombreStatus);
            }
            for (int i = 0; i < listaRelaciones.Count(); i++)
            {
                comboRelacionLaboral.Items.Add(listaRelaciones[i].relacionLaboral1);
            }



            this.comboStatus.IntegralHeight = false;
            this.comboStatus.MaxDropDownItems = 3;
            // this.comboStatus.DropDownStyle=ComboBoxStyle.DropDownList;

            this.comboClave.IntegralHeight = false;
            this.comboClave.MaxDropDownItems = 3;
            // this.comboClave.DropDownStyle = ComboBoxStyle.DropDownList;

            this.comboSector.IntegralHeight = false;
            this.comboSector.MaxDropDownItems = 3;
            // this.comboSector.DropDownStyle = ComboBoxStyle.DropDownList;

            this.comboRelacionLaboral.IntegralHeight = false;
            this.comboRelacionLaboral.MaxDropDownItems = 3;
            // this.comboRelacionLaboral.DropDownStyle = ComboBoxStyle.DropDownList;

            /*this.comboClave.MaxDropDownItems = 1;
            this.comboSector.MaxDropDownItems = 1;
            this.comboRelacionLaboral.MaxDropDownItems = 1;
            */
        }

        void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!panel1.Focused)
                panel1.Focus();
        }

        void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (!panel3.Focused)
                panel3.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();
            if (cajaBusqueda.TextLength == 0)
            {
                timer1.Stop();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (cajaBusqueda.Text.Equals(""))
            {
                MessageBox.Show("Ingresa Una NUP PORFAVOR");
            }
            else
            {

                letrero1.Visible = true;
                panel1.Visible = true;
                ModeloPlantilla model = new ModeloPlantilla();
                ModeloSector model2 = new ModeloSector();
                ModeloStatus model3 = new ModeloStatus();
                ModeloRelacionLaboral model5 = new ModeloRelacionLaboral();
                ModeloClavePresupuestal model4 = new ModeloClavePresupuestal();

                try
                {
                    List<Plantilla> plantilla = model.seleccionarPorPropiedad(cajaBusqueda.Text, true, "", false, "", false);
                    Plantilla aux = new Plantilla();
                    foreach (Plantilla p in plantilla)
                    {
                        aux = p;

                    }

                    cajaNUP2.Text = aux.PBPNUE.ToString();
                    cajaRFC2.Text = aux.RFC.ToString();
                    cajaNMAPP2.Text = aux.NMAPP.ToString();
                    cajaNMAPM2.Text = aux.NMAPM.ToString();
                    cajaNIVEL2.Text = aux.NIVEL.ToString();
                    cajaNMFING2.Text = aux.NMFING.ToString();
                    cajaNMNOM2.Text = aux.NMNOM.ToString();
                    cajaNMNOMB2.Text = aux.NMNOMB.ToString();
                    cajaCVEDEP2.Text = aux.CVEDEP.ToString();
                    cajaCTICCVE2.Text = aux.CTICCVE.ToString();
                    cajaCNOMTIP2.Text = aux.CNOMTIP.ToString();
                    cajaCNOMCVE2.Text = aux.CNOMCVE.ToString();
                    cajaNQS2.Text = aux.NQS.ToString();

                    Sector sector = model2.seleccionarSector(aux.idSector);
                    Status status = model3.seleccionarStatus(aux.idStatus);
                    RelacionLaboral relacion = model5.seleccionarRelacionLaboral(aux.idRelacionLaboral);
                    ClavePresupuestal clave = model4.seleccionarClavePresupuestal(aux.idClavePresupuestal);

                    cajaSTATUS2.Text = status.nombreStatus + "";
                    cajaCLAVE2.Text = clave.clavePresupuestal1 + "";
                    cajaSECTOR2.Text = sector.sector1 + "";
                    cajaRELACION2.Text = relacion.relacionLaboral1 + "";

                    idPlantillaPo = aux.idPlantilla;
                    idStatusPo = aux.idStatus;
                    idRelacionPo = aux.idRelacionLaboral;
                    idSectorPo = aux.idSector;
                    idClavePo = aux.idClavePresupuestal;
                    botonModificar.Visible = true;

                    //----SE AGREGARÁ TAMBIEN EN LA PLANTILLA PARA MODIFICACIOÓN
                    //PARA EVITAR EL ERROR
                    cajaNUP1.Text = cajaNUP2.Text;
                    cajaRFC1.Text = cajaRFC2.Text;
                    cajaNMAPP1.Text = cajaNMAPP2.Text;
                    cajaNMAPM1.Text = cajaNMAPM2.Text;
                    cajaNIVEL1.Text = cajaNIVEL2.Text;
                    dateTimePicker1.Value = Convert.ToDateTime(cajaNMFING2.Text);
                    cajaNMNOM1.Text = cajaNMNOM2.Text;
                    cajaNMNOMB1.Text = cajaNMNOMB2.Text;
                    cajaCVEDEP1.Text = cajaCVEDEP2.Text;
                    cajaCTICCVE1.Text = cajaCTICCVE2.Text;
                    cajaCNOMTIP1.Text = cajaCNOMTIP2.Text;
                    cajaCNOMCVE1.Text = cajaCNOMCVE2.Text;
                    cajaNQS1.Text = cajaNQS2.Text;

                    comboStatus.Text = cajaSTATUS2.Text;
                    comboClave.Text = cajaCLAVE2.Text;
                    comboSector.Text = cajaSECTOR2.Text;
                    comboRelacionLaboral.Text = cajaRELACION2.Text;



                }
                catch
                {
                    MessageBox.Show("NUP NO VALIDO");
                }
                cajaBusqueda.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            letrero2.Visible = true;
            string dateString = cajaNMFING2.Text;
            cajaNUP1.Text = cajaNUP2.Text;
            cajaRFC1.Text = cajaRFC2.Text;
            cajaNMAPP1.Text = cajaNMAPP2.Text;
            cajaNMAPM1.Text = cajaNMAPM2.Text;
            cajaNIVEL1.Text = cajaNIVEL2.Text;
            dateTimePicker1.Value = Convert.ToDateTime(cajaNMFING2.Text);
            cajaNMNOM1.Text = cajaNMNOM2.Text;
            cajaNMNOMB1.Text = cajaNMNOMB2.Text;
            cajaCVEDEP1.Text = cajaCVEDEP2.Text;
            cajaCTICCVE1.Text = cajaCTICCVE2.Text;
            cajaCNOMTIP1.Text = cajaCNOMTIP2.Text;
            cajaCNOMCVE1.Text = cajaCNOMCVE2.Text;
            cajaNQS1.Text = cajaNQS2.Text;

            comboStatus.Text = cajaSTATUS2.Text;
            comboClave.Text = cajaCLAVE2.Text;
            comboSector.Text = cajaSECTOR2.Text;
            comboRelacionLaboral.Text = cajaRELACION2.Text;

        }









        private void timer1_Tick(object sender, EventArgs e)
        {

            /*if (!cajaBusqueda.Equals(""))
            {*/
            if (!cajaBusqueda.Text.Equals(""))
            {


                ModeloPlantilla model = new ModeloPlantilla();
                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                List<Plantilla> plantillas = model.coincidenciasNUP(cajaBusqueda.Text, true);
                foreach (Plantilla p in plantillas)
                {

                    string aux = p.PBPNUE.ToString();
                    collection.Add(aux);


                }
                cajaBusqueda.AutoCompleteCustomSource = collection;

            }
            else
            {
                timer1.Enabled = false;
            }

        }



        private void cajaBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                botonBuscar.PerformClick();
            }

        }





        private void button1_Click_1(object sender, EventArgs e)
        {
            bool estanVacias = validarCajasVacias();
            if (!estanVacias)
            {
                MessageBox.Show("Verifica tus Cajas. Hacen falta Datos");
            }
            else
            {



                PlantillaHistorial historial = new PlantillaHistorial();
                ModeloPlantillaHistorial modelo = new ModeloPlantillaHistorial();

                //EL REGISTRO VIEJO TIENE DESPUES UN 2
                //EL REGISTRO NUEVO TIENE DESPUES UN 1

                //------------------  EL VIEJO REGISTRO SE VA AL HISTORIAL ------------------------------------
                historial.idPlantilla = idPlantillaPo;
                //SACALA DEL NUEVO REGISTRO
                ModeloClavePresupuestal modeloClave = new ModeloClavePresupuestal();
                ModeloRelacionLaboral modeloRela = new ModeloRelacionLaboral();
                ModeloSector modeloSector = new ModeloSector();
                ModeloStatus modeloStatus = new ModeloStatus();
                try
                {
                    ClavePresupuestal clave = modeloClave.seleccionarClavePresupuestalPorClave(comboClave.Text);
                    RelacionLaboral relacion = modeloRela.seleccionarRelacionLaboralporNombre(comboRelacionLaboral.Text);
                    Sector sector = modeloSector.seleccionarSectorPorNombre(comboSector.Text);
                    Status status = modeloStatus.seleccionarStatusporNombre(comboStatus.Text);


                    if (clave != null)
                    {
                        // MessageBox.Show("Si esta esa clave");
                        historial.idClavePresupuestal = Convert.ToInt32(clave.idClavePresupuestal);
                    }
                    else
                    {
                        //MessageBox.Show("No esta esa clave");
                        ClavePresupuestal aux = new ClavePresupuestal();
                        aux.clavePresupuestal1 = comboClave.SelectedItem.ToString();
                        modeloClave.insertarClavePresupuestal(aux);
                        ClavePresupuestal claveNueva = modeloClave.seleccionarClavePresupuestalPorClave(comboClave.Text);
                        historial.idClavePresupuestal = Convert.ToInt32(claveNueva.idClavePresupuestal);
                    }

                    if (relacion != null)
                    {
                        //  MessageBox.Show("Si esta esa relacion");
                        historial.idRelacionLaboral = Convert.ToInt32(relacion.idRelacionLaboral);
                    }
                    else
                    {
                        //MessageBox.Show("No esta esa relacion");
                        RelacionLaboral rel = new RelacionLaboral();
                        rel.relacionLaboral1 = comboRelacionLaboral.Text;
                        modeloRela.insertarRelacionLaboral(rel);
                        RelacionLaboral claveNueva = modeloRela.seleccionarRelacionLaboralporNombre(comboRelacionLaboral.Text);
                        historial.idRelacionLaboral = Convert.ToInt32(claveNueva.idRelacionLaboral);
                    }

                    if (status != null)
                    {
                        //MessageBox.Show("Si esta esa status");
                        historial.idStatus = Convert.ToInt32(status.idStatus);
                    }
                    else
                    {
                        // MessageBox.Show("No esta esa status");
                        Status sta = new Status();
                        sta.nombreStatus = comboStatus.Text;
                        modeloStatus.insertarStatus(sta);
                        Status staNuevo = modeloStatus.seleccionarStatusporNombre(comboStatus.Text);
                        historial.idStatus = Convert.ToInt32(staNuevo.idStatus);
                    }
                    if (sector != null)
                    {
                        // MessageBox.Show("Si esta esa sector");
                        historial.idSector = Convert.ToInt32(sector.idSector);
                    }
                    else
                    {
                        // MessageBox.Show("No esta esa relacion");
                        Sector sec = new Sector();
                        sec.sector1 = comboSector.Text;
                        modeloSector.insertarSector(sec);
                        Sector sectorNuevo = modeloSector.seleccionarSectorPorNombre(comboSector.Text);
                        historial.idSector = Convert.ToInt32(sectorNuevo.idSector);
                    }

                }
                catch
                {
                    MessageBox.Show("Error en subiendo al Historial");
                }



                /*historial.idRelacionLaboral = Convert.ToInt32(idRelacion.Text);
                historial.idSector = Convert.ToInt32(idSector.Text);
                historial.idStatus = Convert.ToInt32(idStatus.Text);
                */


                //SETTEO LOS ATRIBUTOS DE HISTORIAL


                try
                {
                    historial.clavePresupuestalAnterior = idClavePo.ToString();
                    historial.PBPNUP = Convert.ToInt32(cajaNUP2.Text);//ESTA SUPONGO QUE ES NUP LA VIEJA
                    historial.PBPNUE = Convert.ToInt32(cajaNUP1.Text);//ESTA CREO QUE ES LA NUEVA
                    historial.RFC = cajaRFC1.Text;
                    historial.NMAPP = cajaNMAPP1.Text;
                    historial.NMAPM = cajaNMAPM1.Text;
                    historial.NMNOMB = cajaNMNOMB1.Text;
                    historial.NMNOM = cajaNMNOM1.Text;
                    historial.NMFING = Convert.ToDateTime(cajaNMFING2.Text);
                    historial.NMFSAL = dateTimePicker1.Value;
                    historial.NIVEL = cajaNIVEL1.Text;
                    historial.CNOMCVE = cajaCNOMCVE1.Text;
                    historial.CNOMTIP = cajaCNOMTIP1.Text;
                    historial.CTICCVE = cajaCTICCVE1.Text;
                    historial.CVEDEP = cajaCVEDEP1.Text;
                    historial.NQS = cajaNQS1.Text;
                    modelo.agregarPlantillaHistorial(historial);
                    MessageBox.Show("Enviado al Historial!");
                }
                catch
                {
                    MessageBox.Show("Error en la agregada");
                }

                //------------------MODIFICAR LA PLANTILLA ACTUAL-------------------------------

                ModeloPlantilla modeloPlantilla = new ModeloPlantilla();
                Plantilla pNueva = new Plantilla();
                pNueva.idPlantilla = idPlantillaPo;




                /* pNueva.idClavePresupuestal = pModificar.idClavePresupuestal;
                 pNueva.idRelacionLaboral = pModificar.idRelacionLaboral;
                 pNueva.idSector = pModificar.idSector;
                 pNueva.idStatus = pModificar.idStatus;

                */
                try
                {
                    ClavePresupuestal clave2 = modeloClave.seleccionarClavePresupuestalPorClave(comboClave.Text);
                    RelacionLaboral relacion2 = modeloRela.seleccionarRelacionLaboralporNombre(comboRelacionLaboral.Text);
                    Sector sector2 = modeloSector.seleccionarSectorPorNombre(comboSector.Text);
                    Status status2 = modeloStatus.seleccionarStatusporNombre(comboStatus.Text);


                    if (clave2 != null)
                    {
                        // MessageBox.Show("Si esta esa clave");
                        pNueva.idClavePresupuestal = Convert.ToInt32(clave2.idClavePresupuestal);
                    }
                    else
                    {
                        //MessageBox.Show("No esta esa clave");
                        ClavePresupuestal aux = new ClavePresupuestal();
                        aux.clavePresupuestal1 = comboClave.Text;
                        modeloClave.insertarClavePresupuestal(aux);
                        ClavePresupuestal claveNueva = modeloClave.seleccionarClavePresupuestalPorClave(comboClave.Text);
                        pNueva.idClavePresupuestal = Convert.ToInt32(claveNueva.idClavePresupuestal);
                    }

                    if (relacion2 != null)
                    {
                        //  MessageBox.Show("Si esta esa relacion");
                        pNueva.idRelacionLaboral = Convert.ToInt32(relacion2.idRelacionLaboral);
                    }
                    else
                    {
                        //MessageBox.Show("No esta esa relacion");
                        RelacionLaboral rel = new RelacionLaboral();
                        rel.relacionLaboral1 = comboRelacionLaboral.Text;
                        modeloRela.insertarRelacionLaboral(rel);
                        RelacionLaboral claveNueva = modeloRela.seleccionarRelacionLaboralporNombre(comboRelacionLaboral.Text);
                        pNueva.idRelacionLaboral = Convert.ToInt32(claveNueva.idRelacionLaboral);
                    }

                    if (status2 != null)
                    {
                        //MessageBox.Show("Si esta esa status");
                        pNueva.idStatus = Convert.ToInt32(status2.idStatus);
                    }
                    else
                    {
                        // MessageBox.Show("No esta esa status");
                        Status sta = new Status();
                        sta.nombreStatus = comboStatus.Text;
                        modeloStatus.insertarStatus(sta);
                        Status staNuevo = modeloStatus.seleccionarStatusporNombre(comboStatus.Text);
                        pNueva.idStatus = Convert.ToInt32(staNuevo.idStatus);
                    }
                    if (sector2 != null)
                    {
                        // MessageBox.Show("Si esta esa sector");
                        pNueva.idSector = Convert.ToInt32(sector2.idSector);
                    }
                    else
                    {
                        // MessageBox.Show("No esta esa relacion");
                        Sector sec = new Sector();
                        sec.sector1 = comboSector.Text;
                        modeloSector.insertarSector(sec);
                        Sector sectorNuevo = modeloSector.seleccionarSectorPorNombre(comboSector.Text);
                        pNueva.idSector = Convert.ToInt32(sectorNuevo.idSector);
                    }

                }
                catch
                {
                    MessageBox.Show("Error en subiendo al Historial");
                }

                pNueva.CNOMCVE = cajaCNOMCVE1.Text;
                pNueva.CNOMTIP = cajaCNOMTIP1.Text;
                pNueva.CTICCVE = cajaCTICCVE1.Text;
                pNueva.CVEDEP = cajaCVEDEP1.Text;
                pNueva.NIVEL = cajaNIVEL1.Text;
                pNueva.NMAPM = cajaNMAPM1.Text;
                pNueva.NMAPP = cajaNMAPP1.Text;
                pNueva.NMFING = dateTimePicker1.Value;
                pNueva.NMNOM = cajaNMNOM1.Text;
                pNueva.NMNOMB = cajaNMNOMB1.Text;
                pNueva.NQS = cajaNQS1.Text;
                pNueva.PBPNUE = Convert.ToInt32(cajaNUP1.Text);
                pNueva.RFC = cajaRFC1.Text;




                try
                {
                    modeloPlantilla.actualizarPlantilla(pNueva);
                    MessageBox.Show("Plantilla Modificada!");


                    //LOS CAMBIOS MODIFICADOS SE PASAN AL PANEL 1
                    cajaCNOMCVE2.Text = cajaCNOMCVE1.Text;
                    cajaCNOMTIP2.Text = cajaCNOMTIP1.Text;
                    cajaCTICCVE2.Text = cajaCTICCVE1.Text;
                    cajaCVEDEP2.Text = cajaCVEDEP1.Text;
                    cajaNIVEL2.Text = cajaNIVEL1.Text;
                    cajaNMAPM2.Text = cajaNMAPM1.Text;
                    cajaNMAPP2.Text = cajaNMAPP1.Text;
                    cajaNMFING2.Text = dateTimePicker1.Value.ToString();
                    cajaNMNOM2.Text = cajaNMNOM1.Text;
                    cajaNMNOMB2.Text = cajaNMNOMB1.Text;
                    cajaNQS2.Text = cajaNQS1.Text;
                    cajaNUP2.Text = Convert.ToInt32(cajaNUP1.Text) + "";
                    cajaRFC2.Text = cajaRFC1.Text;

                    //CAMPOS ID AL PANEL 1
                    cajaSTATUS2.Text = comboStatus.Text;
                    cajaSECTOR2.Text = comboSector.Text;
                    cajaRELACION2.Text = comboRelacionLaboral.Text;
                    cajaCLAVE2.Text = comboClave.Text;



                }
                catch
                {
                    MessageBox.Show("Error en la agregada de Planilla Modificada");
                }


            }


        }
        private void cerrarSesion()
        {
            Application.OpenForms["Loggin"].Visible = true;
            this.Visible = false;
            this.Dispose();
        }

        private void cerrarSesiónToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void cerrarSesiónToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            cerrarSesion();
        }

        private void BuscarAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarAplicacion(e);
        }
        private void cerrarAplicacion(FormClosedEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
        private void cajaNUP1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void cajaBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        public bool validarCajasVacias()
        {
            if (
            cajaCNOMCVE1.Text == "" ||
            cajaCNOMTIP1.Text == "" ||
           cajaCTICCVE1.Text == "" ||
            cajaCVEDEP1.Text == "" ||
            cajaNIVEL1.Text == "" ||
            cajaNMAPM1.Text == "" ||
            cajaNMAPP1.Text == "" ||
            dateTimePicker1.Value == null ||
           cajaNMNOM1.Text == "" ||
            cajaNMNOMB1.Text == "" ||
            cajaNQS1.Text == "" ||
            cajaNUP1.Text == "" ||
            cajaRFC1.Text == "" ||
            comboStatus.Text == "" ||
            comboSector.Text == "" ||
            comboRelacionLaboral.Text == "" ||
            comboClave.Text == "")

            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
