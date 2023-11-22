namespace Server.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public DateTimeOffset DateOfReservation { get; set;}
        public int UserId { get; set; }
        public required User User { get; set; }
        public int SeatId { get; set; }
        public  Seat? Seat { get; set; }
    }
}
