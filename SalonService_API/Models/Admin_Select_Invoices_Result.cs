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
    
    public partial class Admin_Select_Invoices_Result
    {
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> InvoiceAmount { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public Nullable<int> AvailableQuantity { get; set; }
    }
}
