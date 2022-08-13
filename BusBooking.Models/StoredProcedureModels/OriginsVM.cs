using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBooking.Models
{
    public class OriginsVM
    {
        [Key]
        public string Origin { get; set; }
    }
}
