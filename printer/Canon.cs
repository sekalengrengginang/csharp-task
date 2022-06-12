namespace Printer;

public class Canon : PrinterWindows
{
    public override void Print()
    {
        Console.WriteLine("Canon Display dimension:9.5*12 ");
    }

    public override void Show()
    {
        Console.WriteLine("Canon printer printing.....");
    }
}