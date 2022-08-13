using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusBooking.Repositoty.Models;
using BusBooking.Repositoty.ViewModels;

namespace BusBooking.Repositoty.Interface
{
    public interface IBusBookingRepository
    {
        Task<List<Origins>> GetAllOrigins();
        Task<List<Destinations>> GetAllDestinations();
        Task<List<BusDetailsByOD>> GetAvailableBusDetails(string? Origin, string? Destination);
        Task<List<FilterByAC>> FilterByBusTypeAC(string? Origin, string? Destination);
        Task<List<FilterByNONAC>> FilterByBusTypeNONAC(string? Origin, string? Destination);
        Task<List<FilterByPriceLesser1k>> FilterByPriceLesser1k(string? Origin, string? Destination);
        Task<List<FilterByPriceGreater1k>> FilterByPriceGreater1k(string? Origin, string? Destination);
        Task<List<BookingSummary>> GetBookingDetailsByMobileNo(string? MobileNo);
    }
}
