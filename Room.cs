
namespace SunsetHotelReservationSystem
{
    class Room
    {
        public int RoomID { get; set; }
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public string View { get; set; }
        public decimal PricePerNight { get; set; }
        public string BedType { get; set; }
       
        public Room(int roomID, int roomNumber, string roomType, string view, decimal pricePerNight, string bedType)
        {
            RoomID = roomID;
            RoomNumber = roomNumber;
            RoomType = roomType;
            View = view;
            PricePerNight = pricePerNight;
            BedType = bedType;
        }
    }
}
