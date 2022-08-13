using BusBooking.Models;
using BusBooking.Models.NewFolder;
using BusBooking.Models.StoredProcedureModels;
using BusBooking.Repositoty.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBooking.Business.Interface
{
    public interface IBusBookingBusiness
    {
        Task<List<OriginsVM>> GetAllOrigins();
        Task<List<DestinationsVM>> GetAllDestinations();

        Task<List<BusDetailsByODVM>> GetAvailableBusDetails(string Origin, string Destination);
        Task<List<FilterByACVM>> FilterByBusTypeAC(string? Origin, string? Destination);
        Task<List<FilterByNONACVM>> FilterByBusTypeNONAC(string? Origin, string? Destination);

        Task<List<FilterByPriceLesser1kVM>> FilterByPriceLesser1k(string? Origin, string? Destination);
        Task<List<FilterByPriceGreater1kVM>> FilterByPriceGreater1k(string? Origin, string? Destination);
        Task<List<BookingSummaryVM>> GetBookingDetailsByMobileNo(string? MobileNo);
    }
}
