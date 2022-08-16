using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBooking.Repositoty.ViewModels
{
  public class RoutePoints
  {
    [Key]
    public string RoutePoint { get; set; }
    public string ArivalTime { get; set; }
    public string DepartureTime { get; set; }
  }
}
