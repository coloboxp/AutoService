using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoService.Data;
using AutoService.Data.Migrations;
using AutoService.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoService.Controllers
{
    /// <summary>
    /// Class UsersController.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    [Authorize(Roles = StaticDetails.AdminEndUser)]
    public class UsersController : Controller
    {
        /// <summary>
        /// The database context
        /// </summary>
        private ApplicationDbContext _db;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersController"/> class.
        /// </summary>
        /// <param name="db">The database.</param>
        public UsersController(ApplicationDbContext db)
        {
            _db = db;
        }
        /// <summary>
        /// Indexes the specified option.
        /// </summary>
        /// <param name="option">The option.</param>
        /// <param name="search">The search.</param>
        /// <returns>IActionResult.</returns>
        public IActionResult Index(string option = null, string search = null)
        {
            var users = _db.Users.Cast<ApplicationUser>().ToList();

            if(!string.IsNullOrEmpty(search))
            {
                switch (option.ToLower())
                {
                    case "email":
                        users = users.Where(w => w.Email.Contains(search, StringComparison.InvariantCultureIgnoreCase)).ToList();
                        break;
                    case "name":
                        users = users.Where(w => w.FirstName.Contains(search, StringComparison.InvariantCultureIgnoreCase)).ToList();
                        break;
                    case "phone":
                        users = users.Where(w => w.PhoneNumber.Contains(search, StringComparison.InvariantCultureIgnoreCase)).ToList();
                        break;
                }
            }

            return View(users);
        }

        /// <summary>
        /// Detailses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Task&lt;IActionResult&gt;.</returns>
        public async Task<IActionResult> Details(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            var user = await _db.Users.Where(w => w.Id == id).Cast<ApplicationUser>().SingleOrDefaultAsync();

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        //GET: Edit
        /// <summary>
        /// Edits the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Task&lt;IActionResult&gt;.</returns>
        public async Task<IActionResult> Edit(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            var user = await _db.Users.Where(w => w.Id == id).Cast<ApplicationUser>().SingleOrDefaultAsync();

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        //POST Edit
        /// <summary>
        /// Edits the specified user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>Task&lt;IActionResult&gt;.</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ApplicationUser user)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", user);
            }
            else
            {
                var usr = await _db.Users.Cast<ApplicationUser>().SingleOrDefaultAsync(u => u.Id == user.Id);

                if (usr != null)
                {
                    usr.FirstName = user.FirstName;
                    usr.LastName = user.LastName;
                    usr.Address = user.Address;
                    usr.City = user.City;
                    usr.PostalCode = user.PostalCode;
                    usr.PhoneNumber = user.PhoneNumber;

                    _db.Users.Update(usr);
                    await _db.SaveChangesAsync();
                    return RedirectToAction("Index", "Users");
                }
                else
                {
                    return NotFound();
                }
            }
        }

        /// <summary>
        /// Deletes the confirmed.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Task&lt;IActionResult&gt;.</returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = await _db.Users.SingleOrDefaultAsync(s => s.Id == id);

            if (user != null)
            {
                var cars = _db.Cars.Where(w => w.UserId == user.Id).ToList();

                foreach (var car in cars)
                {
                    var svcs = _db.Services.Where(w => w.CarId == car.Id).ToList();
                    _db.Services.RemoveRange(svcs);
                }

                _db.Cars.RemoveRange(cars);
                _db.Users.Remove(user);
                
                await _db.SaveChangesAsync();

                //return RedirectToAction("Index", "Users");
                return RedirectToAction(nameof(Index));
            }

            return NotFound();
        }

        //GET: Delete
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Task&lt;IActionResult&gt;.</returns>
        public async Task<IActionResult> Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            var user = await _db.Users.Where(w => w.Id == id).Cast<ApplicationUser>().SingleOrDefaultAsync();

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        /// <summary>
        /// Releases all resources currently used by this <see cref="T:Microsoft.AspNetCore.Mvc.Controller" /> instance.
        /// </summary>
        /// <param name="disposing"><c>true</c> if this method is being invoked by the <see cref="M:Microsoft.AspNetCore.Mvc.Controller.Dispose" /> method,
        /// otherwise <c>false</c>.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }

            
        }
    }
}