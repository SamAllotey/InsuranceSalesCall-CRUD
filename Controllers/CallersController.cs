using MariaAndSonsInsLtd.Entity;
using MariaAndSonsInsLtd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace MariaAndSonsInsLtd.Controllers
{
    public class CallersController : Controller
    {
        private readonly CallerDbContext _context;
        public CallersController(CallerDbContext context)
        {
            _context = context;
        }

        //public List<Caller> myList = new List<Caller>();

        // GET: CallersController
        public ActionResult Index()
        {
            IEnumerable<Caller> objList = _context.Callers;
            return View(objList);
        }

        // GET: CallersController/Details/5
        public ActionResult Details(string id)
        {
            Caller caller = GetCaller(id);
            return View(caller);
        }

        // GET: CallersController/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: CallersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Caller obj)
        {
            if (ModelState.IsValid)
            {
                _context.Callers.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
            
        }

        // GET: CallersController/Edit/5
        public ActionResult Edit(string id)
        {
            Caller caller = GetCaller(id);
            return View(caller);
        }

        // POST: CallersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Caller obj)
        {
            try
            {
                _context.Callers.Attach(obj);
                _context.Entry(obj).State=EntityState.Modified;
                _context.SaveChanges();
               
            }
            catch
            {
               
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: CallersController/Delete/5
        public ActionResult Delete(string id)
        {
            Caller caller = GetCaller(id);
            return View(caller);
        }

        // POST: CallersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Caller obj)
        {
            try
            {
                _context.Callers.Attach(obj);
                _context.Entry(obj).State = EntityState.Deleted;
                _context.SaveChanges(); 
            }
            catch
            {
            
            }
            return RedirectToAction(nameof(Index));
        }

        private Caller GetCaller(string id)
        {
            Caller caller = _context.Callers.Where(u=>u.CallerId == id).FirstOrDefault();
            return caller;
        }

    }
}
