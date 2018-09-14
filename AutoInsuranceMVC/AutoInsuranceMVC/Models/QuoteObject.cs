using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoInsuranceMVC.Models
{
    public partial class QuoteObject
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime Dob { get; set; }
        public int CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public int Duis { get; set; }
        public int SpeedingTickets { get; set; }
        public string Coverage { get; set; }
        public int QuoteValue { get; set; }
    }
}