using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class AddressTypeController : Controller
    {
        private AddressTypeData _addressType = new AddressTypeData();

        // GET: AddressType
        public ActionResult Index()
        {
            var addressType = new AddressTypeData();
            return View(addressType.GetList());
        }

        public ActionResult Create()
        {
            return View(new AddressType());
        }

        [HttpPost]
        public ActionResult Create(AddressType addressType)
        {
            if (ModelState.IsValid)
            {
                _addressType.Add(addressType);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int ID)
        {
            AddressType addressType = _addressType.GetAddressType(ID);
            if (addressType == null)
            {
                return RedirectToAction("Index");
            }
            return View(addressType);
        }

        [HttpPost]
        public ActionResult Edit(AddressType addressType)
        {
            if (ModelState.IsValid)
            {
                _addressType.Update(addressType);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int ID)
        {
            AddressType addressType = _addressType.GetAddressType(ID);
            if (addressType == null)
            {
                return RedirectToAction("Index");
            }
            return View(addressType);
        }

        [HttpPost]
        public ActionResult Delete(AddressType addressType)
        {
            if (_addressType.Delete(addressType) > 0)
                return RedirectToAction("Index");
            return View(addressType);
        }
    }
}