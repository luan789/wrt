using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using Model.Dao;
using PagedList;

namespace Model.Dao
{
    public class DriverDao
    {
        WRTdbContext db = null;
        public DriverDao()
        {
            db = new WRTdbContext();
        }
        public List<wrt_i_driver> getAll(int page, int pageSize)
        {
            return db.wrt_i_driver.OrderByDescending(x => x.id_driver).ToPagedList(page, pageSize).ToList();
        }
        public string Insert(wrt_i_driver enity)
        {
            db.wrt_i_driver.Add(enity);
            db.SaveChanges();
            return enity.id_driver;
        }
        public bool Update(wrt_i_driver enity)
        {
            try
            {
                var driver = db.wrt_i_driver.Find(enity.id_driver);
                driver.id_driver = enity.id_driver;
                driver.name = enity.name;
                driver.birth = enity.birth;
                driver.add = enity.add;
                driver.phone = enity.phone;
                driver.note = enity.note;
                driver.flag = enity.flag;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Delete(wrt_i_driver enity)
        {
            try
            {
                var driver = db.wrt_i_driver.Find(enity.id_driver);
                db.wrt_i_driver.Remove(driver);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public wrt_i_driver ViewDetail(string id)
        {
            return db.wrt_i_driver.Find(id);
        }

        public wrt_i_driver GetByID(string idDriver)
        {
            return db.wrt_i_driver.SingleOrDefault(x => x.id_driver == idDriver);
        }
        public IEnumerable<wrt_i_driver> ListAllPaging(string searchString, int page, int pageSize)
        {
            IQueryable<wrt_i_driver> model = db.wrt_i_driver;
            if (!string.IsNullOrEmpty(searchString))
            {
                //Tự tạo câu lệnh select trong SQL
                model = model.Where(x => x.name.Contains(searchString) || x.name.Contains(searchString));
            }
            return model.OrderByDescending(x => x.id_driver).ToPagedList(page, pageSize);
        }
    }
}
