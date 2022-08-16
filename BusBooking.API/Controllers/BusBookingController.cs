using BusBooking.Business.Interface;
using BusBooking.Models;
using BusBooking.Repositoty.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusBooking.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BusBookingController : Controller
  {
    private readonly IBusBookingBusiness _BusBookingBusiness;
    public BusBookingController(IBusBookingBusiness BusBookingBusiness)
    {
      _BusBookingBusiness = BusBookingBusiness;
    }
    [HttpGet]
    [Route("GetAllOrigins")]

    public async Task<IActionResult> GetOrigins()
    {
      var Origin = await _BusBookingBusiness.GetAllOrigins();
      return Ok(Origin);
    }
    [HttpGet]
    [Route("GetAllDestinations")]
    public async Task<IActionResult> GetDestinations()
    {
      var Destination = await _BusBookingBusiness.GetAllDestinations();
      return Ok(Destination);
    }
    [HttpGet]
    [Route("GetAvailableBusDetails")]
    public async Task<IActionResult> GetAvailableBusDetails(string? Origin, string? Destination)
    {
      var BusDetails = await _BusBookingBusiness.GetAvailableBusDetails(Origin, Destination);
      return Ok(BusDetails);
    }
    [HttpGet]
    [Route("FilterByBusTypeAC")]
    public async Task<IActionResult> FilterByBusTypeAC(string? Origin, string? Destination)
    {
      var BusDetails = await _BusBookingBusiness.FilterByBusTypeAC(Origin, Destination);
      return Ok(BusDetails);
    }
    [HttpGet]
    [Route("FilterByBusTypeNONAC")]
    public async Task<IActionResult> FilterByBusTypeNONAC(string? Origin, string? Destination)
    {
      var BusDetails = await _BusBookingBusiness.FilterByBusTypeNONAC(Origin, Destination);
      return Ok(BusDetails);
    }
    [HttpGet]
    [Route("FilterByPriceLesser1k")]
    public async Task<IActionResult> FilterByPriceLesser1k(string? Origin, string? Destination)
    {
      var BusDetails = await _BusBookingBusiness.FilterByPriceLesser1k(Origin, Destination);
      return Ok(BusDetails);
    }
    [HttpGet]
    [Route("FilterByPriceGreater1k")]
    public async Task<IActionResult> FilterByPriceGreater1k(string? Origin, string? Destination)
    {
      var BusDetails = await _BusBookingBusiness.FilterByPriceGreater1k(Origin, Destination);
      return Ok(BusDetails);
    }
    [HttpGet]
    [Route("GetBookingDetailsByMobileNo")]
    public async Task<IActionResult> GetBookingDetailsByMobileNo(string? MobileNo)
    {
      var PassengerDetails = await _BusBookingBusiness.GetBookingDetailsByMobileNo(MobileNo);
      return Ok(PassengerDetails);
    }
    [HttpGet]
    [Route("GetRoutePointsbyID")]
    public async Task<IActionResult> GetRoutePointsbyID(string? Origin, string? Destination, int? BusID)
    {
      var RoutePoints = await _BusBookingBusiness.GetRoutePointsbyID(Origin, Destination, BusID);
      return Ok(RoutePoints);
    }
    [HttpGet]
    [Route("GetBusDetailsbyIDs")]
    public async Task<IActionResult> GetBusDetailsbyIDs(int? BusId)
    {
      var Details = await _BusBookingBusiness.GetBusDetailsbyIDs(BusId);
      return Ok(Details);
    }
    [HttpPost]
    [Route("Booking")]
    public async Task<IActionResult> Booking(BookingDetailVM book)
    {
      var BookingDetails = await _BusBookingBusiness.Booking(book);
      return Ok(BookingDetails);
    }
    [HttpPost]
    [Route("Register")]
    public async Task<IActionResult> Register(SignUpVM Reg)
    {
      var SignUpDetails = await _BusBookingBusiness.Register(Reg);
      return Ok(SignUpDetails);
    }
  }
}

