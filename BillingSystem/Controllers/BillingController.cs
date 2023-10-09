using BillingSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BillingSystem.Controllers
{
    public class BillingController : Controller
    {
        public Commonview obj;

        public BillingController() 
        { 
            obj = new Commonview();
        }
        public ActionResult Index()
        {
            var model = new Commonview();
          model.BillingCreate=new BillingAddressess();
            model.ShippingCreate=new ShippingAddress();
            model.AddProduct=new AddProduct();
/*            return ViewData("Mainview", model,new List<AddProduct>());
           */    
             return View("Mainview",model);
        
        }
        public ActionResult Creates(BillingAddressess data)
        {
            try
            {
                if (ModelState.IsValid)
                {
                   
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View("Index", data);

                }
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }

        // GET: BillingController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BillingController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BillingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BillingController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BillingController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BillingController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BillingController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
