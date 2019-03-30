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

        [HttpGet]
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
            }
            return Json(new { error = error, success = success }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult UpdateArticleType(string name, string id)
        {
            string error = string.Empty;
            bool success = false;
            try
            {
                success = ArticleTypesRepository.UpdateArticleType(new article_types { NAME = name, ARTICLE_TYPE_ID=int.Parse(id) });
            }
            catch (Exception e)
            {
                error = e.ToString();
            }
            return Json(new { error = error, success = success }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DeleteArticleType(string id)
        {
            string error = string.Empty;
            bool success = false;
            try
            {
                success = ArticleTypesRepository.DeleteArticleType(int.Parse(id));
            }
            catch (Exception e)
            {
                error = e.ToString();
            }
            return Json(new { error = error, success = success }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
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
            }
            return Json(new { error = error, success = success, BookTypes = BookTypes }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
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
            }
            return Json(new { error = error, success = success, Academias = Academias }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult CreateAcademia(string name)
        {
            string error = string.Empty;
            bool success = false;
            try
            {
                success = AcademiaRepository.CreateAcademia(new academias { NAME = name });
            }
            catch (Exception e)
            {
                error = e.ToString();
            }
            return Json(new { error = error, success = success }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult CreateBookType(string name)
        {
            string error = string.Empty;
            bool success = false;
            try
            {
                success = BookTypesRepository.CreateBookType(new book_types { NAME = name });
            }
            catch (Exception e)
            {
                error = e.ToString();
            }
            return Json(new { error = error, success = success }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult UpdateBookType(string id, string name)
        {
            string error = string.Empty;
            bool success = false;
            try
            {
                success = BookTypesRepository.UpdateBookType(new book_types { NAME=name, BOOK_TYPE_ID=int.Parse(id) });
            }
            catch (Exception e)
            {
                error = e.ToString();
            }
            return Json(new { error = error, success = success }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DeleteBookType(string id)
        {
            string error = string.Empty;
            bool success = false;
            try
            {
                success = BookTypesRepository.DeleteBookType(int.Parse(id));
            }
            catch (Exception e)
            {
                error = e.ToString();
            }
            return Json(new { error = error, success = success }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DeleteAcademia(string id)
        {
            string error = string.Empty;
            bool success = false;
            try
            {
                success = AcademiaRepository.DeleteAcademia(int.Parse(id));
            }
            catch (Exception e)
            {
                error = e.ToString();
            }
            return Json(new { error = error, success = success }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult UpdateAcademia(string name, string id)
        {
            string error = string.Empty;
            bool success = false;
            try
            {
                success = AcademiaRepository.UpdateAcademia(new academias { NAME = name, ACADEMIA_ID = int.Parse(id) });
            }
            catch (Exception e)
            {
                error = e.ToString();
            }
            return Json(new { error = error, success = success }, JsonRequestBehavior.AllowGet);
        }
    }
}