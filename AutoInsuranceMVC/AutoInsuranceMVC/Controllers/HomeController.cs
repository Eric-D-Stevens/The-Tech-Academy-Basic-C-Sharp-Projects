using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoInsuranceMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetQuote(string FirstName, string LastName, string EmailAddress,
            DateTime Dob, int CarYear, string CarMake, string CarModel, 
            int Duis, int SpeedingTickets, string Coverage)
        {

            // Base Fee
            double Quote = 50;

            // Get Age and Calculate Age Rates
            int Age = 0;
            DateTime now = DateTime.Now;
            if(now.Month > Dob.Month) { Age = now.Year - Dob.Year; }
            else if(now.Month < Dob.Month) { Age = now.Year - Dob.Year - 1; }
            else if (now.Month == Dob.Month)
            {
                if (now.Day > Dob.Day) { Age = now.Year - Dob.Year; }
                else if (now.Day < Dob.Day) { Age = now.Year - Dob.Year - 1; }
                else { Age = now.Year - Dob.Year; }
            }
            if (Age < 25) { Quote += 25; }
            if (Age < 18) { Quote += 75; }
            if (Age > 100) { Quote += 25; }

            // Car Attributes
            if (CarYear < 2000) { Quote += 25; }
            if (CarYear > 2015) { Quote += 25; }
            if (CarMake=="Porsche")
            {
                if(CarModel == "911 Carrera") { Quote += 50; }
                else { Quote += 25; }
            }

            // Driving History
            Quote += 10 * SpeedingTickets;
            if(Duis > 0) { Quote += Quote * 0.25; }

            // Coverage Type
            if (Coverage == "Full") { Quote += Quote * 0.50; }


            // Database Insert of all Data
            using (AutoQuoteEntities1 db = new AutoQuoteEntities1())
            {
                var quote = new Quote();
                quote.FirstName = FirstName;
                quote.LastName = LastName;
                quote.EmailAddress = EmailAddress;
                quote.Dob = Dob;
                quote.CarYear = CarYear;
                quote.CarMake = CarMake;
                quote.CarModel = CarModel;
                quote.QuoteValue = Convert.ToInt32(Quote);

                db.Quotes.Add(quote);
                db.SaveChanges();

                ViewBag.Message = quote;
            }

            



                return View("TheQuote");
        }

        public ActionResult Admin()
        {   
            using (AutoQuoteEntities1 db = new AutoQuoteEntities1())
            {
                var dbQuotes = db.Quotes;
                var quotes = new List<Quote>();
                foreach(var quote in dbQuotes)
                {
                    var aQuote = new Quote();
                    aQuote.FirstName = quote.FirstName;
                    aQuote.LastName = quote.LastName;
                    aQuote.EmailAddress = quote.EmailAddress;
                    aQuote.Dob = quote.Dob;
                    aQuote.CarYear = quote.CarYear;
                    aQuote.CarMake = quote.CarMake;
                    aQuote.CarModel = quote.CarModel;
                    aQuote.QuoteValue = quote.QuoteValue;
                    quotes.Add(aQuote);

                }

                ViewBag.Message = quotes;
            
                return View();
            }
        }
    }

}