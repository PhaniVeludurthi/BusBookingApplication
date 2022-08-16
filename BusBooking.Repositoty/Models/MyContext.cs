using BusBooking.Repositoty.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBooking.Repositoty.Models
{
    public class MyContext : BusBookingContext
    {
        public MyContext()
        {
           
        }
        public MyContext(DbContextOptions<BusBookingContext> options)
           : base(options) { }
        public virtual DbSet<Origins> Origin { get; set; }
        public virtual DbSet<Destinations> Destination { get; set; }

        public virtual DbSet<BusDetailsByOD> BusDetailsBYod { get; set; }

        public virtual DbSet<FilterByAC> Filterbyac { get; set; }
        public virtual DbSet<FilterByNONAC> Filterbynonac { get; set; }
        public virtual DbSet<FilterByPriceLesser1k> FilterByPriceLesserthan1k { get; set; }
        public virtual DbSet<FilterByPriceGreater1k> FilterByPriceGreaterthan1k { get; set; }
        public virtual DbSet<BookingSummary> GetBookingSummaries { get; set; }
        public virtual DbSet<RoutePoints> GetRoutePointsbyID { get; set; }
    public virtual DbSet<BusDetailsbyID> GetBusDetailsbyID { get; set; }
  }
}
