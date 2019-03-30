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

        public static bool CreateBookType(book_types book_types)
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

        public static bool DeleteBookType(int id)
        {
            try
            {
                micronaEntities db = new micronaEntities();
                var aux = db.book_types.Where(x => x.BOOK_TYPE_ID == id).FirstOrDefault();
                db.book_types.Remove(aux);
                return db.SaveChanges() != 0 ? true : false;
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public static bool UpdateBookType(book_types book_Types)
        {
            try
            {
                micronaEntities db = new micronaEntities();
                var aux = db.book_types.Where(x => x.BOOK_TYPE_ID == book_Types.BOOK_TYPE_ID).FirstOrDefault();
                aux.NAME = book_Types.NAME;
                return db.SaveChanges() != 0 ? true : false;
            }
            catch (Exception e)
            {

                throw;
            }
        }
        
    }
}