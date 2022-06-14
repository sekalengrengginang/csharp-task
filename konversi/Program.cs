using System;
using KonversiMahasiswa;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs = new Mahasiswa();
            mhs.npm = "21.11.4000";
            mhs.nama = "Ayaka Tachikawa";
            mhs.email = "ayaka@email.com";

            Console.WriteLine("Pilih Format Konversi Data:");
            Console.WriteLine("1.Json");
            Console.WriteLine("2.XML");
            Console.WriteLine("3.Csv\n");

            Console.WriteLine("Nomor format data:");
            int nomorFormatData = Convert.ToInt32(Console.ReadLine());

            IConvertObject convert;

            if (nomorFormatData == 1)
                convert = new ConvertToJson();
            else if (nomorFormatData == 2)
                convert = new ConvertToXML();
            else
                convert = new ConvertToCsv();

            convert.Convert(mhs);
            Console.ReadKey();





        }
    }
}
