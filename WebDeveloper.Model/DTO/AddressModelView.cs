using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeveloper.Model.DTO
{
    public class AddressModelView
    {
        public int AddressID { get; set; }

        [Required]
        [StringLength(60)]
        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }

        [StringLength(60)]
        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }

        [Required]
        [StringLength(30)]
        public string City { get; set; }

        public int StateProvinceID { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

    }
}
