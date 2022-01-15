using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoQuatorze.ExercicioResolvidoComInterface;
using CSharpSecaoQuatorze.ExercicioResolvidoComInterface.Entities;

namespace CSharpSecaoQuatorze.ExercicioResolvidoComInterface.Services
{
    class RentalService 
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        //Forma inadequada:
        private ITaxService _taxService;
    
        public RentalService(double externalPricePerHour, double externalPricePerDay, ITaxService externalTaxService)
        {
            PricePerHour = externalPricePerHour;
            PricePerDay = externalPricePerDay;
            _taxService = externalTaxService;
        }

        public void ProcessInvoice(CarRental externalCarRental)
        {
            TimeSpan duration = externalCarRental.FinishTime.Subtract(externalCarRental.StartTime);

            double basicPayment = 0.0;

            basicPayment = duration.TotalHours <= 12.0 ? PricePerHour * Math.Ceiling(duration.TotalHours)
            : PricePerDay * Math.Ceiling(duration.TotalDays);  
            
            double tax = _taxService.Tax(basicPayment);

            externalCarRental.cRInvoice = new Invoice(basicPayment, tax);
        }        
    }
}