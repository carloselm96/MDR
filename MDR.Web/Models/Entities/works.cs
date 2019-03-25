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
    
    public partial class works
    {
        public works()
        {
            this.work_academias = new HashSet<work_academias>();
            this.work_authors = new HashSet<work_authors>();
        }
    
        public int WORK_ID { get; set; }
        public string TITLE { get; set; }
        public Nullable<System.DateTime> DATE { get; set; }
        public Nullable<int> WORK_TYPE_FK { get; set; }
        public string AUTHORS { get; set; }
        public string PRESENTATION { get; set; }
        public string COUNTRY { get; set; }
        public Nullable<int> USER_FK { get; set; }
        public Nullable<int> FILE_FK { get; set; }
    
        public virtual files files { get; set; }
        public virtual users users { get; set; }
        public virtual ICollection<work_academias> work_academias { get; set; }
        public virtual ICollection<work_authors> work_authors { get; set; }
        public virtual work_types work_types { get; set; }
    }
}
