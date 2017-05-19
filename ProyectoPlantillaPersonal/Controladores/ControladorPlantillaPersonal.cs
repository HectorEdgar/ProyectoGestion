using ProyectoPlantillaPersonal.Modelos;
using System
    ;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoPlantillaPersonal.Controladores
{
    internal class ControladorPlantillaPersonal
    {
        public ControladorPlantillaPersonal()
        {
        }

        public ProgressBar progress;
        public Label lblNum;

        public void obtenerDatos(String ruta, Boolean visible, ProgressBar progress, Label lblNum)
        {
            Excel excel = new Excel();
            listaDatos = excel.obtenerDatos(ruta, visible);
            this.progress = progress;
            this.lblNum = lblNum;
        }

        public int ContarElementos(String ruta)
        {
            Excel excel = new Excel();

            return excel.contarDatos(ruta);
        }

        public List<List<String>> listaDatos { get; set; }

        public void AgregarPlantillaPersonal()
        {
            Plantilla plantilla;

            for (int i = 1; i < listaDatos.Count; i++)
            {
                plantilla = new Plantilla();
                List<String> datos = listaDatos[i];
                int cont = 0;
                //Console.WriteLine("------"+datos[cont++]);

                try
                {
                    plantilla.PBPNUE = Convert.ToInt16(datos[cont++]);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en el formato del campo NUB, verifique el formato");
                    return;
                }
                
                plantilla.RFC = datos[cont++];
                plantilla.NMAPP = datos[cont++];
                plantilla.NMAPM = datos[cont++];
                plantilla.NMNOMB = datos[cont++];
                plantilla.NMNOM = datos[cont++];
                //Console.WriteLine(datos[cont]);
                try
                {
                    plantilla.NMFING = Convert.ToDateTime(datos[cont++]);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en el formato de la fecha de entrada, verifique el formato");
                    return;
                }
                
                plantilla.NIVEL = datos[cont++];
                plantilla.CNOMCVE = datos[cont++];
                plantilla.CNOMTIP = datos[cont++];
                plantilla.CTICCVE = datos[cont++];
                plantilla.CVEDEP = datos[cont++];
                plantilla.NQS = datos[cont++];

                ModeloSector modeloSector = new ModeloSector();
                ModeloClavePresupuestal modeloClavePresupuestal = new ModeloClavePresupuestal();
                ModeloStatus modeloStatus = new ModeloStatus();
                ModeloRelacionLaboral modeloRelacionLaboral = new ModeloRelacionLaboral();

                Sector sector;
                try
                {
                    sector = modeloSector.seleccionarSectorPorNombre(datos[cont++]);
                }   
                catch (Exception)
                {
                    sector = null;
                }

                if (sector == null)
                {
                    sector = new Sector();
                    sector.sector1 = datos[cont - 1];
                    modeloSector.insertarSector(sector);
                }
                ClavePresupuestal clavePresupuestal;
                try
                {
                    clavePresupuestal = modeloClavePresupuestal.seleccionarClavePresupuestalPorClave(datos[cont++]);
                }
                catch (Exception)
                {
                    clavePresupuestal = null;
                }

                if (clavePresupuestal == null)
                {
                    clavePresupuestal = new ClavePresupuestal();
                    clavePresupuestal.clavePresupuestal1 = datos[cont - 1];
                    modeloClavePresupuestal.insertarClavePresupuestal(clavePresupuestal);
                }
                Status status;
                try
                {
                    status = modeloStatus.seleccionarStatusporNombre(datos[cont++]);
                }
                catch (Exception)
                {
                    status = null;
                }

                if (status == null)
                {
                    status = new Status();
                    status.nombreStatus = datos[cont - 1];
                    modeloStatus.insertarStatus(status);
                }
                RelacionLaboral relacionLaboral;
                try
                {
                    relacionLaboral = modeloRelacionLaboral.buscarRelacionLaboral(datos[cont++], datos[cont++], datos[cont++]);
                }
                catch (Exception)
                {
                    relacionLaboral = null;
                }

                if (relacionLaboral == null)
                {
                    relacionLaboral = new RelacionLaboral();
                    relacionLaboral.relacionLaboral1 = datos[cont - 3];
                    relacionLaboral.NMCATG = datos[cont - 2];
                    relacionLaboral.TBDES = datos[cont - 1];
                    modeloRelacionLaboral.insertarRelacionLaboral(relacionLaboral);
                }

                plantilla.idSector = sector.idSector;

                plantilla.idClavePresupuestal = clavePresupuestal.idClavePresupuestal;

                plantilla.idStatus = status.idStatus;

                plantilla.idRelacionLaboral = relacionLaboral.idRelacionLaboral;

                ModeloPlantilla modeloPlantilla = new ModeloPlantilla();
                modeloPlantilla.insertarPlantilla(plantilla);

                progress.Increment(1);
                lblNum.Text = "" + progress.Value + " / " + progress.Maximum;
            }
        }

        public void setValue(int contador)
        {
            if (!progress.InvokeRequired)
            {
                progress.Value = contador;
            }
            else
            {
                incrementar(contador);
            }
        }

        public void incrementar(int contador)
        {
            setValue(contador);
        }
    }
}