using MDR.Web.Models.DataAccess;
using MDR.Web.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MDR.Web.Controllers
{
    public class ArticlesController : Controller
    {
        // GET: Articles
        public ActionResult Index()
        {
            var articles = ArticlesRepository.GetArticles();
            return View(articles);
        }

        [HttpPost]
        public JsonResult getArticles()
        {
            bool success=false;
            string error= string.Empty;
            List<articles> articles = new List<articles>();
            try
            {
                articles = ArticlesRepository.GetArticles();
                success = true;
                return Json(new { success = success, result = articles, error = error }, JsonRequestBehavior.AllowGet);
            }
            catch(Exception e)
            {
                error = e.ToString();
                return Json(new { success = success, result= articles, error = error }, JsonRequestBehavior.AllowGet);
            }            
        }

        public ActionResult CreateArticle()
        {
            ViewBag.types = ArticleTypesRepository.GetArticlesTypes();
            return View();
        }

        [HttpPost]
        public ActionResult CreateArticle(articles articles, List<string> authors, List<string> academias)
        {
            if (ModelState.IsValid == true)
            {
                ArticlesRepository.CreateArticle(articles);
                return RedirectToAction("Index", new { result="true" });
            }
            else
            {
                ViewBag.types = ArticleTypesRepository.GetArticlesTypes();
                return View(articles);
            }                        
        }
    }
}