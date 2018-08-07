using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoService.Models
{
    public class Service
    {
        public int Id { get; set; }

        [Display(Name = "Miles", Description = "Current car mileage", Prompt = "Enter the mileage")]
        public double Miles { get; set; }
        [Display(Name = "Price", Description = "Price of the service", Prompt = "Enter the cost of the service")]
        public double Price { get; set; }
        [Display(Name = "Details", Description = "Details of the service", Prompt = "Enter the details of the service done")]
        public string Details { get; set; }
        [Display(Name = "Date", Description = "Date of the Service", Prompt = "Enter the date of the service")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime DateAdded { get; set; }

        public int CarId { get; set; }

        public int ServiceTypeId { get; set; }

        [ForeignKey("CarId")]
        public virtual Car Car { get; set; }

        [ForeignKey("ServiceTypeId")]
        public virtual ServiceType ServiceType { get; set; }
    }
}
