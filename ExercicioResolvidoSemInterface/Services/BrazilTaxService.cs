using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoQuatorze.ExercicioResolvidoSemInterface;
using CSharpSecaoQuatorze.ExercicioResolvidoSemInterface.Entities;
using CSharpSecaoQuatorze.ExercicioResolvidoSemInterface.Services;

namespace CSharpSecaoQuatorze.ExercicioResolvidoSemInterface.Services
{
    public class BrazilTaxService
    {
        public  double TotalTax { get; private set; }
        public double Tax(double amount)
        {
            if(amount > 100)
            {
                return amount * 0.15;
            }
            else
            {
                return amount * 0.2;
            }            
        }
    }
}