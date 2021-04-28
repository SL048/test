using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketAPI.Controllers
{
    public class SecretController : Controller
    {
        [Route("/secret")]
        [Authorize]
        public string Index()
		{
            return "olala gellow nigger :3";
		}
    }
}
