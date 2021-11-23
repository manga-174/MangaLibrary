using MangaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MangaLibrary.Controllers
{
    [Authorize(Users = "Manga@gmail.com")]
    public class ReturnBookController : Controller
    {
        // GET: ReturnBook
        Models.MangaLibraryEntities db = new Models.MangaLibraryEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(returnbook returns)
        {
            if (ModelState.IsValid)
            {
                db.returnbooks.Add(returns);
                db.SaveChanges();
                
                return RedirectToAction("Index");
                
            }
            return View(returns);
        }


        public ActionResult GetMid(int mid)
        {
            var memberid = (from s in db.issuebooks where s.m_id == mid select new
            {
                IssueDate = s.issuedate,
                ReturnDate = s.returndate,
                Memberid = s.m_id,
                BookName = s.book_id,
                ElapsedDays = SqlFunctions.DateDiff("day",s.returndate,DateTime.Now)
            }).ToArray();
            return Json(memberid, JsonRequestBehavior.AllowGet);
        }
    }
    
}