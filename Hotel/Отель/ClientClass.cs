using System;

namespace Отель
{
    //[System.Serializable]
    public class ClientClass
    {
        public int Reserv { get; set; }
        public int Room { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string Telefon { get; set; }
        public bool VIP { get; set; }
        public bool NonGrata { get; set; }

        public ClientClass()
        {
            DateTime dt = DateTime.Now;
            this.CheckInDate = new DateTime(dt.Year, dt.Month, dt.Day); // Убрать время.
            this.CheckOutDate = this.CheckInDate;
        }

        public ClientClass(int Reserv, int Room, string Surname, 
            string Name, DateTime CheckInDate, DateTime CheckOutDate, string Telefon, bool VIP, bool NonGrata )
        {
            this.Reserv = Reserv;
            this.Room = Room;
            this.Surname = Surname;
            this.Name = Name;
            this.CheckInDate = CheckInDate;
            this.CheckOutDate = CheckOutDate;
            this.Telefon = Telefon;
            this.VIP = VIP;
            this.NonGrata = NonGrata;
        }

    }
}
