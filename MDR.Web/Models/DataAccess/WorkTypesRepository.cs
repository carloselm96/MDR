using MDR.Web.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MDR.Web.Models.DataAccess
{
    public class WorkTypesRepository
    {
        public static List<work_types> GetWorkTypes()
        {
            try
            {
                micronaEntities db = new micronaEntities();
                return db.work_types.ToList();
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public static work_types GetWorkTypeById(int id)
        {
            try
            {
                micronaEntities db = new micronaEntities();
                return db.work_types.Where(x => x.WORK_TYPE_ID == id).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool CreateAcademia(work_types work_types)
        {
            try
            {
                micronaEntities db = new micronaEntities();
                db.work_types.Add(work_types);
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
                db.work_types.Remove(GetWorkTypeById(id));
                return db.SaveChanges() != 0 ? true : false;
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}