using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoQuatorze.ExercicioResolvidoComInterface.Services;

namespace CSharpSecaoQuatorze.ExercicioResolvidoComInterface.Entities
{
    public class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double externalBasicPayment, double externalTax)
        {
            BasicPayment = externalBasicPayment;
            Tax = externalTax;
        }

        public double TotalPayment
        {
            get
            {
                return BasicPayment + Tax;
            }
        }

        public override string ToString()
        {
            return "Basic payment: "
            + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTax: "
            + Tax.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTotal payment: "
            + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}