using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class PersonController : Controller
    {
        private PersonData _person = new PersonData();

        // GET: Person
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View(new Person());
        }

        [HttpPost]
        public ActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                _person.Add(person);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int ID)
        {
            Person Person = _person.GetPerson(ID);
            if (Person == null)
            {
                return RedirectToAction("Index");
            }
            return View(Person);
        }

        [HttpPost]
        public ActionResult Edit(Person person)
        {
            if (ModelState.IsValid)
            {
                _person.Update(person);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int ID)
        {
            Person person = _person.GetPerson(ID);
            if (person == null)
            {
                return RedirectToAction("Index");
            }
            return View(person);
        }

        [HttpPost]
        public ActionResult Delete(Person person)
        {
            if (_person.Delete(person) > 0)
                return RedirectToAction("Index");
            return View(person);
        }
    }
}