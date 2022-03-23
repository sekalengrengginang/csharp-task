namespace taxiProgram{
class Program 
{
    static void Main(string[]args){
        //taxi object
        Taxi taxi = new Taxi();

        //properties value
        taxi.DriverName = "Mr White";
        taxi.OnDuty = true;
        taxi.NumPassenger = 10;

        //method call
        taxi.Taxinfo();
        taxi.pickuPassenger();
        taxi.droPassenger();

        Console.ReadKey();
   }


























}
}
