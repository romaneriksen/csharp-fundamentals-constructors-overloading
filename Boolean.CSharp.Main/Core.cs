using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boolean.CSharp.Main.Vehicles;

namespace Boolean.CSharp.Main
{
    public class Core
    {
        public Car Question1()
        {

            // Examine the code in Car class above.  There are 2 methods that
            // have the same name as the class which in this case is Car
            /*
                public Car()
                {
                    _model = string.Empty;
                    _make = string.Empty;       
                }
                public Car(string Make)
                {
                    _make = Make;
                    _model = string.Empty;
                }
            */
            // When the car in instantiated below, the constructor is passed a string
            Car car = new Car("Volkswagen");
            // in this case Volkswagen which is a Make of car is passed in.
            // in the constructor the Make variable is assiged to the _make member
            // to pass in another variable into the constructor
            // you should place a comma after the first, then the next variable
            // e.g. new Car("Volkswagen", "Beetle");

            //TODO: 1.  Change line 30, pass in the model as well as the make into the constructor. 

           


            return car;

        }

        public bool Question2()
        {
            // Examine the Motorbike class
            // Note there are two contructors.  T
            /*             
                public Motorbike()
                {
                    _cc = 373;
                    _make = string.Empty;
                    _model = string.Empty;
                }
                public Motorbike(string Make, string Model)
                {            
                    _make = Make;
                    _model = Model;         
            
                }
            
            See how the top constructor sets the _cc = 373, yet when we run the code
            on line 68 we are using a different constructor.
            this means our Motorcycles cc does not get set.
            2 Constructors is an example of Overloading.  It means have two constructors 
            that take different parameters.

             */
            //TODO 2. Ensure both constructors set the cc of the Motorcycle to 373.
            Motorbike myMotorbike = new Motorbike("KTM", "Duke");

            if(myMotorbike.CC > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Bicycle Question3()
        {
            //Examine the Bicycle class
            //See there is somewhere to store the number of wheels the bike has 
            //but no constructor to set this
            //TODO: 3. Add a constructor to the Bicycle class that populates the _wheelCount vairable
            Bicycle bike = new Bicycle();

            return bike;

        }
        public Unicycle Question4()
        {
            //Examine the Unicycle class
            //A unicycle is a bike with one wheel
            //Note the wheelcount has been assigned on the class's property in this case.            
            //Also note we are instantiating the class on line 99 below even though there is no constructor on the class?!
            //TODO: 3. Add a constructor to the Unicycle class to accept/store the rider name and instantiate with your name as the riders name below
            Unicycle unicycle = new Unicycle();
                      
            

            return unicycle;

        }

        public Aeroplane Question5()
        {
            
            /*
             
            Method overloading is possible too.
            Examine the Aeroplane class.  
            Consider the following..
            How many FlightDetails methods are there?
            What are the return types of each of the FlightDetails methods?
            What are the parameters?
            Overloading is simply multiple methods that have the same name but 
            do different things

             */
            Aeroplane plane = new Aeroplane();            
            plane.FlightDetails("LHR", "JFK");
            
            //TODO:  5.  Call the FlightDetails method and cancel the flight
           
            //write code here

            return plane;
        }

    }
}
