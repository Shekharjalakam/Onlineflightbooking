namespace FlightBooking_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Payment")]
    public partial class Payment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PaymentId { get; set; }

        public int BookingId { get; set; }

        [Required]
        [StringLength(50)]
        public string AccountHolderName { get; set; }

        public int AccountNumber { get; set; }

        public int Amount { get; set; }

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
