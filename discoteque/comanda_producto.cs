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
    
    public partial class comanda_producto
    {
        public int producto_idproducto { get; set; }
        public int comanda_idcomanda { get; set; }
    
        public virtual comanda comanda { get; set; }
        public virtual producto producto { get; set; }
    }
}
