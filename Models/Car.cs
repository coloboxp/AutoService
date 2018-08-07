using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using AutoService.Data.Migrations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AutoService.Models
{
    /// <summary>
    /// Class Car.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [Required]
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the vin.
        /// </summary>
        /// <value>The vin.</value>
        [Required]
        [Display(Name = "VIN", Description = "Vehicle Identifcation Number", Prompt = "Enter the VIN")]
        public string VIN { get; set; }
        /// <summary>
        /// Gets or sets the make.
        /// </summary>
        /// <value>The make.</value>
        [Required]
        [Display(Name = "Make", Description = "Car manufacturer", Prompt = "Enter the car manufacturer")]
        public string Make { get; set; }
        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>The model.</value>
        [Required]
        [Display(Name = "Model", Description = "Car model", Prompt = "Enter the car model")]
        public string Model { get; set; }
        /// <summary>
        /// Gets or sets the style.
        /// </summary>
        /// <value>The style.</value>
        [Display(Name = "Style", Description = "Car Style", Prompt = "Coupe / SUV / Etc")]
        public string Style { get; set; }
        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        /// <value>The year.</value>
        [Required]
        [Display(Name = "Year", Description = "Year of manufacture", Prompt = "Enter manufacture year")]
        public int Year { get; set; }
        /// <summary>
        /// Gets or sets the mileage.
        /// </summary>
        /// <value>The mileage.</value>
        [Required]
        [Display(Name = "Mileage", Description = "Current Mileage", Prompt = "Enter the mileage")]
        public double Mileage{ get; set; }
        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        /// <value>The color.</value>
        [Display(Name = "Color", Description = "Car color", Prompt = "Enter car color")]
        public string Color { get; set; }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>The user identifier.</value>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the application user.
        /// </summary>
        /// <value>The application user.</value>
        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        /// <summary>
        /// Gets the sub car.
        /// </summary>
        /// <value>The sub car.</value>
        public SubCar SubCar => SubCar.FromCar(this);
    }
}
