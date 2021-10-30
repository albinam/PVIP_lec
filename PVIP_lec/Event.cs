using System;
using System.Collections.Generic;
using System.Text;

namespace PVIP_lec
{
    class Event
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public int? Clock { get; set; }

        public Event(int id, string message, int? clock)
        {
            Id = id;
            Message = message;
            Clock = clock;
        }

        public override string ToString()
        {
            return String.Format("Номер события: {0}, Сообщение: {1}, Время: {2}\n", Id, Message, Clock);
        }
    }
}
