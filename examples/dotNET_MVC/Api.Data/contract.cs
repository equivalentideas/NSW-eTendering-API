//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Api.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class contract
    {
        public string ContractUUID { get; set; }
        public int ID { get; set; }
        public string Type { get; set; }
        public string AgencyUUID { get; set; }
        public string UserUUID { get; set; }
        public string UNSPSCCode { get; set; }
        public Nullable<System.DateTime> Published { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<double> Value { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string CancellationReason { get; set; }
        public Nullable<bool> ConsultancyFlag { get; set; }
        public string ContractJustificationUUID { get; set; }
        public string UploadUUID { get; set; }
        public string TenderNumber { get; set; }
        public Nullable<System.DateTime> CancellationDate { get; set; }
        public string CancellationUserUUID { get; set; }
    }
}
