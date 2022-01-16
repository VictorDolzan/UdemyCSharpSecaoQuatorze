using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoQuatorze.AtividadeDeHerdarVsContrato.Model.Enums;

namespace CSharpSecaoQuatorze.AtividadeDeHerdarVsContrato.Model.Entities
{
     abstract class AbstractShape : IShape
    {
        public Color color { get; set; }
        public abstract double Area();
    }
}