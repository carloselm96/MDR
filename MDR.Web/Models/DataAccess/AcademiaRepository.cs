using MDR.Web.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MDR.Web.Models.DataAccess
{
    public class AcademiaRepository
    {
        public static List<academias> GetAcademias()
        {
            try
            {
                micronaEntities db = new micronaEntities();
                return db.academias.ToList();
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public static academias GetAcademiaById(int id)
        {
            try
            {
                micronaEntities db = new micronaEntities();
                return db.academias.Where(x => x.ACADEMIA_ID == id).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool CreateAcademia(academias academias)
        {
            try
            {
                micronaEntities db = new micronaEntities();
                db.academias.Add(academias);
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
                db.academias.Remove(GetAcademiaById(id));
                return db.SaveChanges() != 0 ? true : false;
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}