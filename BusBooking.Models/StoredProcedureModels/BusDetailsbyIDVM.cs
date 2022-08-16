using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBooking.Models.StoredProcedureModels
{
  public class BusDetailsbyIDVM
  {
    [Key]
    public int BusID { get; set; }
    public string BusType { get; set; }
    public int BusPrice { get; set; }
  }
}
