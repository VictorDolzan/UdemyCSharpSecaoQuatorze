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
    class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "Rectangle color = "
            + color
            + ", width = "
            + Width.ToString("F2", CultureInfo.InvariantCulture)
            + ", height = "
            + Height.ToString("F2", CultureInfo.InvariantCulture)
            + ", area = "
            + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}