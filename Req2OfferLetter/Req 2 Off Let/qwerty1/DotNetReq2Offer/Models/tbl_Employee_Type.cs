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
    
    public partial class tbl_Employee_Type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Employee_Type()
        {
            this.tbl_External_Req = new HashSet<tbl_External_Req>();
            this.tbl_Internal_Req = new HashSet<tbl_Internal_Req>();
            this.tbl_Select_Candidate = new HashSet<tbl_Select_Candidate>();
        }
    
        public int Type_Id { get; set; }
        public string Employee_Type { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_External_Req> tbl_External_Req { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Internal_Req> tbl_Internal_Req { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Select_Candidate> tbl_Select_Candidate { get; set; }
    }
}
