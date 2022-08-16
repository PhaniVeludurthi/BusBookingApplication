using BusBooking.Repositoty;
using BusBooking.Repositoty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBooking.Models
{
    public class SignUpVM
    {
        public SignUpVM()
        {
           /* BookingDetails = new HashSet<BookingDetail>();*/
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

       /* public virtual ICollection<BookingDetail> BookingDetails { get; set; }*/
    }
}
