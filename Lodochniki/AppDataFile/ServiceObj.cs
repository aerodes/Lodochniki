using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lodochniki.AppDataFile
{
    public class ServiceObj
    {
        public static void Add<T>(T entity) where T : class
        {
            using (ProbaWSEntities db = new ProbaWSEntities())
            {
                db.Entry(entity).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
            }
        }
        public static void Delete<T>(T entity) where T : class
        {
            using (ProbaWSEntities db = new ProbaWSEntities())
            {
                db.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
        public static void Update<T>(T entity) where T : class
        {
            using (ProbaWSEntities db = new ProbaWSEntities())
            {
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
