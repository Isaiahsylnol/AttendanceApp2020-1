using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceApplication.Models
{
    public class AttendanceRegisters
    {
        [Display(Name = "Register ID")]
        [Required(ErrorMessage = "ID is required.")]
        public int registerId { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "The registry name is required.")]
        public string name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage ="The description is required.")]
        public string description { get; set; }

        [Display(Name = "Scheme ID")]
        [Required(ErrorMessage = "The attendance scheme ID is required.")]
        public int attSchemeId { get; set; }
    }
}
