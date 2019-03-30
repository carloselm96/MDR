using MDR.Web.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MDR.Web.Models.DataAccess
{
    public class ArticleTypesRepository
    {
        public static List<article_types> GetArticlesTypes()
        {
            try
            {
                micronaEntities db = new micronaEntities();
                return db.article_types.ToList();
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public static article_types GetArticleById(int id)
        {
            try
            {
                micronaEntities db = new micronaEntities();                
                return db.article_types.Where(x => x.ARTICLE_TYPE_ID == id).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool CreateArticleType(article_types article_types)
        {
            try
            {
                micronaEntities db = new micronaEntities();
                db.article_types.Add(article_types);
                return db.SaveChanges() != 0 ? true : false;
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public static bool UpdateArticleType(article_types article_types)
        {
            try
            {
                micronaEntities db = new micronaEntities();
                var aux = db.article_types.Where(x => x.ARTICLE_TYPE_ID == article_types.ARTICLE_TYPE_ID).FirstOrDefault();
                aux.NAME = article_types.NAME;                
                return db.SaveChanges() != 0 ? true : false;
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public static bool DeleteArticleType(int id)
        {
            try
            {
                micronaEntities db = new micronaEntities();
                var aux = db.article_types.Where(x => x.ARTICLE_TYPE_ID == id).FirstOrDefault();
                db.article_types.Remove(aux);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}