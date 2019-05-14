using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagu2
{
    public class Printer
    {
        public String Name { get; set; }
        public virtual void Print()
        {
            Console.WriteLine("Sedang Mencetak ");
        }
        public virtual void Show()
        {
            Console.WriteLine("Dimensi Yang ditunjukan ");
        }
    }
    public class Epson : Printer
    {
        public override void Show()
        {
            Console.WriteLine("Epson Display Dimension =  10*11");
            
        }
        public override void Print()
        {
            Console.WriteLine("Epson Printer Printing...");
        }
    }
    public class Canon : Printer
    {
        public override void Show()
        {
            Console.WriteLine("Canon Display Dimension =  9.5*12");
            
        }
        public override void Print()
        {
            Console.WriteLine("Canon Printer Printing...");
        }
    }
    public class LaserJet : Printer
    {
        public override void Show()
        {
            Console.WriteLine("Laser Jet  Display Dimension =  12*12");
            
        }
        public override void Print()
        {
            Console.WriteLine("Laser Jet Printer Printing...");
        }
    }
}
