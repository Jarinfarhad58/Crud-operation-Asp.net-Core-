using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Star_Academy.Models;

namespace Star_Academy.Controllers
{
    public class HomeController : Controller
    {
        private Context _context;
        public HomeController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Admission()
        {
            
            return View();
        }

        public IActionResult Result()
        {

            return View();
        }
        public IActionResult StudentResultView()
        {

            return View(_context.Result.ToList());
        }
        // GET :/Update/StudentResultView/DetailView
        public ActionResult DetailView(int id = 0)
        {

            {
              
                return View(_context.Result.Where(x => x.StudentID == id).FirstOrDefault());

            }
        }

        public IActionResult StudentResult()
        {

            return View(_context.Result.ToList());

        }
        // GET :/Update/StudentResult/Detail
        public ActionResult Detail(int id = 0 )
        {
            
            {
                return View(_context.Result.Where(x => x.StudentID == id).FirstOrDefault());
            }
        }
        // GET :/Update/StudentResult/Edit
        public ActionResult Edit(int id = 0)
       
            {
                return View(_context.Result.Where(x => x.StudentID == id).FirstOrDefault());
            }
        
        [HttpPost]
        public ActionResult Edit(int id, Result result)


        {
            try
            {
               
                    _context.Entry(result).State = EntityState.Modified;
                    _context.SaveChanges();
              
                return RedirectToAction("StudentResult");
            }
            catch
            {
                return View();
            }

        }
        // GET :/Update/StudentResult/Delete
        public ActionResult Delete(int id = 0)
        {
            var deletedstudent = _context.Result.Where(x => x.StudentID == id).FirstOrDefault();
            _context.Result.Remove(deletedstudent);
            _context.SaveChanges();
                return RedirectToAction("StudentResult");

        }

        public IActionResult SeeForms()
        {
            return View(_context.Form.ToList());
        }
        public ActionResult AdmissionForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdmissionForm(Form form)
        {
            if (ModelState.IsValid)
            {
                _context.Form.Add(form);
                _context.SaveChanges();
                ModelState.Clear();
                ViewBag.Message = "Successfully Uploaded";
            }

            return View();
        }
        

        public ActionResult AdminResult()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminResult(User userModel)
        {
           var account= _context.User.Where(u=>u.UserName==userModel.UserName && u.Password==userModel.Password).FirstOrDefault();
            if (account != null)
            {
                HttpContext.Session.SetString("UserId", account.UserID.ToString());
                HttpContext.Session.SetString("UserName", account.UserName);
                return RedirectToAction("UpdateResult","Update");
            }
            else
            {
                ModelState.AddModelError("", "User Name Or Password is Wrong");
                return View("AdminResult", userModel);
            }
           
        }
        public IActionResult UpdateResult()
        {
            
            if(HttpContext.Session.GetString("UserID") != null)
            {
                ViewBag.UserName = HttpContext.Session.GetString("UserName");
                return View();
            }
            else
            {
                return RedirectToAction("AdminResult");
            }

            
        }
       

    }
}
