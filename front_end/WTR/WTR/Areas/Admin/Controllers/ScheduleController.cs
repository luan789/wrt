using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;
using Model.Dao;
namespace WTR.Areas.Admin.Controllers
{
    public class ScheduleController : Controller
    {
        // GET: Admin/Schedule
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetData()
        {
            try
            {
                var dao = new ScheduleDao();
                List<wrt_t_schedule> lst = dao.getAll().ToList();
                List<object> lstSchedule = new List<object>();
                foreach (wrt_t_schedule item in lst)
                {
                    lstSchedule.Add(new
                    {
                        id_schedule = item.id_schedule,
                        id_bus = item.id_bus,
                        id_driver = item.id_driver,
                        id_route = item.id_route,
                        departure = item.departure,
                        price = item.price,
                        note=item.note,
                        flag=item.flag,
                    });
                }
                return Json(new { success = true, content = lstSchedule }, JsonRequestBehavior.AllowGet);
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
        public ActionResult Create(wrt_t_schedule schedule)
        {
            try
            {
                ScheduleDao dao = new ScheduleDao();
                string id = dao.Insert(schedule);
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, content = "null", message = "Thao tác tải dữ liệu không thành công. Vui lòng thực hiện lại thao tác", log = ex.ToString() });
            }
        }
        [HttpPost]
        public ActionResult Edit(wrt_t_schedule schedule)
        {
            var dao = new ScheduleDao();
            var result = dao.Update(schedule);
            if (result)
            {
                return Json(new { success = true, content = schedule }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { success = false, content = "null", message = "Thao tác tải dữ liệu không thành công. Vui lòng thực hiện lại thao tác" }, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult Delete(string id)
        {
            ScheduleDao dao = new ScheduleDao();
            var result = dao.Delete(id);
            if (result)
            {
                return Json(new { success = true }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { success = false });
        }
    }
}