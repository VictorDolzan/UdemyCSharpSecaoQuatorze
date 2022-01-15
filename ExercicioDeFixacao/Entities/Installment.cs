using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoQuatorze.ExercicioDeFixacao.Services;

namespace CSharpSecaoQuatorze.ExercicioDeFixacao.Entities
{
    public class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime externalDueDate, double externalAmount)
        {
            DueDate = externalDueDate;
            Amount = externalAmount;
        }

        public override string ToString() {
            return DueDate.ToString("MM/dd/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}