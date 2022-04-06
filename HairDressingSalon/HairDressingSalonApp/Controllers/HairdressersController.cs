using HairDressingSalonApp.Abstractions;
using HairDressingSalonApp.Entities;
using HairDressingSalonApp.Models.Client;
using HairDressingSalonApp.Models.Hairdresser;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairDressingSalonApp.Controllers
{
    public class HairdressersController : Controller
    {
        private readonly IHairdresserService _hairdresserService;
        private readonly UserManager<ApplicationUser> _userManager;

        public HairdressersController(IHairdresserService hairdresserService, UserManager<ApplicationUser> userManager)
        {
            _hairdresserService = hairdresserService;
            _userManager = userManager;
        }


        // GET: HairdressersController
      /*  public ActionResult Index()
        {
            var users = _hairdresserService.GetHairdressers()
                 .Select(u => new ListingHairdresserVM
                 {
                     Id = u.Id,
                     FirstName = u.FirstName,
                     LastName = u.LastName,
                     PhoneNumber=u.User.PhoneNumber
                 }).ToList();

            return this.View(users);
        }*/

        // GET: HairdressersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HairdressersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HairdressersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateHairdresserVM hairdresser)
        {
            if (!ModelState.IsValid)
            {
                return View(hairdresser);
            }
            if (await _userManager.FindByNameAsync
                           (hairdresser.Username) == null)
            {
                ApplicationUser user = new ApplicationUser();
                user.UserName = hairdresser.Username;
                user.Email = hairdresser.Email;

                var result = await _userManager.CreateAsync(user, "Hairdresser123!");

                if (result.Succeeded)
                {
                    var created = _hairdresserService.CreateHairdresser(hairdresser.FirstName, hairdresser.LastName, user.Id);
                    if (created)
                    {
                        _userManager.AddToRoleAsync(user, "Hairdresser").Wait();
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            ModelState.AddModelError(string.Empty, "The hairdresser exists.");
            return View();
        }

        // GET: HairdressersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HairdressersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HairdressersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HairdressersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
