//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotNetReq2Offer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Cost_Center
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Cost_Center()
        {
            this.tbl_Cost_Center1 = new HashSet<tbl_Cost_Center>();
            this.tbl_Internal_Req = new HashSet<tbl_Internal_Req>();
        }
    
        public int Cost_Center_Id { get; set; }
        public string Cost_Center_Name { get; set; }
        public Nullable<int> Head_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Cost_Center> tbl_Cost_Center1 { get; set; }
        public virtual tbl_Cost_Center tbl_Cost_Center2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Internal_Req> tbl_Internal_Req { get; set; }
    }
}
