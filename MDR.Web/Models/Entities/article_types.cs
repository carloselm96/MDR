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
    
    public partial class article_types
    {
        public article_types()
        {
            this.articles = new HashSet<articles>();
        }
    
        public int ARTICLE_TYPE_ID { get; set; }
        public string NAME { get; set; }
    
        public virtual ICollection<articles> articles { get; set; }
    }
}
