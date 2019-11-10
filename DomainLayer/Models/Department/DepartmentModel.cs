using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models.Department
{
    public class DepartmentModel : IDepartmentModel
    {
        public int DepartmentId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Department name is required")]
        [StringLength(22, MinimumLength = 2, ErrorMessage = "Department name length should be between 2 and 22")]
        public string DepartmentName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Url is required")]
        public string Url { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Phone Number required")]
        public string PhoneNumber { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "City Location is required")]
        [StringLength(22, MinimumLength = 2, ErrorMessage = "City Location length should be between 2 and 22")]
        public string CityLocation { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "State Location is required")]
        [StringLength(22, MinimumLength = 2, ErrorMessage = "State Location length should be between 2 and 22")]
        public string StateLocation { get; set; }

    }
}
