//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SalonService_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalonFacilitator
    {
        public int Id { get; set; }
        public string FacilitatorName { get; set; }
        public Nullable<int> Salary { get; set; }
        public Nullable<bool> IsBooked { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdationDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}