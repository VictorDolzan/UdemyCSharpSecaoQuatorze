using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoQuatorze.ExercicioResolvidoComInterface.Entities;
using CSharpSecaoQuatorze.ExercicioResolvidoComInterface.Services;

namespace CSharpSecaoQuatorze.ExercicioResolvidoComInterface
{
    public class ExercicioResolvidoComInterface
    {
        public static void ExecutarExercicioResolvidoComInterface()
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string cModel = Console.ReadLine();
            Console.Write("Pickup (MM/dd/yyyy hh:mm): ");
            DateTime pUpDate = DateTime.ParseExact(
                Console.ReadLine(),
                "MM/dd/yyyy HH:mm",
                CultureInfo.InvariantCulture
             );
            Console.Write("Return (MM/dd/yyyy hh:mm): ");
            DateTime rDate = DateTime.ParseExact(
                Console.ReadLine(),
                "MM/dd/yyyy HH:mm",
                CultureInfo.InvariantCulture
            );

            Console.Write("Enter price per hour: ");
            double pPerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double pPerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(
                pUpDate,
                rDate,
                new Vehicle(cModel)
            );

            RentalService rentalService = new RentalService(
                pPerHour,
                pPerDay,
                new BrazilTaxService()
            );

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.cRInvoice);

        }
    }
}