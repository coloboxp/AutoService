using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoService.Models
{
    /// <summary>
    /// Class SubCar is a smaller representation of the Car object
    /// used to be displayed on the Services window and allow the Model.IsValid to work
    /// </summary>
    public class SubCar
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the make.
        /// </summary>
        /// <value>The make.</value>
        [Display(Name = "Make", Description = "Car manufacturer", Prompt = "Enter the car manufacturer")]
        public string Make { get; set; }
        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>The model.</value>
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
        [Display(Name = "Year", Description = "Year of manufacture", Prompt = "Enter manufacture year")]
        public int Year { get; set; }
        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>The user identifier.</value>
        public string UserId { get; set; }
        /// <summary>
        /// From a normal <see cref="Car" object, constructs a <see cref="SubCar"/>/>
        /// </summary>
        /// <param name="car">The <see cref="Car"/> object</param>
        /// <returns>A <see cref="SubCar"/> instance</returns>
        public static SubCar FromCar(Car car)
        {
            return new SubCar
            {
                Id = car.Id,
                Make = car.Make,
                Model = car.Model,
                Style = car.Style,
                Year = car.Year,
                UserId = car.UserId
            };
        }
    }
}
