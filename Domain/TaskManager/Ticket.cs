using System;

namespace TaskManager
{
    public class Ticket
    {

      /// <summary>
      /// Id заявки
      /// </summary>
      public Guid Id { get; set; }

      /// <summary>
      /// Имя заявки
      /// </summary>
      public string Name { get; set; }

      /// <summary>
      /// Описание заявки
      /// </summary>
      public string Description { get; set; }

      /// <summary>
      /// Статус заявки
      /// </summary>
      public TickectStatus Status { get; set; }

      /// <summary>
      /// Приоритет заявки
      /// </summary>
      public TicketPriority Priority { get; set; }

      /// <summary>
      /// Id создателя заявки
      /// </summary>
      public Guid InitiatorId { get; set; }

      /// <summary>
      /// Id Исполнителя заявки
      /// </summary>
      public Guid ExcecutorId { get; set; }

      private Ticket(Guid id, string name, string description, TickectStatus status, TicketPriority priority,
                     Guid initiatorId, Guid excecutorId)
      {
         Id = id;
         Name = name;
         Description = description;
         Status = status;
         Priority = priority;
         InitiatorId = initiatorId;
         ExcecutorId = excecutorId;
      }

      public static Ticket New(Guid id, string name, string description, TickectStatus status, TicketPriority priority,
                               Guid initiatorId, Guid excecutorId)
         => new Ticket(id, name, description, status, priority, initiatorId, excecutorId);
   }
}
