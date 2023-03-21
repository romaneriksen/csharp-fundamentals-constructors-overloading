using Boolean.CSharp.Main.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class Extension
    {
        private Core _core;
        public Extension()
        {
            Core core = new Core();
        }

        public Aeroplane Question1()
        {
            Aeroplane plane = new Aeroplane();
            plane.FlightDetails("LHR", "JFK");

            //TODO: 1.  Overload FlightDetails() (add new method) that returns an int of the number of passengers on the flight

            // write code here


            return plane;
        }
        public Aeroplane Question2()
        {
            Aeroplane plane = new Aeroplane();
            plane.FlightDetails("LHR", "JFK");

            //TODO 2.  Overload FlightDetails (add new method) that adds another passenger to the flight.  
            //TIP - you cant write a method that takes a single string as the cancelled flight one already does this, so
            //  increase the number of parameters?

            // write code here

            return plane;

        }
    }
}
