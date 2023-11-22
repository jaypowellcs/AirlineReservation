namespace Server.Models
{
    public class Seat
    {
        public int SeatId { get; set; }
        public int FlightId { get; set;}
        public Flight? Flight { get; set; }
    }
}
