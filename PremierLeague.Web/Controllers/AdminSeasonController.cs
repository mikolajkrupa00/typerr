using PremierLeague.Services.AdminSeason;
using PremierLeague.ViewModels.Models.Season;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PremierLeague.Web.Controllers
{
    public class AdminSeasonController : Controller
    {
        private readonly IAdminSeasonService _adminSeasonService;
        public AdminSeasonController()
        {
            _adminSeasonService = new AdminSeasonService();
        }
        // GET: AdminSeason
        public ActionResult Index()
        {
            var seasons = _adminSeasonService.GetSeasons();
            return View(seasons);
        }
        public ActionResult AddSeason()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSeason(VMAdminSeasonAddSeason season)
        {
            _adminSeasonService.AddNewSeason(season);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteSeason(int seasonId)
        {
            _adminSeasonService.DeleteSeason(seasonId);
            return RedirectToAction("Index");
        }
    }
}