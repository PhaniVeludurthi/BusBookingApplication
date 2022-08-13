using BusBooking.Repositoty.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusBooking.Repositoty.ViewModels;
using BusBooking.Repositoty.Models;
using Microsoft.EntityFrameworkCore;

namespace BusBooking.Repositoty
{
   public class BusBookingRepository : IBusBookingRepository
    {

        private readonly MyContext _myContext;
        public BusBookingRepository(MyContext myContext)
        {
            _myContext = myContext;
        }
        public async Task<List<Origins>> GetAllOrigins()
        {
            var result = await _myContext.Origin.FromSqlRaw("exec GetAllOrigins").ToListAsync();
            return result;
        }

        public async Task<List<Destinations>> GetAllDestinations()
        {
            var result = await _myContext.Destination.FromSqlRaw("exec GetAllDestinations").ToListAsync();
            return result;
        }

        public async Task<List<BusDetailsByOD>> GetAvailableBusDetails(string? Origin, string? Destination)
        {
            var result = await _myContext.BusDetailsBYod.FromSqlRaw("exec GetAvailableBusDetails {0},{1}", Origin,Destination).ToListAsync();
            return result;
        }
        public async Task<List<FilterByAC>> FilterByBusTypeAC(string? Origin, string? Destination)
        {
            var result = await _myContext.Filterbyac.FromSqlRaw("exec FilterByBusTypeAC {0},{1}", Origin, Destination).ToListAsync();
            return result;
        }
        public async Task<List<FilterByNONAC>> FilterByBusTypeNONAC(string? Origin, string? Destination)
        {
            var result = await _myContext.Filterbynonac.FromSqlRaw("exec FilterByBusTypeNONAC {0},{1}", Origin, Destination).ToListAsync();
            return result;
        }
        public async Task<List<FilterByPriceLesser1k>> FilterByPriceLesser1k(string? Origin, string? Destination)
        {
            var result = await _myContext.FilterByPriceLesserthan1k.FromSqlRaw("exec FilterByPriceLesser1k {0},{1}", Origin, Destination).ToListAsync();
            return result;
        }
        public async Task<List<FilterByPriceGreater1k>> FilterByPriceGreater1k(string? Origin, string? Destination)
        {
            var result = await _myContext.FilterByPriceGreaterthan1k.FromSqlRaw("exec FilterByPriceGreater1k {0},{1}", Origin, Destination).ToListAsync();
            return result;
        }
        public async Task<List<BookingSummary>> GetBookingDetailsByMobileNo(string? MobileNo)
        {
            var result = await _myContext.GetBookingSummaries.FromSqlRaw("exec GetBookingDetailsByMobileNo {0}", MobileNo).ToListAsync();
            return result;
        }



    }
}
