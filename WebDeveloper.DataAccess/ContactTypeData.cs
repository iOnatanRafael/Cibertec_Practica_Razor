using System.Linq;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class ContactTypeData : BaseDataAccess<ContactType>
    {
        public ContactType GetContactType(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.ContactType.FirstOrDefault(x => x.ContactTypeID == id);
            }
        }
    }
}
