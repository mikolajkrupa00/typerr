using PremierLeague.Services.AdminGameWeek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PremierLeague.Web.Controllers
{
    public class AdminGameWeekController : Controller
    {
        private readonly IAdminGameWeekService _gameWeekService;
        public AdminGameWeekController()
        {
            _gameWeekService = new AdminGameWeekService();
        }
        // GET: AdminGameWeek
        public ActionResult Index()
        {
            var gameWeeks = _gameWeekService.GetGameWeeks();
            return View(gameWeeks);
        }

        public ActionResult AddGameWeek()
        {
            return View();
        }
    }
}