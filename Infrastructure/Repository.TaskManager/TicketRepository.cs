using System;
using TaskManager;

namespace Repository.TaskManager
{
   public class TicketRepository : ITicketRepository
   {
      //Заглушка.
      private readonly Ticket[] tickets = new Ticket[]
      {
            Ticket.New(Guid.Parse("2384105A-564F-4A75-8B38-E58F8833C251"),
                       "INC00001",
                       "Самая первая заявка",
                       TickectStatus.New,
                       TicketPriority.Medium,
                       Guid.Parse("18FEC7EE-37B4-4F69-8C13-D2C82EB1D893"),
                       Guid.Parse("CCFAB1B3-638D-4F7E-B582-E5F4BDE33F4C"))
      };

      public Ticket[] GetAllTickets()
         => tickets;
      
   }
}
