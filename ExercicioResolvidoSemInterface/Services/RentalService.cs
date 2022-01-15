using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoQuatorze.ExercicioResolvidoSemInterface;
using CSharpSecaoQuatorze.ExercicioResolvidoSemInterface.Entities;

namespace CSharpSecaoQuatorze.ExercicioResolvidoSemInterface.Services
{
    class RentalService 
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        //Forma inadequada:
        private BrazilTaxService _brazilTaxService = new BrazilTaxService();
    
        public RentalService(double externalPricePerHour, double externalPricePerDay)
        {
            PricePerHour = externalPricePerHour;
            PricePerDay = externalPricePerDay;
        }

        public void ProcessInvoice(CarRental externalCarRental)
        {
            TimeSpan duration = externalCarRental.FinishTime.Subtract(externalCarRental.StartTime);

            double basicPayment = 0.0;
            if(duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else 
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _brazilTaxService.Tax(basicPayment);

            externalCarRental.cRInvoice = new Invoice(basicPayment, tax);
        }
    }
}