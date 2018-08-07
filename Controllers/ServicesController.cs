using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoService.Data;
using AutoService.Models;
using AutoService.Utility;
using AutoService.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace AutoService.Controllers
{
    /// <summary>
    /// Class ServicesController.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    public class ServicesController : Controller
    {
        private readonly ApplicationDbContext _db;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServicesController" /> class.
        /// </summary>
        /// <param name="db">The database.</param>
        public ServicesController(ApplicationDbContext db)
        {
            _db = db;
        }

        /// <summary>
        /// Indexes the specified car identifier.
        /// </summary>
        /// <param name="carId">The car identifier.</param>
        /// <returns>IActionResult.</returns>
        [Authorize]
        public IActionResult Index(int carId)
        {
            var model = new CarAndServicesViewModel
            {
                SubCar = _db.Cars.FirstOrDefault(f => f.Id == carId).SubCar,
                ServiceTypes = _db.ServiceTypes.ToList(),
                PastServices = _db.Services.Where(w => w.CarId == carId).OrderByDescending(o => o.DateAdded)
            };

            return View(model);
        }

        //GET: Services/Create
        /// <summary>
        /// Creates the specified car identifier.
        /// </summary>
        /// <param name="carId">The car identifier.</param>
        /// <returns>IActionResult.</returns>
        [Authorize(Roles = StaticDetails.AdminEndUser)]
        public IActionResult Create(int carId)
        {
            var model = new CarAndServicesViewModel
            {
                SubCar = _db.Cars.FirstOrDefault(f => f.Id == carId).SubCar,
                ServiceTypes = _db.ServiceTypes.ToList(),
                PastServices = _db.Services.Where(w => w.CarId == carId).OrderByDescending(o => o.DateAdded).Take(5)
            };

            return View(model);
        }

        //POST: Services/Create
        /// <summary>
        /// Creates the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>Task&lt;IActionResult&gt;.</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CarAndServicesViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.NewService.CarId = model.SubCar.Id;
                model.NewService.DateAdded = DateTime.Now;
                _db.Add(model.NewService);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Create), new {carId = model.SubCar.Id});
            }

            var newModel = new CarAndServicesViewModel
            {
                SubCar = _db.Cars.FirstOrDefault(f => f.Id == model.SubCar.Id).SubCar,
                ServiceTypes = _db.ServiceTypes.ToList(),
                PastServices = _db.Services.Where(w => w.CarId == model.SubCar.Id).OrderByDescending(o => o.DateAdded).Take(5)
            };

            return View(newModel);
        }

        //DELETE: Get
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Task&lt;IActionResult&gt;.</returns>
        [Authorize(Roles = StaticDetails.AdminEndUser)]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var svc = 
                await _db
                    .Services
                    .Include(s => s.Car)
                    .Include(s => s.ServiceType)
                    .SingleOrDefaultAsync(m => m.Id == id);

            if (svc == null)
            {
                return NotFound();
            }

            return View(svc);
        }

        /// <summary>
        /// Deletes the confirmed.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>Task&lt;IActionResult&gt;.</returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = StaticDetails.AdminEndUser)]
        public async Task<IActionResult> DeleteConfirmed(Service model)
        {
            var serviceId = model.Id;
            var carId = model.CarId;

            var svc = await _db.Services.SingleOrDefaultAsync(m => m.Id == serviceId);

            if (svc == null)
            {
                return NotFound();
            }

            _db.Services.Remove(svc);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Create), new {carId = carId});
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