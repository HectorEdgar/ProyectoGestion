using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPlantillaPersonal.Modelos
{
    class ModeloCuenta
    {


        public ModeloCuenta()
        {

        }

        public void insertarCuenta(Cuenta cuenta)
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {
                entity.Cuenta.Add(cuenta);
                entity.SaveChanges();
            }
        }

        public Cuenta seleccionarCuenta(int idCuenta)
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {   

                return entity.Cuenta.Where(p=>p.idCuenta == idCuenta).First();
            }
        }

        public List<Cuenta> seleccionarCuenta() {

            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {

                return entity.Cuenta.Select(p => p).ToList();
            }
        }
        public Cuenta seleccionarCuenta(String usuario,String password)
        {

            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {

                return entity.Cuenta.Where(p => p.usuario.Equals(usuario)).Where(p=>p.contrasenia.Equals(password)).First();
            }
        }

        public int actualizarCuenta(Cuenta cuenta) {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {
               Cuenta cuentaAnterior = entity.Cuenta.Where(p=>p.idCuenta==cuenta.idCuenta).First();
                cuentaAnterior.usuario = cuenta.usuario;
                cuentaAnterior.contrasenia = cuenta.contrasenia;
                cuentaAnterior.tipo = cuenta.tipo;
                cuentaAnterior.nombre = cuenta.tipo;
                cuentaAnterior.apellidoPaterno = cuenta.apellidoPaterno;
                cuentaAnterior.apellidoMaterno = cuenta.apellidoMaterno;

                return entity.SaveChanges();
            }
        }

        public int borrarCuenta(int idCuenta)
        {
            using (SistemaPlantillaPersonalEntities entity = new SistemaPlantillaPersonalEntities())
            {
                Cuenta cuenta = entity.Cuenta.Where(p=>p.idCuenta == idCuenta).First();
                return entity.SaveChanges();
            }
        }

    }
}
