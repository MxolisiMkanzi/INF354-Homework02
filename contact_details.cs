//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace INF354HW01.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class contact_details
    {
        public int CID { get; set; }
        public Nullable<int> StudentID { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
    
        public virtual personal_details personal_details { get; set; }
    }
}
