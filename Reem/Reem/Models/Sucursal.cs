//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Reem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sucursal
    {
        public Sucursal()
        {
            this.Reembolso = new HashSet<Reembolso>();
        }
    
        public string ClaveSuc { get; set; }
        public string DescripcionSuc { get; set; }
    
        public virtual ICollection<Reembolso> Reembolso { get; set; }
    }
}
