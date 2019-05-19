using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using Model.Dao;
namespace Model.Dao
{
    public class BusDao
    {
        WRTdbContext db = null;
        public BusDao()
        {
            db = new WRTdbContext();
        }
        public List<wrt_i_bus> getAll()
        {
            return db.wrt_i_bus.OrderByDescending(x => x.id_bus).ToList();
        }
        public string Insert(wrt_i_bus enity)
        {
            db.wrt_i_bus.Add(enity);
            db.SaveChanges();
            return enity.id_bus;
        }
        public bool Update(wrt_i_bus enity)
        {
            try
            {
                var bus = db.wrt_i_bus.Find(enity.id_bus);
                bus.id_bus = enity.id_bus;
                bus.type = enity.type;
                bus.note = enity.note;
                bus.flag = enity.flag;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Delete(wrt_i_bus enity)
        {
            try
            {
                var bus = db.wrt_i_bus.Find(enity.id_bus);
                db.wrt_i_bus.Remove(bus);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public wrt_i_bus ViewDetail(string id)
        {
            return db.wrt_i_bus.Find(id);
        }

        public wrt_i_bus GetByID(string idBus)
        {
            return db.wrt_i_bus.SingleOrDefault(x => x.id_bus == idBus);
        }
    }
}
