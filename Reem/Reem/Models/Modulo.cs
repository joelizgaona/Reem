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
    
    public partial class Modulo
    {
        public Modulo()
        {
            this.Usuario_Modulo = new HashSet<Usuario_Modulo>();
        }
    
        public int ClaveMod { get; set; }
        public string DrecipcionMod { get; set; }
    
        public virtual ICollection<Usuario_Modulo> Usuario_Modulo { get; set; }
    }
}
