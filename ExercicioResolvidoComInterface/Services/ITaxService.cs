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
    interface ITaxService
    {
        double Tax(double amount);
        
    }
}