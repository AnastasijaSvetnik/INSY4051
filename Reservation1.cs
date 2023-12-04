using System;

namespace SunsetHotelReservationSystem
{
    class Reservation
    {
        public int ReservationID { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }
        public string Phone { get; }
        public string Email { get; }

        public Reservation(int reservationID, string firstName, string lastName, int age, string phone, string email)
        {
            ReservationID = reservationID;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Phone = phone;
            Email = email;
        }

        public override string ToString()
        {
            return $"Reservation ID: {ReservationID}, Guest: {FirstName} {LastName}, Age: {Age}, Phone: {Phone}, Email: {Email}";
        }
    }
}


