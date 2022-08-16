using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBooking.Models.NewFolder
{
    public class FilterByNONACVM
    {
        [Key]
        public int BusID { get; set; }
        public string BusNumber { get; set; }
        public string BusName { get; set; }
        public string BusType { get; set; }
        public int TotalSeats { get; set; }
        public int StartsFrom { get; set; }
        public string EstimatedTime { get; set; }
    }
}
