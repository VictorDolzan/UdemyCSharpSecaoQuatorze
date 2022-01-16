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
    class ContractService
    {
        private IOnlinePaymentService _OnlinePaymentService;
 
        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _OnlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.CTotalValue / months;

            for(int i = 1; i <= months; i++)
            {
                DateTime date = contract.CDate.AddMonths(i);
                double updateQuota = basicQuota + _OnlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updateQuota + _OnlinePaymentService.PaymentFee(updateQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}