using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPlantillaPersonal.Modelos
{
    class ModeloSector
    {
        public ModeloSector()
        {

        }

        public int insertarSector(Sector sector)
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {
                entity.Sector.Add(sector);
                return entity.SaveChanges();
            }
        }

        public Sector seleccionarSector(int idSector)
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {

                return entity.Sector.Where(p => p.idSector == idSector).FirstOrDefault();
            }
        }


        public Sector seleccionarSectorPorNombre(string Sector)
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {

                return entity.Sector.Where(p => p.sector1 == Sector).FirstOrDefault();
            }
        }


        public List<Sector> seleccionarSector()
        {

            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {

                return entity.Sector.Select(p => p).ToList();
            }
        }

        public int actualizarSector(Sector sector)
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {
                Sector sectorAnterior = entity.Sector.Where(p => p.idSector == sector.idSector).First();
                sectorAnterior.sector1 = sector.sector1;

                return entity.SaveChanges();
            }
        }

        public int borrarSector(int idSector)
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {
                Sector sector = entity.Sector.Where(p => p.idSector == idSector).First();
                return entity.SaveChanges();
            }
        }
    }
}
