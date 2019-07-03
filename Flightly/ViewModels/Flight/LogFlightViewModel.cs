using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightTrackly.ViewModels.Flight
{
    public class LogFlightViewModel
    {
        public DateTime DateOfFlight { get; set; }
        public string Route { get; set; }
        public string Comments { get; set; }
        public double Approaches { get; set; }
        public bool Hold { get; set; }
        public double TotalLandings { get; set; }
        public double FullStopDay { get; set; }
        public double FullStopNight { get; set; }
        public double CrossCountry { get; set; }
        public double Night { get; set; }
        public double SimulatedInstrument { get; set; }
        public double IMC { get; set; }
        public double GroundSim { get; set; }
        public double Dual { get; set; }
        public double CFI { get; set; }
        public double SIC { get; set; }
        public double PIC { get; set; }
        public double TotalTime { get; set; }
        public double SoloTime { get; set; }
    }
}
