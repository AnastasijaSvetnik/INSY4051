using System;

namespace SunsetHotelReservationSystem
{
    class ReservationSystem
    {
        // Placeholder for storing reservations (in-memory storage)
        private static int nextReservationID = 1;

        public Reservation MakeReservation(string firstName, string lastName, int age, string phone, string email)
        {
            // Assume you have a method to generate a unique Reservation ID
            int reservationID = GenerateReservationID();

            // Assume you have a method to create a new reservation
            Reservation reservation = new Reservation(reservationID, firstName, lastName, age, phone, email);

            // For simplicity, print reservation details
            Console.WriteLine($"Reservation details: {reservation}");

            return reservation;
        }

        private int GenerateReservationID()
        {
            return nextReservationID++;
        }
    }
}


