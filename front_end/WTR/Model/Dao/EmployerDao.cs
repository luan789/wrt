using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class EmployerDao
    {
        WRTdbContext db = null;
        public EmployerDao()
        {
            db = new WRTdbContext();
        }
        public List<wrt_i_employer> getAll()
        {
            return db.wrt_i_employer.OrderByDescending(x => x.name).ToList();
        }
        public string Insert(wrt_i_employer enity)
        {
            db.wrt_i_employer.Add(enity);
            db.SaveChanges();
            return enity.id_employer;
        }
        public bool Update(wrt_i_employer enity)
        {
            try
            {
                var user = db.wrt_i_employer.Find(enity.id_employer);
                user.id_employer = enity.id_employer;
                user.name = enity.name;
                user.pass = enity.pass;
                user.e_mail = enity.e_mail;
                user.phone = enity.phone;
                user.flag = enity.flag;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool Delete(wrt_i_employer id)
        {
            try
            {
                wrt_i_employer user = db.wrt_i_employer.Find(id.id_employer);
                db.wrt_i_employer.Remove(user);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public wrt_i_employer ViewDetail(string id)
        {
            return db.wrt_i_employer.Find(id);
        }
    }
}
