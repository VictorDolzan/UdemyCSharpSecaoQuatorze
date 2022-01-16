using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoQuatorze.AtividadeHerancaMultipla.Devices
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice processing " + document);
        }
          public void Print(string document)
        {
            Console.WriteLine("ComboDevice print" + document);
        }
        public string Scan()
        {
            return "ComboDevice scan result";
        }
    }
}