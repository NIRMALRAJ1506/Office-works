


using Microsoft.EntityFrameworkCore;

namespace ReservationDemoApi.Models
{
    public class ReservationContext : DbContext
    {
        public ReservationContext(DbContextOptions<ReservationContext> options) : base(options)
        {

        }


        public DbSet<Reservation> Reservation { get; set; }

    }
}

