using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoQuatorze.ExercicioDeFixacao.Entities;

namespace CSharpSecaoQuatorze.ExercicioDeFixacao.Services
{
    public class PaypalService : IOnlinePaymentService
    {
         private const double FeePercentage = 0.02;
         private const double MonthlyInterest = 0.01;

        public double Interest(double amount, int months) {
            return amount * MonthlyInterest * months;
        }
        public double PaymentFee(double amount) {
            return amount * FeePercentage;
        }
    }
}