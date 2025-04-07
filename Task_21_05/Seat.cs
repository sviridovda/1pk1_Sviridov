using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_05
{
    enum Seats
    {
        First = 1,
        Second,
        Third,
        Fourth,
        Fiveth,
        Sixth,
        Seventh,
        Eighth,
        Ninth,
        Tenth
    }

    enum StatusSeats
    {
        Buyed = 1,
        Reserved,
        Free
    }

    class Seat
    {
        public static Dictionary<Seats, StatusSeats> seats = new Dictionary<Seats, StatusSeats>();  // словарь мест

        /// <summary>
        /// автоматическое заполнение словаря статусом свободно
        /// </summary>
        static Seat()
        {
            for (int i = 1; i <= 10; i++) seats[(Seats)i] = StatusSeats.Free;
        }
    }
}