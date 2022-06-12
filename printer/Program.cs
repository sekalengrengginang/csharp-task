using System;

namespace Printer
{
    class Program
    {

        static void Main(string[] args)
        {
            PrinterWindows printer;

            Console.WriteLine("Pilih Printer: ");
            Console.WriteLine("1.LaserJet");
            Console.WriteLine("2.Canon");
            Console.WriteLine("3.Epson");

            Console.WriteLine("Nomor Printer [1...3: ");
            int nomorPrinter = Convert.ToInt32((Console.ReadLine()));

            if (nomorPrinter == 1)
                printer = new Epson();
            else if (nomorPrinter == 2)
                printer = new Canon();
            else
                printer = new LaserJet();

            
            printer.Print();
            printer.Show();
            Console.ReadKey();





        }
    }
}