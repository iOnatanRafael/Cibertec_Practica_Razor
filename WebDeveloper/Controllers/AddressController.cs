using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    [RoutePrefix("Address")]
    public class AddressController : Controller
    {
        private AddressData _address = new AddressData();

        // GET: Address
        [Route]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Address()
        {
            if (ModelState.IsValid)
            {
                _address.GetList();
                return RedirectToAction("Address");
            }
            return View();
        }


        [Route]
        public ActionResult Create()
        {
            return View(new Address());
        }

        [Route]
        [HttpPost]        
        public ActionResult Create(Address address)
        {
            if (ModelState.IsValid)
            {
                _address.Add(address);
                return RedirectToAction("Index");
            }
            return View();
        }

        [Route("Entry/{id:int}")]
        public ActionResult Edit(int ID)
        {
            Address address = _address.GetAddress(ID);
            if (address == null)
            {
                return RedirectToAction("Index");
            }
            return View(address);
        }

        [Route]
        [HttpPost]
        public ActionResult Edit(Address address)
        {
            if (ModelState.IsValid)
            {
                _address.Update(address);
                return RedirectToAction("Index");
            }
            return View();
        }

        [Route("Entry/{id:int}")]
        public ActionResult Delete(int ID)
        {
            Address address = _address.GetAddress(ID);
            if (address == null)
            {
                return RedirectToAction("Index");
            }
            return View(address);
        }

        [Route]
        [HttpPost]
        public ActionResult Delete(Address address)
        {
            if (_address.Delete(address) > 0)
                return RedirectToAction("Index");
            return View(address);
        }
    }
}