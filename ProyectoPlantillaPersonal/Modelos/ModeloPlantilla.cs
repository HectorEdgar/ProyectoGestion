using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPlantillaPersonal.Modelos
{
    public class ModeloPlantilla
    {
        // SELECTS
        public Plantilla seleccionarPlantillaPorID(int idPlantilla)
        {
            Plantilla plantilla = null;

            SistemaPlantillaPersonalEntities entities = new SistemaPlantillaPersonalEntities();
            plantilla = entities.Plantilla.Single(p1 => p1.idPlantilla == idPlantilla);

            return plantilla;
        }

        public List<Plantilla> seleccionarPorPropiedad(string coincidenciaNup, bool nup, string coincidenciaRfc, bool rfc, string coincidenciaClavePresupuestal, bool clavePresupuestal)
        {
            List<Plantilla> listaPlantillas = new List<Plantilla>();

            SistemaPlantillaPersonalEntities entities = new SistemaPlantillaPersonalEntities();
                Func<Plantilla, bool> funcion = p =>
                {
                    if (nup)
                        if (!p.PBPNUE.ToString().Equals(coincidenciaNup))
                            return false;
                        

                    if (rfc)
                        if (!p.RFC.Equals(coincidenciaRfc))
                            return false;

                    if (clavePresupuestal)
                        if (!p.ClavePresupuestal.clavePresupuestal1.Equals(coincidenciaClavePresupuestal))
                            return false;

                    return true;
                };
               
                listaPlantillas = entities.Plantilla.Where(funcion).ToList();



            return listaPlantillas;
        }

        public List<Plantilla> coincidenciasNUP(string coincidenciaNup,bool nup)
        {
            List<Plantilla> listaPlantillas = new List<Plantilla>();

            SistemaPlantillaPersonalEntities entities = new SistemaPlantillaPersonalEntities();
                Func<Plantilla, bool> funcion = p =>
                {
                    if (nup)
                        if (!p.PBPNUE.ToString().Contains(coincidenciaNup))
                            return false;
                    return true;
                };

                listaPlantillas = entities.Plantilla.Where(funcion).Take(5).ToList();



            return listaPlantillas;
        }


        public List<Plantilla> seleccionarPlantillas()
        {
            List<Plantilla> listaPlantillas = new List<Plantilla>();

            SistemaPlantillaPersonalEntities entities = new SistemaPlantillaPersonalEntities();
            {
                listaPlantillas = entities.Plantilla.ToList();
            }

            return listaPlantillas;
        }


        // INSERTS
        public int insertarPlantilla(Plantilla p)
        {
            SistemaPlantillaPersonalEntities entities = new SistemaPlantillaPersonalEntities();
            {
                entities.Plantilla.Add(p);
                return entities.SaveChanges();
            }
        }


        // UPDATES
        public int actualizarPlantilla(Plantilla pModificar)
        {
            SistemaPlantillaPersonalEntities entities = new SistemaPlantillaPersonalEntities();
            {
                Plantilla pNueva = entities.Plantilla.Single(p => p.idPlantilla == pModificar.idPlantilla);

                pNueva.CNOMCVE = pModificar.CNOMCVE;
                pNueva.CNOMTIP = pModificar.CNOMTIP;
                pNueva.CTICCVE = pModificar.CTICCVE;
                pNueva.CVEDEP = pModificar.CVEDEP;
                pNueva.idClavePresupuestal = pModificar.idClavePresupuestal;
                pNueva.idRelacionLaboral = pModificar.idRelacionLaboral;
                pNueva.idSector = pModificar.idSector;
                pNueva.idStatus = pModificar.idStatus;
                pNueva.NIVEL = pModificar.NIVEL;
                pNueva.NMAPM = pModificar.NMAPM;
                pNueva.NMAPP = pModificar.NMAPP;
                pNueva.NMFING = pModificar.NMFING;
                pNueva.NMNOM = pModificar.NMNOM;
                pNueva.NMNOMB = pModificar.NMNOMB;
                pNueva.NQS = pModificar.NQS;
                pNueva.PBPNUE = pModificar.PBPNUE;
                pNueva.RFC = pModificar.RFC;

                return entities.SaveChanges();
            }
        }
    }
}
