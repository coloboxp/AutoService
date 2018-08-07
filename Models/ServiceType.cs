using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoService.Models
{
    public class ServiceType
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The deescription is required")]
        [Display(Name = "Name", Description = "Service description", Prompt = "Enter a description of the service")]
        public string Name { get; set; }
    }
}
