using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Web.Controllers
{
   public class TicketController : Controller
   {
      private readonly ITicketRepository _ticketRepository;

      public TicketController(ITicketRepository ticketRepository)
         => _ticketRepository = ticketRepository;

      public IActionResult Index()
      {
         var tickets = _ticketRepository.GetAllTickets();
         return View(tickets);
      }
   }
}
