using BusBooking.Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusBooking.Repositoty.Interface;
using AutoMapper;

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
    }
}
