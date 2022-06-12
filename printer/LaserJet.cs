namespace Printer;

public class LaserJet :PrinterWindows
{
    public override void Print()
    {
        Console.WriteLine("LaserJet Display dimension: 12*12");
    }

    public override void Show()
    {
        Console.WriteLine("LaserJet printer printing.....");
    }
}