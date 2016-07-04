using System.Linq;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class PersonData : BaseDataAccess<Person>
    {
        public Person GetPerson(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Person.FirstOrDefault(x => x.BusinessEntityID == id);
            }
        }
    }
}