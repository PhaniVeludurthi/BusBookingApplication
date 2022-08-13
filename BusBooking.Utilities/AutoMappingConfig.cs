using AutoMapper;
using BusBooking.Repositoty;
using BusBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusBooking.Repositoty.ViewModels;
using BusBooking.Models.NewFolder;
using BusBooking.Models.StoredProcedureModels;

namespace BusBooking.Utilities
{
    public class AutoMappingConfig : Profile
    {
        public AutoMappingConfig()
        {
            CreateMap<BookingDetail, BookingDetailVM>().ReverseMap();
            CreateMap<BusDetail, BusDetailsVM>().ReverseMap();
            CreateMap<PickupStand, PickupStandVM>().ReverseMap();
            CreateMap<Route, RouteDetailsVM>().ReverseMap();
            CreateMap<RouteDetail, RouteDetailsVM>().ReverseMap();
            CreateMap<SeatDetail, SeatDetailVM>().ReverseMap();
            CreateMap<SignUp, SignUpVM>().ReverseMap();
            CreateMap<Origins, OriginsVM>().ReverseMap();
            CreateMap<Destinations, DestinationsVM>().ReverseMap();
            CreateMap<BusDetailsByOD, BusDetailsByODVM>().ReverseMap();
            CreateMap<FilterByAC, FilterByACVM>().ReverseMap();
            CreateMap<FilterByNONAC, FilterByNONACVM>().ReverseMap();
            CreateMap<FilterByPriceLesser1k, FilterByPriceLesser1kVM>().ReverseMap();
            CreateMap<FilterByPriceGreater1k, FilterByPriceGreater1kVM>().ReverseMap();
            CreateMap<BookingSummary,BookingSummaryVM>().ReverseMap();


        }
    }
}
