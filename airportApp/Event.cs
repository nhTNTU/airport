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
    
    public partial class Event
    {
        public int e_id { get; set; }
        public int e_fl_id_FK { get; set; }
        public string e_eventType { get; set; }
        public System.DateTime e_dateTimeEvent { get; set; }
    
        public virtual Flight Flight { get; set; }
    }
}