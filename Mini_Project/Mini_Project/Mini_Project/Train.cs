//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mini_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class Train
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Train()
        {
            this.Bookings = new HashSet<Booking>();
        }
    
        public int TrainNo { get; set; }
        public string TrainName { get; set; }
        public string FromStation { get; set; }
        public string ToStation { get; set; }
        public string ClassOfTravel { get; set; }
        public Nullable<int> SeatsAvailable { get; set; }
        public string Status { get; set; }
        public string TrainStatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
