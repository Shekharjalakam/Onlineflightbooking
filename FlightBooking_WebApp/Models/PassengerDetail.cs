namespace FlightBooking_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PassengerDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PassengerId { get; set; }

        [Required]
        [StringLength(20)]
        public string PassengerName { get; set; }

        public int PassengerAge { get; set; }

        [Required]
        [StringLength(10)]
        public string PassengerGender { get; set; }

        [Required]
        [StringLength(50)]
        public string PassengerEmail { get; set; }

        public int BookingId { get; set; }

        public int TravelPriceId { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(128)]
        public string CreatedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        [Required]
        [StringLength(128)]
        public string ModifiedBy { get; set; }

        public virtual Booking Booking { get; set; }
    }
}
