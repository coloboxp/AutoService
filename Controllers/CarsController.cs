using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoService.Data;
using AutoService.Data.Migrations;
using AutoService.Models;
using AutoService.Utility;
using AutoService.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoService.Controllers
{

    /// <summary>
    /// Class CarsController.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    [Authorize]
    public class CarsController : Controller
    {
        private readonly ApplicationDbContext _db;

        /// <summary>
        /// Initializes a new instance of the <see cref="CarsController"/> class.
        /// </summary>
        /// <param name="db">The database.</param>
        public CarsController(ApplicationDbContext db)
        {
            _db = db;
        }

        /// <summary>
        /// Indexes the specified user identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>Task&lt;IActionResult&gt;.</returns>
        public async Task<IActionResult> Index(string userId = null)
        {
            if (userId == null)
            {
                // Only called when a guest user logs in
                userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            }

            var model = new CarAndCustomerViewModel()
            {
                Cars = await _db.Cars.Where(w => w.UserId == userId).ToListAsync(),
                UserObj = await _db.Users.Cast<ApplicationUser>().FirstOrDefaultAsync(f => f.Id == userId)
            };

            return View(model);
        }

        //Create GET
        /// <summary>
        /// Creates the specified user identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>IActionResult.</returns>
        public IActionResult Create(string userId)
        {
            Car car = new Car
            {
                Year = DateTime.Now.Year,
                UserId = userId
            };

            return View(car);
        }

        /// <summary>
        /// Creates the specified car.
        /// </summary>
        /// <param name="car">The car.</param>
        /// <returns>Task&lt;IActionResult&gt;.</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Car car)
        {
            if (ModelState.IsValid)
            {
                _db.Cars.Add(car);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new {userId = car.UserId});
            }

            return View(car);
        }

        //Details GET
        /// <summary>
        /// Detailses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Task&lt;IActionResult&gt;.</returns>
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _db.Cars
                .Include(c => c.ApplicationUser)
                .SingleOrDefaultAsync(m => m.Id == id.Value);

            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        //Edit GET
        /// <summary>
        /// Edits the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Task&lt;IActionResult&gt;.</returns>
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _db.Cars
                .Include(c => c.ApplicationUser)
                .SingleOrDefaultAsync(m => m.Id == id.Value);

            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        //Edit POST
        /// <summary>
        /// Edits the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="car">The car.</param>
        /// <returns>Task&lt;IActionResult&gt;.</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Car car)
        {
            if (id != car.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var c = await _db.Cars.SingleOrDefaultAsync(s => s.Id == id);

                if (c != null)
                {
                    c.Model = car.Model;
                    c.Color = car.Color;
                    c.Make = car.Make;
                    c.Mileage = car.Mileage;
                    c.Style = car.Style;
                    c.Year = car.Year;
                    c.VIN = car.VIN;

                    _db.Cars.Update(c);
                    await _db.SaveChangesAsync();
                    return RedirectToAction("Index", new { userId = car.UserId });
                }
                else
                {
                    NotFound();
                }
            }

            return View(car);
        }

        //Delete GET
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Task&lt;IActionResult&gt;.</returns>
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _db.Cars
                .Include(c => c.ApplicationUser)
                .SingleOrDefaultAsync(m => m.Id == id.Value);

            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        //DELETE POST
        /// <summary>
        /// Performs the deletion once it has been confirmed
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Task&lt;IActionResult&gt;.</returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _db.Cars.SingleOrDefaultAsync(s => s.Id == id);

            if (car == null)
            {
                return NotFound();
            }

            var svcs = _db.Services.Where(w => w.CarId == car.Id);
            _db.Services.RemoveRange(svcs);
            _db.Cars.Remove(car);

            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index), new {userId = car.UserId});
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