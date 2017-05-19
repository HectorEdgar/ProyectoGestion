using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPlantillaPersonal.Modelos
{
    class ModeloRelacionLaboral
    {


        public ModeloRelacionLaboral()
        {

        }

        public int insertarRelacionLaboral(RelacionLaboral relacionLaboral)
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {
                entity.RelacionLaboral.Add(relacionLaboral);
                return entity.SaveChanges();
            }
        }

        public RelacionLaboral seleccionarRelacionLaboral(int idRelacionLaboral)
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {

                return entity.RelacionLaboral.Where(p => p.idRelacionLaboral == idRelacionLaboral).FirstOrDefault();
            }
        }
        public RelacionLaboral buscarRelacionLaboral(String relacionlaboral, String NMCATG, String TBDES)
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {

                return entity.RelacionLaboral.Where(p => p.relacionLaboral1 == relacionlaboral).Where(p=>p.NMCATG== NMCATG).Where(p=>p.TBDES== TBDES).FirstOrDefault();
            }
        }

        public RelacionLaboral seleccionarRelacionLaboralporNombre(string RelacionLaboral)
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {

                return entity.RelacionLaboral.Where(p => p.relacionLaboral1 == RelacionLaboral).FirstOrDefault();
            }
        }

        public List<RelacionLaboral> seleccionarRelacionLaboral()
        {

            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {

                return entity.RelacionLaboral.Select(p => p).ToList();
            }
        }

        public int actualizarRelacionLaboral(RelacionLaboral relacionLaboral)
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {
                RelacionLaboral relacionLaboralAnterior = entity.RelacionLaboral.Where(p => p.idRelacionLaboral == relacionLaboral.idRelacionLaboral).First();
                relacionLaboralAnterior.relacionLaboral1 = relacionLaboral.relacionLaboral1;
                relacionLaboralAnterior.NMCATG = relacionLaboral.NMCATG;
                relacionLaboralAnterior.TBDES = relacionLaboral.TBDES;

                return entity.SaveChanges();
            }
        }

        public int borrarRelacionLaboral(int idRelacionLaboral)
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {
                RelacionLaboral relacionLaboral = entity.RelacionLaboral.Where(p => p.idRelacionLaboral == idRelacionLaboral).First();
                return entity.SaveChanges();
            }
        }

    }
}
