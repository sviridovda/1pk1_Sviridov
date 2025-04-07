using System.Reflection.Metadata.Ecma335;

namespace Task_21_05
{
    internal class Program
    {
        /*
         * на основе словаря реализуйте систему бронирования билетов на поезд. 
         * предусмотрите резервирование не занятого места, 
         * невозможность купить место, уже занятое другим пассажиром, 
         * возможность вернуть билет (освободить место)
         */
        static void Main(string[] args)
        {
            Dictionary<Seats, StatusSeats> seats = Seat.seats;
            while (true)
            {
                // вывод свободных мест
                Console.Clear();
                Console.WriteLine("Добрый день! \nСвободные места на ближайший состав:");
                foreach (var (k, v) in Seat.seats)
                    if (v != StatusSeats.Buyed) Console.WriteLine($"Место №{(int)k};");

                // выбор места
                Console.Write("Введите номер желаемого места >> ");

                int numSeat;
                if (int.TryParse(Console.ReadLine(), out numSeat) && numSeat >= 1 && numSeat <= 10)
                {
                    Console.Clear();

                    // обработка уже зарезервированного места
                    if (seats[(Seats)numSeat] == StatusSeats.Reserved)
                    {
                        Console.WriteLine($"Место №{numSeat} уже зарезервированно :(");
                        bool flagContinue1 = true;
                        while (flagContinue1)
                        {
                            Console.Clear();
                            Console.WriteLine(
                                "Выберите 1, чтобы купить место. " +
                                "\nВыберите 2, чтобы отменить резервацию " +
                                "\nВыберите 3, чтобы вернуться.");

                            int changedStatusSeat;
                            int.TryParse(Console.ReadLine(), out changedStatusSeat);
                            switch (changedStatusSeat)
                            {
                                case 1:     // покупка места
                                    Console.Clear();

                                    seats[(Seats)numSeat] = StatusSeats.Buyed;
                                    flagContinue1 = false;
                                    Console.WriteLine($"Поздравляем с приобретением места №{numSeat}!");
                                    Console.Read();
                                    break;
                                case 2:     // отмена резервации
                                    Console.Clear();

                                    seats[(Seats)numSeat] = StatusSeats.Free;
                                    flagContinue1 = false;
                                    Console.WriteLine($"Вы успешно отменили резервацию места №{numSeat}!");
                                    Console.Read();
                                    break;
                                case 3:
                                    flagContinue1 = false;
                                    break;
                            }
                        }
                    }
                    // обработка свободного места
                    else if (seats[(Seats)numSeat] != StatusSeats.Buyed)
                    {
                        bool flagContinue2 = true;
                        while (flagContinue2)
                        {
                            Console.Clear();
                            Console.WriteLine($"Место №{numSeat} " +
                                $"\nВыберите 1, если хотите купить место. " +
                                $"\nВыберите 2, если хотите зарезервировать место. " +
                                $"\nВыберите 3, чтобы вернуться.");

                            int newStatusSeat;
                            int.TryParse(Console.ReadLine(), out newStatusSeat);
                            switch (newStatusSeat)
                            {
                                case 1:     // покупка места
                                    Console.Clear();

                                    seats[(Seats)numSeat] = StatusSeats.Buyed;
                                    flagContinue2 = false;
                                    Console.WriteLine($"Поздравляем с приобретением места №{numSeat}!");
                                    Console.Read();
                                    break;
                                case 2:     // резервация места
                                    Console.Clear();

                                    seats[(Seats)numSeat] = StatusSeats.Reserved;
                                    flagContinue2 = false;
                                    Console.WriteLine($"Вы успешно зарезервировали место №{numSeat}!");
                                    Console.Read();
                                    break;
                                case 3:
                                    flagContinue2 = false;
                                    break;
                            }
                        }
                    }
                    // обработка уже купленного места
                    else
                    {
                        bool flagContinue3 = true;
                        while (flagContinue3)
                        {
                            Console.Clear();
                            Console.WriteLine($"Вы уже купили место №{numSeat}.");
                            Console.Write("Выберите 1 если хотите его вернуть. \nВыберите 2 чтобы вернуться. ");

                            int returnSeat;
                            if (int.TryParse(Console.ReadLine(), out returnSeat))
                                switch (returnSeat)
                                {
                                    case 1:     // вернуть место
                                        Console.Clear();
                                        flagContinue3 = false;

                                        seats[(Seats)numSeat] = StatusSeats.Free;
                                        Console.WriteLine($"Вы успешно вернули место №{numSeat}.");
                                        Console.Read();
                                        break;
                                    case 2:     // вернуться
                                        flagContinue3 = false;
                                        break;
                                }
                        }
                    }
                }
            }
        }
    }
}