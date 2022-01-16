using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoQuatorze.AtividadeDeHerdarVsContrato.Model;
using CSharpSecaoQuatorze.AtividadeDeHerdarVsContrato.Model.Entities;
using CSharpSecaoQuatorze.AtividadeDeHerdarVsContrato.Model.Enums;

namespace CSharpSecaoQuatorze.AtividadeDeHerdarVsContrato
{
    class AtividadeDeHerdarVsContrato
    {
        public static void ExecutarAtividadeDeHerdarVsContrato()
        {
            IShape s1 = new Circle(){
             Radius = 2.0, 
             color = Color.White
            };

            IShape s2 = new Rectangle(){ 
             Width = 3.5, 
             Height = 4.2, 
             color = Color.Black 
            };

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        } 
    }
}