using PremierLeague.Services.AdminTeam;
using PremierLeague.ViewModels.Models.Team;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PremierLeague.Web.Controllers
{
    public class AdminTeamController : Controller
    {
        private readonly IAdminTeamService _adminTeamService;
        public AdminTeamController()
        {
            _adminTeamService = new AdminTeamService();
        }

        public ActionResult Index()
        {
            var teams = _adminTeamService.GetTeams();
            return View(teams);
        }
        [HttpPost]
        public ActionResult AddTeam(VMAdminTeamAddTeam vmAddTeam)
        {
            _adminTeamService.AddTeam(vmAddTeam);
            return RedirectToAction("Index");
        }

        public ActionResult AddTeam()
        {
            return View("AddTeam");
        }

        public ActionResult DeleteTeam(int teamId)
        {
            _adminTeamService.DeleteTeam(teamId);
            return RedirectToAction("Index");
        }

    }
}