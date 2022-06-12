namespace Printer;

public class Epson :PrinterWindows
{
    public override void Print()
    {
        Console.WriteLine("Epson Display dimension:10*11 ");
    }

    public override void Show()
    {
        Console.WriteLine("Epson printer printing.....");
    }
}