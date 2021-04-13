using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
   public interface ITicketRepository
   {
      /// <summary>
      /// Возвращает все имеющиеся тикеты
      /// </summary>
      /// <returns></returns>
      Ticket[] GetAllTickets();
   }
}
