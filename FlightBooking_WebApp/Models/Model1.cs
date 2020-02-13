namespace FlightBooking_WebApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=TravelAround")
        {
        }

        public virtual DbSet<Airport> Airports { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<FlightSchedule> FlightSchedules { get; set; }
        public virtual DbSet<LuggageAllowance> LuggageAllowances { get; set; }
        public virtual DbSet<PassengerDetail> PassengerDetails { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<TravelClass> TravelClasses { get; set; }
        public virtual DbSet<TravelPrice> TravelPrices { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Airport>()
                .HasMany(e => e.Flights)
                .WithRequired(e => e.Airport)
                .HasForeignKey(e => e.ToAirportCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Airport>()
                .HasMany(e => e.Flights1)
                .WithRequired(e => e.Airport1)
                .HasForeignKey(e => e.StopOverCity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Airport>()
                .HasMany(e => e.Flights2)
                .WithRequired(e => e.Airport2)
                .HasForeignKey(e => e.FromAirportCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetRole>()
                .HasMany(e => e.AspNetUserRoles)
                .WithRequired(e => e.AspNetRole)
                .HasForeignKey(e => e.RoleId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserRoles)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Booking>()
                .HasMany(e => e.PassengerDetails)
                .WithRequired(e => e.Booking)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Booking>()
                .HasMany(e => e.Payments)
                .WithRequired(e => e.Booking)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Flight>()
                .HasMany(e => e.FlightSchedules)
                .WithRequired(e => e.Flight)
                .HasForeignKey(e => e.FlightId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Flight>()
                .HasMany(e => e.FlightSchedules1)
                .WithRequired(e => e.Flight1)
                .HasForeignKey(e => e.FlightId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LuggageAllowance>()
                .HasOptional(e => e.LuggageAllowance11)
                .WithRequired(e => e.LuggageAllowance2);

            modelBuilder.Entity<PassengerDetail>()
                .Property(e => e.PassengerName)
                .IsFixedLength();

            modelBuilder.Entity<PassengerDetail>()
                .Property(e => e.PassengerGender)
                .IsFixedLength();

            modelBuilder.Entity<Payment>()
                .Property(e => e.AccountHolderName)
                .IsFixedLength();

            modelBuilder.Entity<TravelClass>()
                .HasMany(e => e.Bookings)
                .WithRequired(e => e.TravelClass)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TravelClass>()
                .HasMany(e => e.LuggageAllowances)
                .WithRequired(e => e.TravelClass)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TravelClass>()
                .HasOptional(e => e.TravelClasses1)
                .WithRequired(e => e.TravelClass1);

            modelBuilder.Entity<TravelClass>()
                .HasMany(e => e.TravelPrices)
                .WithRequired(e => e.TravelClass)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TravelPrice>()
                .Property(e => e.AdultPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TravelPrice>()
                .Property(e => e.ChildPrice)
                .HasPrecision(18, 0);
        }
    }
}
