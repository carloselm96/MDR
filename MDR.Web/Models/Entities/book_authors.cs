//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MDR.Web.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class book_authors
    {
        public int BOOK_AUTHOR_ID { get; set; }
        public Nullable<int> BOOK_FK { get; set; }
        public Nullable<int> AUTHOR_FK { get; set; }
    
        public virtual authors authors { get; set; }
        public virtual books books { get; set; }
    }
}
