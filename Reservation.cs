using System;

namespace SunsetHotelReservationSystem
{
    class Reservation
    {
        public int ReservationID { get; set; }
        public int GuestID { get; set; }
        public int RoomID { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
 
        public Reservation(int reservationID, int guestID, int roomID, DateTime checkInDate, DateTime checkOutDate)
        {
            ReservationID = reservationID;
            GuestID = guestID;
            RoomID = roomID;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
        }
    }
}


