using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class TickerDao
    {
        WRTdbContext db = null;
        public TickerDao()
        {
            db = new WRTdbContext();
        }
        public List<wrt_i_ticket> getAll()
        {
            return db.wrt_i_ticket.OrderByDescending(x => x.id_passenger).ToList();
        }
        public string Insert(wrt_i_ticket enity)
        {
            db.wrt_i_ticket.Add(enity);
            db.SaveChanges();
            return enity.id_ticket;
        }
        public bool Update(wrt_i_ticket enity)
        {
            try
            {
                var ticker = db.wrt_i_ticket.Find(enity.id_ticket);
                ticker.id_passenger = enity.id_passenger;
                ticker.id_schedule = enity.id_schedule;
                ticker.number_seat = enity.number_seat;
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
                wrt_i_ticket ticker = db.wrt_i_ticket.Find(id);
                db.wrt_i_ticket.Remove(ticker);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public wrt_i_ticket ViewDetail(string id)
        {
            return db.wrt_i_ticket.Find(id);
        }

        public wrt_i_ticket GetByID(string idPassenger)
        {
            return db.wrt_i_ticket.SingleOrDefault(x => x.id_passenger == idPassenger);
        }
    }
}
