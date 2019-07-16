//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tax_AK.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class CompanyData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompanyData()
        {
            this.PayeAgent = new HashSet<PayeAgent>();
            this.PersonalData = new HashSet<PersonalData>();
        }

        public int taskid { get; set; }
        public int ItbId { get; set; }
        public string TaxID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyTIN { get; set; }
        public string TINVerificationstatus { get; set; }
        public int CompanyTaxtype { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhonenumber { get; set; }
        public string CompanyAltNumber { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyAltEmail { get; set; }
        public string CompanyRegNo { get; set; }
        public Nullable<System.DateTime> CompanyStartDate { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
        public string LastModifiedAuthid { get; set; }
        public string LastModifiedUid { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }

        public virtual TaxType TaxType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PayeAgent> PayeAgent { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonalData> PersonalData { get; set; }
    }
}