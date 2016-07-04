using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class StateProvinceController : Controller
    {
        private StateProvinceData _addressType = new StateProvinceData();

        // GET: StateProvince
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View(new StateProvince());
        }

        [HttpPost]
        public ActionResult Create(StateProvince stateProvince)
        {
            if (ModelState.IsValid)
            {
                _addressType.Add(stateProvince);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int ID)
        {
            StateProvince stateProvince = _addressType.GetStateProvince(ID);
            if (stateProvince == null)
            {
                return RedirectToAction("Index");
            }
            return View(stateProvince);
        }

        [HttpPost]
        public ActionResult Edit(StateProvince stateProvince)
        {
            if (ModelState.IsValid)
            {
                _addressType.Update(stateProvince);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int ID)
        {
            StateProvince stateProvince = _addressType.GetStateProvince(ID);
            if (stateProvince == null)
            {
                return RedirectToAction("Index");
            }
            return View(stateProvince);
        }

        [HttpPost]
        public ActionResult Delete(StateProvince stateProvince)
        {
            if (_addressType.Delete(stateProvince) > 0)
                return RedirectToAction("Index");
            return View(stateProvince);
        }
    }
}