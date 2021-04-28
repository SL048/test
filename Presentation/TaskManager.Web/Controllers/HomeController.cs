﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Web.Models;

namespace TaskManager.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
		private readonly ITicketRepository _ticketRepository;

		public HomeController(ILogger<HomeController> logger,
                              ITicketRepository ticketRepository)
        {
           _logger = logger;
            _ticketRepository = ticketRepository;
        }
        
        public IActionResult Index()
        {
           return View();
        }
        
        public IActionResult Privacy()
        {
           return View();
        }
        
        public IActionResult SignIn()
		{
            return View();
		}

        [Route("/secret")]
        [Authorize]
        public IActionResult Secret()
		{
            var tickets = _ticketRepository.GetAllTickets();
            return View(tickets);
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
           return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
