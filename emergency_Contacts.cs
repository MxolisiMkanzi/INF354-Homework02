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
    
    public partial class emergency_Contacts
    {
        public int EID { get; set; }
        public Nullable<int> StudentID { get; set; }
        public string FirstPhoneNumber { get; set; }
        public string SecondPhoneNumber { get; set; }
    
        public virtual personal_details personal_details { get; set; }
    }
}
