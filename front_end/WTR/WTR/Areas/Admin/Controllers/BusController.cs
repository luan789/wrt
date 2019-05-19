using Model.Dao;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WTR.Areas.Admin.Controllers
{
    public class BusController : Controller
    {
        // GET: Admin/Bus
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetData()
        {
            try
            {
                var dao = new BusDao();
                List<wrt_i_bus> lst = dao.getAll().ToList();
                List<object> lstBus = new List<object>();
                foreach (wrt_i_bus item in lst)
                {
                    lstBus.Add(new
                    {
                        id_bus = item.id_bus,
                        type = item.type,
                        note = item.note,
                        flag = item.flag,
                    });
                }
                return Json(new { success = true, content = lstBus }, JsonRequestBehavior.AllowGet);
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
        public ActionResult Create(wrt_i_bus bus)
        {
            try
            {
                BusDao dao = new BusDao();
                string id = dao.Insert(bus);
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, content = "null", message = "Thao tác tải dữ liệu không thành công. Vui lòng thực hiện lại thao tác", log = ex.ToString() });
            }
        }
        [HttpPost]
        public ActionResult Edit(wrt_i_bus bus)
        {
            var dao = new BusDao();
            var result = dao.Update(bus);
            if (result)
            {
                return Json(new { success = true, content = bus }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { success = false, content = "null", message = "Thao tác tải dữ liệu không thành công. Vui lòng thực hiện lại thao tác" }, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult Delete(wrt_i_bus id)
        {
            
            var dao = new BusDao();
            var result = dao.Delete(id);
            if (result)
            {
                return Json(new { success = true }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { success = false });
        }
    }
}