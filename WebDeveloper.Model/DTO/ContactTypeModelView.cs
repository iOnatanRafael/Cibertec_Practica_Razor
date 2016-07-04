using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeveloper.Model.DTO
{
    public class ContactTypeModelView
    {
        public int ContactTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
