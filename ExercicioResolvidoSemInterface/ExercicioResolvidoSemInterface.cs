using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoQuatorze.ExercicioResolvidoSemInterface.Entities;
using CSharpSecaoQuatorze.ExercicioResolvidoSemInterface.Services;

namespace CSharpSecaoQuatorze.ExercicioResolvidoSemInterface
{
    public class ExercicioResolvidoSemInterface
    {
        public static void ExecutarExercicioResolvidoSemInterface()
        {
            try
            {
                Console.WriteLine("Enter rental data");
                Console.Write("Car model: ");
                string cModel = Console.ReadLine();
                Console.Write("Pickup (MM/dd/yyyy hh:mm): ");
                DateTime pUpDate = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture);
                Console.Write("Return (MM/dd/yyyy hh:mm): ");
                DateTime rDate = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture);

                CarRental carRental = new CarRental(pUpDate, rDate, new Vehicle(cModel));


                Console.Write("Enter price per hour: ");
                double pPerHour = double.Parse(Console.ReadLine());
                Console.Write("Enter price per day: ");
                double pPerDay = double.Parse(Console.ReadLine());

            }
            catch(SystemException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}