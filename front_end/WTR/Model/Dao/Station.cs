using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Dao;
using Model.EF;
namespace Model.Dao
{
    public class Station
    {
        WRTdbContext db = null;
        public Station()
        {
            db = new WRTdbContext();
        }
        public List<wrt_i_station> getAll()
        {
            return db.wrt_i_station.OrderByDescending(x => x.id_station).ToList();
        }
        public string Insert(wrt_i_station enity)
        {
            db.wrt_i_station.Add(enity);
            db.SaveChanges();
            return enity.id_station;
        }
        public bool Update(wrt_i_station enity)
        {
            try
            {
                var station = db.wrt_i_station.Find(enity.id_station);
                station.id_station = enity.id_station;
                station.name = enity.name;
                station.flag = enity.flag;
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
                wrt_i_station station = db.wrt_i_station.Find(id);
                db.wrt_i_station.Remove(station);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public wrt_i_station ViewDetail(string id)
        {
            return db.wrt_i_station.Find(id);
        }

        public wrt_i_station GetByID(string idstation)
        {
            return db.wrt_i_station.SingleOrDefault(x => x.id_station == idstation);
        }
    }
}
