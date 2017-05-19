using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPlantillaPersonal.Modelos
{
    class ModeloStatus
    {

        public ModeloStatus()
        {

        }

        public int insertarStatus(Status status)
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {
                entity.Status.Add(status);
                return entity.SaveChanges();
            }
        }

        public Status seleccionarStatus(int idStatus)
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {

                return entity.Status.Where(p => p.idStatus == idStatus).FirstOrDefault();
            }
        }

        public Status seleccionarStatusporNombre(string status)
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {

                return entity.Status.Where(p => p.nombreStatus == status).FirstOrDefault();
            }
        }



        public List<Status> seleccionarStatus()
        {

            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {

                return entity.Status.Select(p => p).ToList();
            }
        }

        public int actualizarStatus(Status status)
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {
                Status statusAnterior = entity.Status.Where(p => p.idStatus == status.idStatus).First();
                statusAnterior.nombreStatus = status.nombreStatus;

                return entity.SaveChanges();
            }
        }

        public int borrarStatus(int idStatus)
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {
                Status status = entity.Status.Where(p => p.idStatus == idStatus).First();
                return entity.SaveChanges();
            }
        }



    }
}
