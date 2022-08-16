using BusBooking.Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusBooking.Repositoty.Interface;
using AutoMapper;
using BusBooking.Models;
using BusBooking.Repositoty.ViewModels;
using BusBooking.Models.NewFolder;
using BusBooking.Models.StoredProcedureModels;
using BusBooking.Repositoty.Models;

namespace BusBooking.Business
{
    public class BusBookingBusiness : IBusBookingBusiness
    {
        private readonly IBusBookingRepository _BusBookingRepository;
        private readonly IMapper _mapper;
        public BusBookingBusiness(IBusBookingRepository BusBookingRepository, IMapper mapper)
        {
            _BusBookingRepository = BusBookingRepository;
            _mapper = mapper;
        }
        public async Task<List<OriginsVM>> GetAllOrigins()
        {
            var list = await _BusBookingRepository.GetAllOrigins();
            return _mapper.Map<List<OriginsVM>>(list);
        }
        public async Task<List<DestinationsVM>> GetAllDestinations()
        {
            var list = await _BusBookingRepository.GetAllDestinations();
            return _mapper.Map<List<DestinationsVM>>(list);
        }

        public async Task<List<BusDetailsByODVM>> GetAvailableBusDetails(string? Origin, string? Destination)
        {
            var list = await _BusBookingRepository.GetAvailableBusDetails(Origin, Destination);
            return _mapper.Map<List<BusDetailsByODVM>>(list);
        }
        public async Task<List<FilterByACVM>> FilterByBusTypeAC(string? Origin, string? Destination)
        {
            var list = await _BusBookingRepository.FilterByBusTypeAC(Origin, Destination);
            return _mapper.Map<List<FilterByACVM>>(list);
        }
        public async Task<List<FilterByNONACVM>> FilterByBusTypeNONAC(string? Origin, string? Destination)
        {
            var list = await _BusBookingRepository.FilterByBusTypeNONAC(Origin, Destination);
            return _mapper.Map<List<FilterByNONACVM>>(list);
        }
        public async Task<List<FilterByPriceLesser1kVM>> FilterByPriceLesser1k(string? Origin, string? Destination)
        {
            var list = await _BusBookingRepository.FilterByPriceLesser1k(Origin, Destination);
            return _mapper.Map<List<FilterByPriceLesser1kVM>>(list);
        }
        public async Task<List<FilterByPriceGreater1kVM>> FilterByPriceGreater1k(string? Origin, string? Destination)
        {
            var list = await _BusBookingRepository.FilterByPriceGreater1k(Origin, Destination);
            return _mapper.Map<List<FilterByPriceGreater1kVM>>(list);
        }
        public async Task<List<BookingSummaryVM>> GetBookingDetailsByMobileNo(string? MobileNo)
        {
            var list = await _BusBookingRepository.GetBookingDetailsByMobileNo(MobileNo);
            return _mapper.Map<List<BookingSummaryVM>>(list);
        }
    public async Task<List<RoutePointsVM>> GetRoutePointsbyID(string? Origin, string? Destination, int? BusID)
    {
      var list = await _BusBookingRepository.GetRoutePointsbyID(Origin,Destination,BusID);
      return _mapper.Map<List<RoutePointsVM>>(list);
    }
    public async Task<List<BusDetailsbyIDVM>> GetBusDetailsbyIDs(int? BusId)
    {
      var list = await _BusBookingRepository.GetBusDetailsbyIDs(BusId);
      return _mapper.Map<List<BusDetailsbyIDVM>>(list);
    }
    public async Task<BookingDetailVM> Booking(BookingDetailVM book)
    {
      var list = await _BusBookingRepository.Booking(_mapper.Map<BookingDetail>(book));
      return _mapper.Map<BookingDetailVM>(list);
    }
    public async Task<SignUpVM> Register(SignUpVM Reg)
    {
      var list = await _BusBookingRepository.Register(_mapper.Map<SignUp>(Reg));
      return _mapper.Map<SignUpVM>(list);
    }


  }
}
