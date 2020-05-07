using System.Reflection.Metadata;
using System.Collections.Concurrent;
using System.Reflection.Emit;
using System.Data;
using System;

namespace tugas_lab_5
{
    class Program
    {

        public class PrinterWindows
        {
         public virtual void Show()
        {
            Console.WriteLine("Printer Windows display dimension: ");
        }
        
         public virtual void Print()
        {
            Console.WriteLine("Printer Windows printing... ");
        }
        
        }
        
         public class Epson : PrinterWindows
        {
         public override void Show()
        {
            Console.WriteLine("Printer Epson dimension: 10 * 11");
        }

         public override void Print()
        {
            Console.WriteLine("Epson printer printing ...");
        }
        
        }

        public class Canon : PrinterWindows
        {
         public override void Show()
        {
            Console.WriteLine("Printer Canon dimension: 9.5 * 12");
        }

         public override void Print()
        {
            Console.WriteLine("Canon printer printing ...");
        }
        }

        public class LaserJet : PrinterWindows
        {
         public override void Show()
        {
            Console.WriteLine("Printer LaserJet dimension: 12 * 12");
        }

        public override void Print()
        {
            Console.WriteLine("LaserJet printer printing ...");
        }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Pilih Printer: ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. Laser Jet\n");

            Console.Write("Nomor Printer [1..3]: ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            PrinterWindows printer = new PrinterWindows();

            if(nomorPrinter == 1)
            {
            printer = new Epson();
            }
            else if(nomorPrinter == 2)
            {
            printer = new Canon();
            }
           else if(nomorPrinter == 3)
            {
            printer = new LaserJet();
            }
            else
            {
            Console.WriteLine("EROR");
            }
            
            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
            
    }
}
