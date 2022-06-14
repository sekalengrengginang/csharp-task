namespace Program;
using System;
using Newtonsoft.Json;

public class ConvertToJson : IConvertObject
{
    public void Convert(Mahasiswa mhs)
    {
        string json = JsonConvert.SerializeObject(mhs);
            
        Console.WriteLine("Hasil konversi ke json:\n");
        Console.WriteLine(json);
    }
}