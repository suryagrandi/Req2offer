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
    
    public partial class tbl_Sub_Business_Unit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Sub_Business_Unit()
        {
            this.tbl_Internal_Req = new HashSet<tbl_Internal_Req>();
        }
    
        public int Sub_Id { get; set; }
        public string Sub_Name { get; set; }
        public Nullable<int> Bu_Id { get; set; }
    
        public virtual tbl_Business_Unit tbl_Business_Unit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Internal_Req> tbl_Internal_Req { get; set; }
    }
}
