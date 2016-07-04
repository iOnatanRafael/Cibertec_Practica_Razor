using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class ContactTypeController : Controller
    {
        private ContactTypeData _contactType = new ContactTypeData();

        // GET: ContactType
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View(new ContactType());
        }

        [HttpPost]
        public ActionResult Create(ContactType contactType)
        {
            if (ModelState.IsValid)
            {
                _contactType.Add(contactType);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int ID)
        {
            ContactType contactType = _contactType.GetContactType(ID);
            if (contactType == null)
            {
                return RedirectToAction("Index");
            }
            return View(contactType);
        }

        [HttpPost]
        public ActionResult Edit(ContactType contactType)
        {
            if (ModelState.IsValid)
            {
                _contactType.Update(contactType);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int ID)
        {
            ContactType contactType = _contactType.GetContactType(ID);
            if (contactType == null)
            {
                return RedirectToAction("Index");
            }
            return View(contactType);
        }

        [HttpPost]
        public ActionResult Delete(ContactType contactType)
        {
            if (_contactType.Delete(contactType) > 0)
                return RedirectToAction("Index");
            return View(contactType);
        }
    }
}