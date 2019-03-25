using MDR.Web.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MDR.Web.Models.DataAccess
{
    public class BookTypesRepository
    {
        public static List<book_types> GetBookTypes()
        {
            try
            {
                micronaEntities db = new micronaEntities();
                return db.book_types.ToList();
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public static book_types GetBookyTypeById(int id)
        {
            try
            {
                micronaEntities db = new micronaEntities();
                return db.book_types.Where(x => x.BOOK_TYPE_ID == id).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool CreateAcademia(book_types book_types)
        {
            try
            {
                micronaEntities db = new micronaEntities();
                db.book_types.Add(book_types);
                return db.SaveChanges() != 0 ? true : false;
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public static bool DeleteAcademia(int id)
        {
            try
            {
                micronaEntities db = new micronaEntities();
                db.book_types.Remove(GetBookyTypeById(id));
                return db.SaveChanges() != 0 ? true : false;
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}