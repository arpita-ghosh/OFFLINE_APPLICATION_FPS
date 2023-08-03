using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfflineApplicationFPS.Controllers
{
    public class FirstDataGetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("NotificationDetails")]
        public void fnTest(OfflineApplicationFPS.Dto.NotificationDetails notificationDetails)
        {
            SqlConnection connection = new SqlConnection(Configuration.GetConnectionString("FoodDbPrivate"));

        }
    }
}
