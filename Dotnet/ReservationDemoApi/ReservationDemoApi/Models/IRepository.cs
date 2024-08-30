namespace ReservationDemoApi.Models
{
    public interface IRepository
    {

        IEnumerable<Reservation> Reservations { get; }
        Reservation this[int id] {get;}
        Reservation AddReservation(Reservation reservation);
        Reservation UpdateReservation(Reservation reservation);
        bool DeleteReservation(int id);
    }
}
