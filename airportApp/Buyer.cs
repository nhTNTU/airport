//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace airportApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Buyer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Buyer()
        {
            this.Tickets = new HashSet<Ticket>();
        }
    
        public int br_id { get; set; }
        public int br_pay_id_PK { get; set; }
        public string br_lastName { get; set; }
        public string br_firstName { get; set; }
        public string br_phone { get; set; }
        public string br_altPhone { get; set; }
        public string br_timeToConnect { get; set; }
        public string br_deliveryAdress { get; set; }
        public int br_pay_id_FK { get; set; }
    
        public virtual Payment Payment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual Payment Payment1 { get; set; }
    }
}
