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
    class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return "Circle Color = "
            + color
            + ", radius = "
            + Radius.ToString("F2", CultureInfo.InvariantCulture)
            + ", area = "
            + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}