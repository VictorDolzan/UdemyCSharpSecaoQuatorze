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
    public class BrazilTaxService : ITaxService
    {
        public  double TotalTax { get; private set; }
        public double Tax(double amount)
        {
           if(amount <= 100)
           {
               return amount * 0.2;
           }
           else
           {
               return amount * 0.15;
           }          
        }
    }
}