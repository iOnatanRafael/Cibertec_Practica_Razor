using System.Linq;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class AddressTypeData : BaseDataAccess<AddressType>
    {
        public AddressType GetAddressType(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.AddressType.FirstOrDefault(x => x.AddressTypeID == id);
            }
        }       
    }
}
