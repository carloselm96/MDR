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
    
    public partial class scientific_authors
    {
        public int SCIENTIFIC_AUTHORS_ID { get; set; }
        public Nullable<int> SCIENTIFIC_PRODUCTION_FK { get; set; }
        public Nullable<int> AUTHOR_FK { get; set; }
    
        public virtual authors authors { get; set; }
        public virtual scientific_productions scientific_productions { get; set; }
    }
}