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
    
    public partial class files
    {
        public files()
        {
            this.articles = new HashSet<articles>();
            this.books = new HashSet<books>();
            this.projects = new HashSet<projects>();
            this.receptional_works = new HashSet<receptional_works>();
            this.works = new HashSet<works>();
        }
    
        public int FILE_ID { get; set; }
        public string NAME { get; set; }
        public string URL { get; set; }
    
        public virtual ICollection<articles> articles { get; set; }
        public virtual ICollection<books> books { get; set; }
        public virtual ICollection<projects> projects { get; set; }
        public virtual ICollection<receptional_works> receptional_works { get; set; }
        public virtual ICollection<works> works { get; set; }
    }
}