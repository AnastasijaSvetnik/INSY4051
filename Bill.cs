namespace SunsetHotelReservationSystem
{
    class Bill
    {
        public int BillID { get; set; }
        public int ReservationID { get; set; }

        public Bill(int billID, int reservationID)
        {
            BillID = billID;
            ReservationID = reservationID;
        }
    }
}


