using System.ComponentModel.DataAnnotations;

namespace WebDeveloper.Model.DTO
{
    public class AddressTypeModelView
    {
        public int AddressTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
