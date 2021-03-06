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
    
    public partial class projects
    {
        public projects()
        {
            this.project_academias = new HashSet<project_academias>();
            this.project_authors = new HashSet<project_authors>();
        }
    
        public int PROJECT_ID { get; set; }
        public string TITLE { get; set; }
        public string FINANCING { get; set; }
        public Nullable<System.DateTime> START_DATE { get; set; }
        public Nullable<System.DateTime> FINAL_DATE { get; set; }
        public Nullable<int> USER_FK { get; set; }
        public Nullable<int> FILE_FK { get; set; }
        public string KEY { get; set; }
        public Nullable<int> BUDGET { get; set; }
    
        public virtual files files { get; set; }
        public virtual ICollection<project_academias> project_academias { get; set; }
        public virtual ICollection<project_authors> project_authors { get; set; }
        public virtual users users { get; set; }
    }
}
