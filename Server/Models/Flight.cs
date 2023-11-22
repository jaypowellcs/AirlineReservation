using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Models
{
    public class Flight
    {
        public int FlightId { get; set; }

        public int? AirportIdDeparture { get; set; }
        public Airport? AirportDeparture { get; set; }

        public int? AirportIdArrival { get; set; }
        public Airport? AirportArrival { get; set; }

        public string? AirplaneType { get; set; }
        public DateTimeOffset DepatureDateTime { get; set; }
        public DateTimeOffset ArrivalDateTime { get; set; }
        public int DurationInMins { get; set; }
    }
}
