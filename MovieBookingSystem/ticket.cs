//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieBookingSystem
{
    using System;
    using System.Collections.Generic;
    
    public abstract partial class ticket
    {
        public int ticketID { get; set; }
        public int movieID { get; set; }
        public int seatNumber { get; set; }
        public int cartCode { get; set; }
    
        public virtual cart cart { get; set; }
        public virtual movie movie { get; set; }
    }
}
