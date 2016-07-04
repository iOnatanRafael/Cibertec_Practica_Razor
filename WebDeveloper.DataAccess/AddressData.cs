using System.Linq;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class AddressData : BaseDataAccess<Address>
    {
        public Address GetAddress(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Address.FirstOrDefault(x => x.AddressID == id);
            }
        }
    }
}