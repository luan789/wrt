using Model.Dao;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WTR.Areas.Admin.Controllers
{
    public class TickerController : Controller
    {
        // GET: Admin/Ticker
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetData()
        {
            try
            {
                var dao = new TickerDao();
                List<wrt_i_ticket> lst = dao.getAll().ToList();
                List<object> lstTicker = new List<object>();
                foreach (wrt_i_ticket item in lst)
                {
                    lstTicker.Add(new
                    {
                        id_passenger = item.id_passenger,
                        id_ticket = item.id_ticket,
                        id_schedule = item.id_schedule,
                        number_seat = item.number_seat,
                        flag = item.flag,
                    });
                }
                return Json(new { success = true, content = lstTicker }, JsonRequestBehavior.AllowGet);
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
        public ActionResult Create(wrt_i_ticket ticker)
        {
            try
            {
                TickerDao dao = new TickerDao();
                string id = dao.Insert(ticker);
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, content = "null", message = "Thao tác tải dữ liệu không thành công. Vui lòng thực hiện lại thao tác", log = ex.ToString() });
            }
        }
        [HttpPost]
        public ActionResult Edit(wrt_i_ticket passenger)
        {
            var dao = new TickerDao();
            var result = dao.Update(passenger);
            if (result)
            {
                return Json(new { success = true, content = passenger }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { success = false, content = "null", message = "Thao tác tải dữ liệu không thành công. Vui lòng thực hiện lại thao tác" }, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult Delete(string id)
        {
            TickerDao dao = new TickerDao();
            var result = dao.Delete(id);
            if (result)
            {
                return Json(new { success = true }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { success = false });
        }
    }
}