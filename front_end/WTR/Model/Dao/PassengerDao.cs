using Model.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class PassengerDao
    {
        WRTdbContext db = null;
        public PassengerDao()
        {
            db = new WRTdbContext();
        }
        public List<wrt_i_passenger> getAll()
        {
            return db.wrt_i_passenger.OrderByDescending(x=>x.name).ToList();
        }
        public string Insert(wrt_i_passenger enity)
        {
            db.wrt_i_passenger.Add(enity);
            db.SaveChanges();
            return enity.id_passenger;
        }
        public bool Update(wrt_i_passenger enity)
        {
            try
            {
                var user = db.wrt_i_passenger.Find(enity.id_passenger);
                user.name = enity.name;
                user.pass = enity.pass;
                user.e_mail = enity.e_mail;
                user.phone = enity.phone;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Delete(string id)
        {
            try
            {
                wrt_i_passenger user = db.wrt_i_passenger.Find(id);
                db.wrt_i_passenger.Remove(user);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public wrt_i_passenger ViewDetail(int id)
        {
            return db.wrt_i_passenger.Find(id);
        }

        public wrt_i_passenger GetByID(string Name)
        {
            return db.wrt_i_passenger.SingleOrDefault(x => x.name == Name);
        }
        public int Login(string Email, string passWord)
        {
            var result = db.wrt_i_passenger.SingleOrDefault(x => x.e_mail == Email);
            if (result == null)
            {
                return 0;
            }
            else
            {
                if (result.flag == "0")
                {
                    return -1;
                }
                else
                {
                    if (result.pass == passWord)
                    {
                        return 1;
                    }
                    else
                    {
                        return -2;
                    }
                }
            }
        }
    }
}
