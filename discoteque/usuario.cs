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
    
    public partial class usuario
    {
        public usuario()
        {
            this.atencion = new HashSet<atencion>();
        }
    
        public int idusuario { get; set; }
        public string nombreusuario { get; set; }
        public string passusuario { get; set; }
        public string cuentausuario { get; set; }
        public short activo { get; set; }
        public int tipoUsuario_idtipoUsuario { get; set; }
    
        public virtual ICollection<atencion> atencion { get; set; }
        public virtual tipousuario tipousuario { get; set; }
    }
}
