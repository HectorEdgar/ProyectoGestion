//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoPlantillaPersonal.Modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class RelacionLaboral
    {
        public RelacionLaboral()
        {
            this.Plantilla = new HashSet<Plantilla>();
            this.PlantillaHistorial = new HashSet<PlantillaHistorial>();
        }
    
        public int idRelacionLaboral { get; set; }
        public string relacionLaboral1 { get; set; }
        public string NMCATG { get; set; }
        public string TBDES { get; set; }
    
        public virtual ICollection<Plantilla> Plantilla { get; set; }
        public virtual ICollection<PlantillaHistorial> PlantillaHistorial { get; set; }
    }
}
