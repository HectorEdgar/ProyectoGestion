using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPlantillaPersonal.Modelos
{
    class ModeloPlantillaHistorial
    {
        public PlantillaHistorial cuenta { get; set; }

        public ModeloPlantillaHistorial()
        {

        }

        //INSERT
        public int agregarPlantillaHistorial(PlantillaHistorial plantillaHistorial)
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {
                entity.PlantillaHistorial.Add(plantillaHistorial);
                return entity.SaveChanges();
                
            }

        }

        //METODOS DE SELECCION 

        public PlantillaHistorial seleccionarPlantillaHistorial(int idPlantillaHistorial)
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {
                 return (PlantillaHistorial) entity.PlantillaHistorial.Where(p => p.idPlantilla == idPlantillaHistorial);
            }
        }

        public List<PlantillaHistorial> seleccionarPlantillaHistorialClavePresupuestalAnterior(string clavePresupuestalAnterior)
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {
                
                List<PlantillaHistorial> gente = entity.PlantillaHistorial.ToList();
                IEnumerable<PlantillaHistorial> results = entity.PlantillaHistorial.Where(p=> p.clavePresupuestalAnterior.Equals(clavePresupuestalAnterior));
                return results.ToList();
            }
        }

        public List<PlantillaHistorial> seleccionarPlantillaHistorialPBPNUP(int PBPNUP)
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {

                List<PlantillaHistorial> gente = entity.PlantillaHistorial.ToList();
                IEnumerable<PlantillaHistorial> results = entity.PlantillaHistorial.Where(p => p.PBPNUP.Equals(PBPNUP));
                return results.ToList();
            }
        }

        public List<PlantillaHistorial> seleccionarPlantillaHistorialPBPNUE(int PBPNUE)
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {

                List<PlantillaHistorial> gente = entity.PlantillaHistorial.ToList();
                IEnumerable<PlantillaHistorial> results = entity.PlantillaHistorial.Where(p => p.PBPNUE.Equals(PBPNUE));
                return results.ToList();
            }
        }

        public List<PlantillaHistorial> seleccionarPlantillaHistorialRFC(string RFC)
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {

                List<PlantillaHistorial> gente = entity.PlantillaHistorial.ToList();
                IEnumerable<PlantillaHistorial> results = entity.PlantillaHistorial.Where(p => p.RFC.Equals(RFC));
                return results.ToList();
            }
        }

        public List<PlantillaHistorial> seleccionarPlantillaHistorial()
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {
                return entity.PlantillaHistorial.Select(p => p).ToList();
            }
        }


        //METODO DE ACTUALIZACION 

        public int actualizarPlantilla(PlantillaHistorial plantillaHistorial)
        {
            
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {
                PlantillaHistorial a = entity.PlantillaHistorial.Where(p => p.idPlantilla == plantillaHistorial.idPlantilla).First();
                a.idPlantilla = plantillaHistorial.idPlantilla;
                a.idClavePresupuestal = plantillaHistorial.idClavePresupuestal;
                a.idRelacionLaboral = plantillaHistorial.idRelacionLaboral;
                a.idSector = plantillaHistorial.idSector;
                a.idStatus = plantillaHistorial.idStatus;
                a.NIVEL = plantillaHistorial.NIVEL;
                a.NMAPM = plantillaHistorial.NMAPM;
                a.NMAPP = plantillaHistorial.NMAPP;
                a.NMFING = plantillaHistorial.NMFING;
                a.NMFSAL = plantillaHistorial.NMFSAL;
                a.NMNOM = plantillaHistorial.NMNOM;
                a.NMNOMB = plantillaHistorial.NMNOMB;
                a.NQS = plantillaHistorial.NQS;
                a.PBPNUE = plantillaHistorial.PBPNUE;
                a.PBPNUP = plantillaHistorial.PBPNUP;
                a.RelacionLaboral = plantillaHistorial.RelacionLaboral;
                a.RFC = plantillaHistorial.RFC;
                a.Sector = plantillaHistorial.Sector;
                a.Status = plantillaHistorial.Status;
                a.CNOMCVE = plantillaHistorial.CNOMCVE;
                a.CNOMTIP = plantillaHistorial.CNOMTIP;
                a.CVEDEP = plantillaHistorial.CVEDEP;
                a.ClavePresupuestal = plantillaHistorial.ClavePresupuestal;
                a.clavePresupuestalAnterior = plantillaHistorial.clavePresupuestalAnterior;

                return entity.SaveChanges();
            }
        }

        // METODO AGREGADO POR ANGEL
        public List<PlantillaHistorial> seleccionarPorPropiedad(string coincidenciaNup, bool nup, string coincidenciaNuevoNup, bool nuevoNup, string coincidenciaRfc, bool rfc, string coincidenciaClavePresupuestal, bool clavePresupuestal)
        {
            List<PlantillaHistorial> listaPlantillasHistorial = new List<PlantillaHistorial>();

            SistemaPlantillaPersonalEntities entities = new SistemaPlantillaPersonalEntities();
            
                Func<PlantillaHistorial, bool> funcion = ph =>
                {
                    if (nup)
                        if (!ph.PBPNUP.ToString().Equals(coincidenciaNup))
                            return false;

                    if (nuevoNup)
                        if (!ph.PBPNUE.ToString().Equals(coincidenciaNuevoNup))
                            return false;

                    if (rfc)
                        if (!ph.RFC.Equals(coincidenciaRfc))
                            return false;

                    if (clavePresupuestal)
                        if (!ph.ClavePresupuestal.clavePresupuestal1.Equals(coincidenciaClavePresupuestal))
                            return false;

                    return true;
                };

                listaPlantillasHistorial = entities.PlantillaHistorial.Where(funcion).ToList();
            

            return listaPlantillasHistorial;
        }

    }
}
