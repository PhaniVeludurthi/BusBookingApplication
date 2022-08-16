using System;
using System.Collections.Generic;

#nullable disable

namespace BusBooking.Repositoty.Models
{
    public partial class SignUp
    {
        public SignUp()
        {
            BookingDetails = new HashSet<BookingDetail>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
    }
}
