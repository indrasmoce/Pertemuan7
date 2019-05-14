using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagu2
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            Console.WriteLine("Pilih Printer : ");
            Console.WriteLine("1. Epson  ");
            Console.WriteLine("2. Canon  ");
            Console.WriteLine("3. Laser Jet  ");
            Console.Write("Nomor Pirnter [1..3] : ");
            int nomoPrinter = Convert.ToInt32(Console.ReadLine());
            if (nomoPrinter == 1)
            {
                printer = new Epson();
            }
            else if (nomoPrinter == 2)
            {
                printer = new Canon();

            }
            else
                printer = new LaserJet();

            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }
}
