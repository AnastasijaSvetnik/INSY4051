using System;
using Internal;

namespace SunsetHotelReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Sunset Hotel Reservation System!");

            // For simplicity, let's create an instance of a Reservation System
            ReservationSystem reservationSystem = new ReservationSystem();

            //Get user input for reservation
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your phone number:");
            string phone = Console.ReadLine();

            Console.WriteLine("Enter your email:");
            string email = Console.ReadLine();

            Reservation reservation = reservationSystem.MakeReservation(firstName, lastName, age, phone, email);

            // Display reservation details
            Console.WriteLine($"Reservation successful! Your Reservation ID is: {reservation.ReservationID}");
        }
    }
}


