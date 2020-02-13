namespace FlightBooking_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LuggageAllowance")]
    public partial class LuggageAllowance
    {
        [Key]
        [Column("LuggageAllowance")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LuggageAllowance1 { get; set; }

        public int FlightScheduleId { get; set; }

        public int WeightOfLuggageAllowance { get; set; }

        public int TravelClassId { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(128)]
        public string CreatedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        [Required]
        [StringLength(128)]
        public string ModifiedBy { get; set; }

        public virtual LuggageAllowance LuggageAllowance11 { get; set; }

        public virtual LuggageAllowance LuggageAllowance2 { get; set; }

        public virtual TravelClass TravelClass { get; set; }
    }
}
