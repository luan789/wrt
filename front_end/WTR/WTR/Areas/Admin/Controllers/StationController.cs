using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;
using Model.Dao;
namespace WTR.Areas.Admin.Controllers
{
    public class StationController : Controller
    {
        // GET: Admin/Station
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetData()
        {
            try
            {
                var dao = new Station();
                List<wrt_i_station> lst = dao.getAll().ToList();
                List<object> lstStation = new List<object>();
                foreach (wrt_i_station item in lst)
                {
                    lstStation.Add(new
                    {
                        id_station = item.id_station,
                        name = item.name,
                        flag = item.flag,
                    });
                }
                return Json(new { success = true, content = lstStation }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                return Json(new { success = false, content = "null", message = "Thao tác tải dữ liệu không thành công. Vui lòng thực hiện lại thao tác" }, JsonRequestBehavior.AllowGet);
            }

        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(wrt_i_station station)
        {
            try
            {
                Station dao = new Station();
                string id = dao.Insert(station);
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, content = "null", message = "Thao tác tải dữ liệu không thành công. Vui lòng thực hiện lại thao tác", log = ex.ToString() });
            }
        }
        [HttpPost]
        public ActionResult Edit(wrt_i_station station)
        {
            var dao = new Station();
            var result = dao.Update(station);
            if (result)
            {
                return Json(new { success = true, content = station }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { success = false, content = "null", message = "Thao tác tải dữ liệu không thành công. Vui lòng thực hiện lại thao tác" }, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult Delete(string id)
        {
            Station dao = new Station();
            var result = dao.Delete(id);
            if (result)
            {
                return Json(new { success = true }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { success = false });
        }
    }
}