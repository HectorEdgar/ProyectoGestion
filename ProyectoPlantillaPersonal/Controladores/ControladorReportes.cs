using ProyectoPlantillaPersonal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPlantillaPersonal.Controladores
{
    public class ControladorReportes
    {
        public void generarReporte(List<Plantilla> listaPlantilla)
        {
            List<List<string>> listaListasStrings = new List<List<string>>();

            foreach (Plantilla p in listaPlantilla)
            {
                List<string> plantilla = new List<string>();

                plantilla.Add(p.PBPNUE.ToString());
                plantilla.Add(p.RFC);
                plantilla.Add(p.NMAPP);
                plantilla.Add(p.NMAPM);
                plantilla.Add(p.NMNOMB);
                plantilla.Add(p.NMNOM);
                plantilla.Add(p.NMFING.ToString());
                plantilla.Add(p.NIVEL);
                plantilla.Add(p.CNOMCVE);
                plantilla.Add(p.CNOMTIP);
                plantilla.Add(p.CTICCVE);
                plantilla.Add(p.CVEDEP);
                plantilla.Add(p.NQS);
                plantilla.Add(p.Sector.sector1);
                plantilla.Add(p.ClavePresupuestal.clavePresupuestal1);
                plantilla.Add(p.Status.nombreStatus);
                plantilla.Add(p.RelacionLaboral.relacionLaboral1);
                plantilla.Add(p.RelacionLaboral.NMCATG);
                plantilla.Add(p.RelacionLaboral.TBDES);

                listaListasStrings.Add(plantilla);
            }

            Excel excel = new Excel();

            excel.cargarDatos(listaListasStrings);
        }
    }
}

