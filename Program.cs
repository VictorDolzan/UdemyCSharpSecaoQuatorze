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
using CSharpSecaoQuatorze.AtividadeDeHerdarVsContrato;
using CSharpSecaoQuatorze.AtividadeDeHerdarVsContrato.Model;
using CSharpSecaoQuatorze.AtividadeDeHerdarVsContrato.Model.Enums;
using CSharpSecaoQuatorze.AtividadeHerancaMultipla;
using CSharpSecaoQuatorze.AtividadeHerancaMultipla.Devices;

namespace CSharpSecaoQuatorze
{
    class Program
    {
        public static void Main(string[] args)
        {
           // ExercicioResolvidoSemInterface.ExercicioResolvidoSemInterface.ExecutarExercicioResolvidoSemInterface();
            //ExercicioFixacao.ExecutarExercicioFixacao();
            //AtividadeDeHerdarVsContrato.AtividadeDeHerdarVsContrato.ExecutarAtividadeDeHerdarVsContrato();
            AtividadeHerancaMultipla.AtividadeHerancaMultipla.ExecutarAtividadeHerancaMultipla();
        }
    }
}
