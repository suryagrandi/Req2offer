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
    
    public partial class tbl_User
    {
        internal string ResetPasswordCode;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_User()
        {
            this.tbl_External_Req = new HashSet<tbl_External_Req>();
            this.tbl_Internal_Req = new HashSet<tbl_Internal_Req>();
            this.tbl_Internal_Req1 = new HashSet<tbl_Internal_Req>();
            this.tbl_User1 = new HashSet<tbl_User>();
        }
    
        public int Employee_Id { get; set; }
        public string Employee_Name { get; set; }
        public string Email_Id { get; set; }
        public string Contact_Number { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> Password_Expiry { get; set; }
        public Nullable<int> Role_Id { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public string Flag { get; set; }
        public Nullable<int> Reporting_Manager { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_External_Req> tbl_External_Req { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Internal_Req> tbl_Internal_Req { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Internal_Req> tbl_Internal_Req1 { get; set; }
        public virtual tbl_Role tbl_Role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_User> tbl_User1 { get; set; }
        public virtual tbl_User tbl_User2 { get; set; }
    }
}
