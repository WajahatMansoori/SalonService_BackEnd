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
    
    public partial class Admin_Select_SolonAppointment_Result
    {
        public int FacilitatorId { get; set; }
        public string ClientName { get; set; }
        public string ClientPhone { get; set; }
        public Nullable<System.DateTime> AppointDate { get; set; }
        public string IsServed { get; set; }
        public string FacilitatorName { get; set; }
        public string ServiceName { get; set; }
        public Nullable<int> ServiceCharges { get; set; }
    }
}
