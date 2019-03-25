using MDR.Web.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MDR.Web.Models.DataAccess
{
    public class ArticlesRepository
    {
        public static List<articles> GetArticles()
        {
            try
            {
                micronaEntities db = new micronaEntities();
                return db.articles.ToList();
            }
            catch(Exception e)
            {
                throw;
            }
        }
        
        public static bool CreateArticle(articles articles)
        {
            try
            {
                micronaEntities db = new micronaEntities();
                articles=db.articles.Add(articles);
                return db.SaveChanges() != 0 ? true : false;
            }
            catch(Exception e)
            {
                throw;
            }
        }

        public static articles GetArticleById(int id)
        {
            try
            {
                micronaEntities db = new micronaEntities();
                return db.articles.Where(x => x.ARTICLE_ID == id).FirstOrDefault();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static bool DeleteArticle(int id)
        {
            try
            {
                micronaEntities db = new micronaEntities();
                db.articles.Remove(GetArticleById(id));
                return db.SaveChanges() != 0 ? true : false;
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}