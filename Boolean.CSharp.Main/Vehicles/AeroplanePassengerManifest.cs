using NUnit.Framework.Internal;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static NUnit.Framework.Constraints.Tolerance;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Newtonsoft.Json.Linq;
using NUnit.Framework.Internal.Execution;
using static System.Net.Mime.MediaTypeNames;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Threading;

namespace Boolean.CSharp.Main.Vehicles
{
    public class AeroplanePassengerManifest
    {
        List<string> _passengers;
        AeroplanePassengerManifest()
        {
            _passengers = new List<string> {
                    "Adele",
                    "Damon Albarn",
                    "Seal",
                    "Julie Andrews",
                    "Ari Up",
                    "Joan Armatrading",
                    "Frederic Austin",
                    "Syd Barrett",
                    "Shirley Bassey",
                    "Victoria Beckham",
                    "Richard Rodney Bennett",
                    "David Bowie",
                    "Susan Boyle",
                    "Billy Bragg",
                    "Kate Bush",
                    "Eric Clapton",
                    "Joe Cocker",
                    "Elvis Costello",
                    "Jamie Cullum",
                    "Maurice Gibb",
                    "Mick Jagger",
                    "Elton John",
                    "Cliff Richard",
                    "Sade",
                    "Stormzy",
                    "Sam Smith",
                    "Dusty Springfield",
                    "Rod Stewart",
                    "Sting",
                    "Michael Waterson",
                    "Elisabeth Welch",
                    "Florence Welch",
                    "Amy Winehouse",
                    "Steve Winwood",
                    "Rick Wright"
                };

        }

        public List<string> Passengers { get; set; }

        public int NumberOfPassengers { get { return _passengers.Count; } }
    }
}

