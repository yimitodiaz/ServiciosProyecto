//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Calificaciones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Calificaciones()
        {
            this.CalificacionesAlojamiento = new HashSet<CalificacionesAlojamiento>();
            this.CalificacionesArrendatario = new HashSet<CalificacionesArrendatario>();
        }
    
        public int idCalificacion { get; set; }
        public string comentarioAlojamiento { get; set; }
        public Nullable<int> calificacionAlojamiento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CalificacionesAlojamiento> CalificacionesAlojamiento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CalificacionesArrendatario> CalificacionesArrendatario { get; set; }
    }
}