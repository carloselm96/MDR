using MDR.Web.Models.DataAccess;
using MDR.Web.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MDR.Web.Controllers
{
    public class CataloguesController : Controller
    {
        // GET: Catalogues
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetArticlesTypes()
        {
            string error = string.Empty;
            bool success = false;
            List<article_types> ArticlesTypes = new List<article_types>();
            try
            {
                ArticlesTypes=ArticleTypesRepository.GetArticlesTypes();
                success = true;                
            }
            catch (Exception e)
            {
                error = e.ToString();
                throw;
            }
            return Json(new { error = error, success = success, ArticleTypes = ArticlesTypes }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult CreateArticleType(string name)
        {
            string error = string.Empty;
            bool success = false;            
            try
            {
                success = ArticleTypesRepository.CreateArticleType(new article_types { NAME = name });
            }
            catch (Exception e)
            {
                error = e.ToString();
                throw;
            }
            return Json(new { error = error, success = success }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetBookTypes()
        {
            string error = string.Empty;
            bool success = false;
            List<book_types> BookTypes = new List<book_types>();
            try
            {
                BookTypes = BookTypesRepository.GetBookTypes();
                success = true;
            }
            catch (Exception e)
            {
                error = e.ToString();
                throw;
            }
            return Json(new { error = error, success = success, BookTypes = BookTypes }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetAcademias()
        {
            string error = string.Empty;
            bool success = false;
            List<academias> Academias = new List<academias>();
            try
            {
                Academias = AcademiaRepository.GetAcademias();
                success = true;
            }
            catch (Exception e)
            {
                error = e.ToString();
                throw;
            }
            return Json(new { error = error, success = success, Academias = Academias }, JsonRequestBehavior.AllowGet);
        }
    }
}