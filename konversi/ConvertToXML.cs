using System;
using System.IO;
using System.Xml.Serialization;
using Program;

public class ConvertToXML :IConvertObject
{
    public void Convert(Mahasiswa mhs)
    {
        using (StringWriter writer = new StringWriter())
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Mahasiswa));
            serializer.Serialize(writer,mhs);

            string xml = writer.ToString();
            
            Console.WriteLine("Hasil konversi ke XML:\n");
            Console.WriteLine(xml);
        }
    }
}