using System;
using System.Linq;

namespace PVIP_lec
{
    class Program
    {
        static void Main(string[] args)
        {
            Lamport lamport = new Lamport();

            Event e1 = new Event(1, "Первое событие", null);
            Event e2 = new Event(2, "Второе событие", 6);
            Event e3 = new Event(3, "Третье событие", null);
            Event e4 = new Event(4, "Четвертое событие", 9);
            Event e5 = new Event(5, "Пятое событие", null);

            lamport.receive(e1);
            lamport.receive(e3);
            lamport.receive(e2);
            lamport.receive(e5);
            lamport.receive(e4);

            Console.WriteLine("Все события:  \n" + String.Join("", lamport.Events));

            Console.WriteLine(String.Format("События отсортированные по времени: \n{0}",
                String.Join("", lamport.Events.OrderBy(x => x.Clock.Value).ToList())));
        }
    }
}
