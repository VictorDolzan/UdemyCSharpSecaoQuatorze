using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoQuatorze.AtividadeHerancaMultipla.Devices;

namespace CSharpSecaoQuatorze.AtividadeHerancaMultipla
{
    public class AtividadeHerancaMultipla
    {
        public static void ExecutarAtividadeHerancaMultipla()
        {
            Printer p = new Printer(){
             SerialNumber = 1080 
            };

            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner(){
                SerialNumber = 2003
            };

            s.ProcessDoc("My E-mail");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice(){ 
                SerialNumber = 3921 
            };

            c.ProcessDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());
        }
    }
}