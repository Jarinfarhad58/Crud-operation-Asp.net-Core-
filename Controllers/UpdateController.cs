using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Star_Academy.Models;


namespace Star_Academy.Controllers
{
    public class UpdateController : Controller
    {
        private Context _context;
        public UpdateController(Context context)
        {
            _context = context;
        }
       public ActionResult UpdateResult()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpdateResult(Result resultModel)
        {
           
           
                if (ModelState.IsValid)
                {
                   _context.Result.Add(resultModel);
                 _context.SaveChanges();
                ModelState.Clear();
                ViewBag.Message = "Successfully Uploaded";
                }
            return View();
        }

        public ActionResult AdminAdmission()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminAdmission(User usModel)
        {
            var accoun = _context.User.Where(u => u.UserName == usModel.UserName && u.Password == usModel.Password).FirstOrDefault();
            if (accoun != null)
            {
                HttpContext.Session.SetString("UserId", accoun.UserID.ToString());
                HttpContext.Session.SetString("UserName", accoun.UserName);
                return RedirectToAction("SeeForms","Home");
            }
            else
            {
                ModelState.AddModelError("", "User Name Or Password is Wrong");
                return View("AdminAdmission", usModel);
            }

        }

        public IActionResult SeeForms()
        {

            if (HttpContext.Session.GetString("UserID") != null)
            {
                ViewBag.UserName = HttpContext.Session.GetString("UserName");
                return View();
            }
            else
            {
                return RedirectToAction("AdminAdmission");
            }


        }
    }
}