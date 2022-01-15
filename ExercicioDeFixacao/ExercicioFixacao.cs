using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoQuatorze.ExercicioDeFixacao.Entities;
using CSharpSecaoQuatorze.ExercicioDeFixacao.Services;

namespace CSharpSecaoQuatorze.ExercicioDeFixacao
{
    public class ExercicioFixacao
    {
        public static void ExecutarExercicioFixacao()
        {
            Console.WriteLine("Enter Contract Data: ");
            Console.Write("Number: ");
            int contactNumber = int.Parse(Console.ReadLine());

            Console.Write("Date (MM/dd/yyyy): ");
            DateTime cDate = DateTime.ParseExact(
                Console.ReadLine(),
                "MM/dd/yyyy",
                CultureInfo.InvariantCulture
            );

            Console.Write("Contract value: ");
            double cValue = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract c1 = new Contract(contactNumber, cDate, cValue);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(c1, months);

            Console.WriteLine("Installments: ");
            foreach(Installment installment in c1.CInstallment)
            {
                Console.WriteLine(installment);
            }

        }
    }
}