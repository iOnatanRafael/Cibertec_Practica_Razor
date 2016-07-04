
using System.Linq;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class StateProvinceData : BaseDataAccess<StateProvince>
    {
        public StateProvince GetStateProvince(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.StateProvince.FirstOrDefault(x => x.StateProvinceID == id);
            }
        }
    }
}
