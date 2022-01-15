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
using CSharpSecaoQuatorze.ExercicioDeFixacao.Entities;
using CSharpSecaoQuatorze.ExercicioDeFixacao.Services;
using CSharpSecaoQuatorze.ExercicioDeFixacao;

namespace CSharpSecaoQuatorze
{
    class Program
    {
        public static void Main(string[] args)
        {
           // ExercicioResolvidoSemInterface.ExercicioResolvidoSemInterface.ExecutarExercicioResolvidoSemInterface();
            ExercicioFixacao.ExecutarExercicioFixacao();
        }
    }
}
