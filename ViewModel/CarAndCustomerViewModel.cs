using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoService.Data.Migrations;
using AutoService.Models;

namespace AutoService.ViewModel
{
    /// <summary>
    /// Class CarAndCustomerViewModel is a ViewModel to combine the
    /// <see cref="ApplicationUser"/> User with it's <see cref="Cars"/>
    /// </summary>
    public class CarAndCustomerViewModel
    {
        /// <summary>
        /// Gets or sets the user object.
        /// </summary>
        /// <value>The user object.</value>
        public ApplicationUser UserObj { get; set; }
        /// <summary>
        /// Gets or sets the cars.
        /// </summary>
        /// <value>The cars.</value>
        public IEnumerable<Car> Cars { get; set; }
        
    }
}
