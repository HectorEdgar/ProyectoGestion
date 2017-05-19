using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPlantillaPersonal.Modelos
{
    class ModeloClavePresupuestal
    {

        public ModeloClavePresupuestal()
        {

        }

        public int insertarClavePresupuestal(ClavePresupuestal clavePresupuestal)
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {
                entity.ClavePresupuestal.Add(clavePresupuestal);
                return entity.SaveChanges();
            }
        }

        public ClavePresupuestal seleccionarClavePresupuestal(int idClavePresupuestal)
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {

                return entity.ClavePresupuestal.Where(p => p.idClavePresupuestal == idClavePresupuestal).FirstOrDefault();
            }
        }


        public ClavePresupuestal seleccionarClavePresupuestalPorClave(string clavePresupuestal)
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {

                return entity.ClavePresupuestal.Where(p => p.clavePresupuestal1 ==clavePresupuestal).FirstOrDefault();
            }
        }

        public List<ClavePresupuestal> seleccionarClavePresupuestal()
        {

            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {

                return entity.ClavePresupuestal.Select(p => p).ToList();
            }
        }

        public int actualizarClavePresupuestal(ClavePresupuestal clavePresupuestal)
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {
                ClavePresupuestal clavePresupuestalAnterior = entity.ClavePresupuestal.Where(p => p.idClavePresupuestal == clavePresupuestal.idClavePresupuestal).First();
                clavePresupuestalAnterior.clavePresupuestal1 = clavePresupuestal.clavePresupuestal1;

                return entity.SaveChanges();
            }
        }

        public int borrarClavePresupuestal(int idClavePresupuestal)
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {
                ClavePresupuestal clavePresupuestal = entity.ClavePresupuestal.Where(p => p.idClavePresupuestal == idClavePresupuestal).First();
                return entity.SaveChanges();
            }
        }
    }
}
