using System;

namespace OOEvents
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            var room = new Room(3);
            room.RoomSoldOutEvent += OnRoomSoldOut;

            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
        }

        static void OnRoomSoldOut(object sender, EventArgs e)
        {
            Console.WriteLine("Sala lotada");
        }
    }

    public class Room
    {
        public Room(int seats)
        {
            Seats = seats;
            seatsInUse = 0;
        }

        private int seatsInUse = 0;

        public int Seats { get; set; }

        public void ReserveSeat()
        {
            seatsInUse++;
            if (seatsInUse >= Seats)
            {
                //Evento fechado
                OnRoomSoldOut(EventArgs.Empty);
            }
            else
            {
                Console.WriteLine("Assento reservado");
            }
        }

        //cria uma definição para o evento
        public event EventHandler RoomSoldOutEvent;

        //Impementação base para a execução do evento
        protected virtual void OnRoomSoldOut(EventArgs e)
        {
            EventHandler handler = RoomSoldOutEvent;
            handler?.Invoke(this, e);
        }
    }
}
