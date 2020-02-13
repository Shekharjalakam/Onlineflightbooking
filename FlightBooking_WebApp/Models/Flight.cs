namespace FlightBooking_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Flight
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Flight()
        {
            FlightSchedules = new HashSet<FlightSchedule>();
            FlightSchedules1 = new HashSet<FlightSchedule>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FlightId { get; set; }

        [Required]
        [StringLength(30)]
        public string FlightNumber { get; set; }

        public int FromAirportCode { get; set; }

        public int ToAirportCode { get; set; }

        public int StopOverCity { get; set; }

        [Required]
        [StringLength(50)]
        public string FlightCarrierName { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(128)]
        public string CreatedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        [Required]
        [StringLength(128)]
        public string ModifiedBy { get; set; }

        public virtual Airport Airport { get; set; }

        public virtual Airport Airport1 { get; set; }

        public virtual Airport Airport2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightSchedule> FlightSchedules { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightSchedule> FlightSchedules1 { get; set; }
    }
}
