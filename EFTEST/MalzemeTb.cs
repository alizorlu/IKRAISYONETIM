//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFTEST
{
    using System;
    using System.Collections.Generic;
    
    public partial class MalzemeTb
    {
        public int MalzemeID { get; set; }
        public string KullanimMiktar { get; set; }
        public Nullable<int> YemekId { get; set; }
        public Nullable<int> StokId { get; set; }
    
        public virtual StokTb StokTb { get; set; }
        public virtual YemekTb YemekTb { get; set; }
    }
}
