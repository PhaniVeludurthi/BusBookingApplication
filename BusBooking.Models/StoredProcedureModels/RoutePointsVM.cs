using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBooking.Models.StoredProcedureModels
{
  public class RoutePointsVM
  {
    [Key]
    public string RoutePoint { get; set; }
    public string ArivalTime { get; set; }
    public string DepartureTime { get; set; }
  }
}
