using Microsoft.Extensions.Hosting;

namespace Server.Models
{
    public class User
    {
        public int UserId { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Address { get; set; }
        public required string City { get; set; }
        public required string State { get; set; }
        public required string Country { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public bool EmailConfirmed { get; set; }
        public bool PasswordConfirmed { get; set; }
        public required string PhoneNumber { get; set; }

        public ICollection<Reservation>? Reservations { get; }

    }
}
