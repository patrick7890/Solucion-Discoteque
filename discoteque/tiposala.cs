//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace discoteque
{
    using System;
    using System.Collections.Generic;
    
    public partial class tiposala
    {
        public tiposala()
        {
            this.atencion = new HashSet<atencion>();
        }
    
        public int idtipoSala { get; set; }
        public string desctipoSala { get; set; }
    
        public virtual ICollection<atencion> atencion { get; set; }
    }
}
