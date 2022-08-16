using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BusBooking.Repositoty.Models
{
    public partial class BusBookingContext : DbContext
    {
        public BusBookingContext()
        {
        }

        public BusBookingContext(DbContextOptions<BusBookingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BookingDetail> BookingDetails { get; set; }
        public virtual DbSet<BusDetail> BusDetails { get; set; }
        public virtual DbSet<PickupStand> PickupStands { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<RouteDetail> RouteDetails { get; set; }
        public virtual DbSet<SignUp> SignUps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB;Initial Catalog=BusBooking; Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookingDetail>(entity =>
            {
                entity.HasKey(e => e.BookingId);

                entity.ToTable("BookingDetail");

                entity.Property(e => e.BookingId).HasColumnName("BookingID");

                entity.Property(e => e.BusId).HasColumnName("BusID");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SeatNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SeatType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TravelDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Bus)
                    .WithMany(p => p.BookingDetails)
                    .HasForeignKey(d => d.BusId)
                    .HasConstraintName("FK_BookingDetail_BusDetails");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BookingDetails)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_BookingDetail_SignUP");
            });

            modelBuilder.Entity<BusDetail>(entity =>
            {
                entity.HasKey(e => e.BusId);

                entity.Property(e => e.BusId).HasColumnName("BusID");

                entity.Property(e => e.BusName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BusNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BusType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PickupStand>(entity =>
            {
                entity.HasKey(e => e.PickId);

                entity.ToTable("PickupStand");

                entity.Property(e => e.PickId).HasColumnName("PickID");

                entity.Property(e => e.BusId).HasColumnName("BusID");

                entity.Property(e => e.EstimatedTime)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.HasOne(d => d.Bus)
                    .WithMany(p => p.PickupStands)
                    .HasForeignKey(d => d.BusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PickupStand_BusDetails");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.PickupStands)
                    .HasForeignKey(d => d.RouteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PickupStand_Routes");
            });

            modelBuilder.Entity<Route>(entity =>
            {
                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.Destination)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Origin)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RouteDetail>(entity =>
            {
                entity.Property(e => e.RouteDetailId).HasColumnName("RouteDetailID");

                entity.Property(e => e.ArivalTime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartureTime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PickId).HasColumnName("PickID");

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.RoutePoint)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pick)
                    .WithMany(p => p.RouteDetails)
                    .HasForeignKey(d => d.PickId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RouteDetails_PickupStand");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.RouteDetails)
                    .HasForeignKey(d => d.RouteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RouteDetails_Routes");
            });

            modelBuilder.Entity<SignUp>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("SignUP");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
