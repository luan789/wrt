using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using Model.Dao;
namespace Model.Dao
{
    public class ScheduleDao
    {
        WRTdbContext db = null;
        public ScheduleDao()
        {
            db = new WRTdbContext();
        }
        public List<wrt_t_schedule> getAll()
        {
            return db.wrt_t_schedule.OrderByDescending(x => x.id_schedule).ToList();
        }
        public string Insert(wrt_t_schedule enity)
        {
            db.wrt_t_schedule.Add(enity);
            db.SaveChanges();
            return enity.id_schedule;
        }
        public bool Update(wrt_t_schedule enity)
        {
            try
            {
                var schedule = db.wrt_t_schedule.Find(enity.id_schedule);
                schedule.id_schedule = enity.id_schedule;
                schedule.id_route = enity.id_route;
                schedule.id_driver = enity.id_driver;
                schedule.id_bus = enity.id_bus;
                schedule.departure = enity.departure;
                schedule.price = enity.price;
                schedule.note = enity.note;
                schedule.flag = enity.flag;        
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
                wrt_t_schedule schedule = db.wrt_t_schedule.Find(id);
                db.wrt_t_schedule.Remove(schedule);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public wrt_t_schedule ViewDetail(string id)
        {
            return db.wrt_t_schedule.Find(id);
        }

        public wrt_t_schedule GetByID(string idSchedule)
        {
            return db.wrt_t_schedule.SingleOrDefault(x => x.id_schedule == idSchedule);
        }
    }
}
