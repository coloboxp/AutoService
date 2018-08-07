using System;
using System.Collections.Generic;
using System.Text;
using AutoService.Data.Migrations;
using AutoService.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AutoService.Data
{
    /// <summary>
    /// Class ApplicationDbContext.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext" />
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the service types.
        /// </summary>
        /// <value>The service types.</value>
        public DbSet<ServiceType> ServiceTypes { get; set; }
        /// <summary>
        /// Gets or sets the application users.
        /// </summary>
        /// <value>The application users.</value>
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        /// <summary>
        /// Gets or sets the cars.
        /// </summary>
        /// <value>The cars.</value>
        public DbSet<Car> Cars { get; set; }
        /// <summary>
        /// Gets or sets the services.
        /// </summary>
        /// <value>The services.</value>
        public DbSet<Service> Services { get; set; }
    }
}
