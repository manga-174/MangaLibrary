using MangaLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MangaLibrary.Controllers
{
    [Authorize (Users ="Manga@gmail.com")]
   
   
    public class IssueBookController : Controller
    {

        Models.MangaLibraryEntities db = new Models.MangaLibraryEntities();
        // GET: IssueBook
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Getbook()
        {
            var books = db.books.Select(p => new
            {
                ID = p.id,
                Bname = p.bname,
                Bedition=p.edition

            }
            ).ToList();
            return Json(books, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public ActionResult GetMid(int mid)
        {
            var memberid = (from s in db.members where s.id == mid select s.name).ToList();
            return Json(memberid,JsonRequestBehavior.AllowGet);
        }
        
        [HttpPost]
        public ActionResult Save(issuebook issue)
        {
           if(ModelState.IsValid)
            {
                db.issuebooks.Add(issue);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(issue);
        }
       

    }
}