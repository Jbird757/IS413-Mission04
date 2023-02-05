using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IS413_Mission04.Models
{
    public class GradeCalculator
    {
        [Required(ErrorMessage = "A grade in this area is required")]
        [Range(0, 100, ErrorMessage = "Value must be between 0-100")]
        public double Assign { get; set; }

        [Required(ErrorMessage = "A grade in this area is required")]
        [Range(0, 100, ErrorMessage = "Value must be between 0-100")]
        public double Group { get; set; }

        [Required(ErrorMessage = "A grade in this area is required")]
        [Range(0, 100, ErrorMessage = "Value must be between 0-100")]
        public double Quiz { get; set; }

        [Required(ErrorMessage = "A grade in this area is required")]
        [Range(0, 100, ErrorMessage = "Value must be between 0-100")]
        public double MT { get; set; }

        [Required(ErrorMessage = "A grade in this area is required")]
        [Range(0, 100, ErrorMessage = "Value must be between 0-100")]
        public double Final { get; set; }

        [Required(ErrorMessage = "A grade in this area is required")]
        [Range(0, 100, ErrorMessage = "Value must be between 0-100")]
        public double INTEX { get; set; }
    }
}
