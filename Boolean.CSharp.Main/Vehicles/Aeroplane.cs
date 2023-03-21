using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.Vehicles
{
    public class Aeroplane
    {
        private string _departureAirport;
        private string _arrivalAirport;
        private string _journeyDetails;
        private bool _willMyFlightGoAhead;
        
        public Aeroplane()
        {
            
        }
        public bool FlightDetails(string departureAirport, string arrivalAirport) 
        {
            _departureAirport = departureAirport;
            _arrivalAirport = arrivalAirport;
            _journeyDetails = $"##{_departureAirport}##{_arrivalAirport}##";
            _willMyFlightGoAhead = false;
            return _willMyFlightGoAhead;        
        }  
       
        public void FlightDetails(string cancelledMessage)
        {
            _journeyDetails = cancelledMessage;
            _willMyFlightGoAhead = true;            
        }
            
        public string FlightDetails()
        {
            return _journeyDetails;
        }

        
        public int FlightDetails(AeroplanePassengerManifest passengerlist)
        {
            return NotImplementedException();
        }
        
        
        
        public bool WillMyFlightGoAhead => _willMyFlightGoAhead;
    
    
    
    }
}
