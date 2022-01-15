using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace CSharpSecaoQuatorze.ExercicioResolvidoComInterface.Entities
{
    public class CarRental
    {
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public Vehicle vModel { get; set; }
        public Invoice cRInvoice { get; set; }

        public CarRental(DateTime externalStartTime, DateTime externalFinishTime, Vehicle externalVehicle)
        {
            StartTime = externalStartTime;
            FinishTime = externalFinishTime;
            vModel = externalVehicle;
            cRInvoice = null;
        }
    }
}