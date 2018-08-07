using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoService.Models;

namespace AutoService.ViewModel
{
    /// <summary>
    /// Class CarAndServicesViewModel is a ViewModel to combine on one View
    /// the objects <see cref="SubCar"/>, <see cref="NewService"/>, <see cref="PastServices"/>
    /// and <see cref="ServiceTypes"/>
    /// </summary>
    public class CarAndServicesViewModel
    {
        /// <summary>
        /// Gets or sets the sub car.
        /// </summary>
        /// <value>The sub car.</value>
        public SubCar SubCar { get; set; }
        /// <summary>
        /// Gets or sets the new service.
        /// </summary>
        /// <value>The new service.</value>
        public Service NewService { get; set; }
        /// <summary>
        /// Gets or sets the past services.
        /// </summary>
        /// <value>The past services.</value>
        public IEnumerable<Service> PastServices { get; set; }
        /// <summary>
        /// Gets or sets the service types.
        /// </summary>
        /// <value>The service types.</value>
        public List<ServiceType> ServiceTypes { get; set; }
    }
}
