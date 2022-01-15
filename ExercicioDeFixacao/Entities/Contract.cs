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
    public class Contract
    {
        public int CNumber { get; set; } 
        public DateTime CDate { get; set; }
        public double CTotalValue { get; set; }
        public List<Installment> CInstallment { get; set; } 

        public Contract(int externalNumber, DateTime externalcDate, double externalTotalValue)
        {
            CNumber = externalNumber;
            CDate = externalcDate;
            CTotalValue = externalTotalValue;
            CInstallment = new List<Installment>(); 
        }

        public void AddInstallment(Installment externalInstallment)
        {
            CInstallment.Add(externalInstallment);
        }      
    }
}