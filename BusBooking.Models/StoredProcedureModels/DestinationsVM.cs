using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBooking.Models
{
    public class DestinationsVM
    {
        [Key]
        public string Destination{ get; set; }
    }
}
