using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoQuatorze.ExercicioResolvidoSemInterface.Services;

namespace CSharpSecaoQuatorze.ExercicioResolvidoSemInterface.Entities
{
    public class Vehicle
    {
        public string Model { get; set; }

        public Vehicle(string externalModel)
        {
            Model = externalModel;
        }
    }
}