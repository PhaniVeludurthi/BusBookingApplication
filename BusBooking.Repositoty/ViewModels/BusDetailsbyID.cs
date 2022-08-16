using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBooking.Repositoty.ViewModels
{
  public class BusDetailsbyID
  {
    [Key]
    public int BusID { get; set; }
    public string BusType { get; set; }
    public int BusPrice { get; set; }

  }
}
