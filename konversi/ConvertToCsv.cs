using Program;

namespace KonversiMahasiswa;

public class ConvertToCsv :IConvertObject
{
    public void Convert(Mahasiswa mhs)
    {
        string csv = string.Format("{0},{1},{2}", mhs.npm, mhs.nama, mhs.email);
        
        Console.WriteLine("Hasil konversi ke csv\n");
        Console.WriteLine(csv);
    }
}