using BillingSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Reflection;

namespace BillingSystem.Controllers
{
    public class BillingController : Controller
    {
        public Commonview obj;
        public Repo obj1;
        public dropdownrepo obj2;
        public Total obj3;

        public BillingController() 
        { 
            obj = new Commonview();
            obj1 = new Repo();
            obj2= new dropdownrepo();
            obj3=new Total();
        }
        public ActionResult Index()
        {
            var model = new Commonview();
          model.BillingCreate=new BillingAddressess();
            model.ShippingCreate=new ShippingAddress();
            model.AddProduct=new AddProduct();
            model.ProductDrop = obj2.ListProduct();

            model.Cart = new List<AddProduct>();
            model.Cart= obj1.ListProduct();
            obj3.Totalamount();


            return View("Mainview",model);
        
        }

        public ActionResult Totalamount()
        {
            var total = new Commonview();
            total.Total = new List<Total>();
            total.Total=obj1.Totalamount();
            return View("Mainview", total);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Creates()
        {
            try
            {
                if (ModelState.IsValid)
                {
                   
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View("Mainview");

                }
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }

        public ActionResult Insert (AddProduct data)
        {
            try
            {
                ModelState.Remove("Code");
                ModelState.Remove("Quantity");
                ModelState.Remove("ProductName");

                if (ModelState.IsValid)
                {

                    obj1.InsertProduct(data);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    data.ProductDrop = obj2.ListProduct();

                    return View("Mainview", data);

                }
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }



    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Clean()
        {
            try
            {
                obj1.Cleans();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Total()
        {
            try
            {
                obj1.Totalamount();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        public ActionResult Delete(int No)
        {
            var result = obj1.Getproduct(No);
            return View("Delete",result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Remove(int No)
        {
            try
            {
                obj1.Delete(No);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
