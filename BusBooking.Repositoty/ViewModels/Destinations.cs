using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBooking.Repositoty.ViewModels
{
   public  class Destinations
    {
        [Key]
        public string Destination { get; set; }
    }
}
