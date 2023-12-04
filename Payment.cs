namespace SunsetHotelReservationSystem
{
    class Payment
    {
        public int PaymentID { get; set; }
        public int ReservationID { get; set; }

        public Payment(int paymentID, int reservationID)
        {
            PaymentID = paymentID;
            ReservationID = reservationID;
        }
    }
}


