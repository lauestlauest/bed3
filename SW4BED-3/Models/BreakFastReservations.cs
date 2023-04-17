namespace SW4BED_3.Models
{
    public class BreakFastReservations 
    {
        public int ReservationId { get; set; }

        public int AdultsReservations { get; set; }

        public int ChildrenReservations { get; set; }

        
        public int AdultsCheckIn { get; set; }

       
        public int ChildrenCheckIn { get; set; }

        public DateTime Date { get; set; }

    }
}
