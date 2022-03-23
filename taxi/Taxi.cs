using System;

namespace taxiProgram{
    //Properties
    public class Taxi{
        public string DriverName {get; set;}
        public bool OnDuty {get; set;}
        public int NumPassenger {get; set;}
            //Method

        public void Taxinfo(){
            Console.WriteLine("Driver Name ={0} ",DriverName);
            Console.WriteLine("On Duty = {0}",OnDuty);
            Console.WriteLine(" Number Of Passenger = {0}",NumPassenger);

            }

        public void pickuPassenger(){
                Console.WriteLine("{0} sedang menjemput penumpang",DriverName);
             }
        public void droPassenger(){
                Console.WriteLine("{0} sedang mengantar penumpang",DriverName);
            }




}

}













