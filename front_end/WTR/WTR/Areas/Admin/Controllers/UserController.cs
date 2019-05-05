using Model.Dao;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WTR.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        // GET: Admin/User
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetData()
        {
            try
            {
                var dao = new PassengerDao();
                List<Model.EF.wrt_i_passenger> lst = dao.getAll().ToList();
                List<object> lstPassenger = new List<object>();
                foreach (Model.EF.wrt_i_passenger item in lst)
                {
                    lstPassenger.Add(new
                    {
                        id_passenger = item.id_passenger,
                        name = item.name,
                        phone = item.phone,
                        pass = item.pass,
                        email = item.e_mail,
                    });
                }
                return Json(new { success = true, content = lstPassenger }, JsonRequestBehavior.AllowGet);
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
        public ActionResult Create(Model.EF.wrt_i_passenger passenger)
        {
            try
            {
                PassengerDao dao = new PassengerDao();
                string id = dao.Insert(passenger);
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, content = "null", message = "Thao tác tải dữ liệu không thành công. Vui lòng thực hiện lại thao tác", log = ex.ToString() });
            }
        }
        [HttpPost]
        public ActionResult Edit(Model.EF.wrt_i_passenger passenger)
        {
            var dao = new PassengerDao();
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
            PassengerDao dao = new PassengerDao();
            var result = dao.Delete(id);
            if (result)
            {
                return Json(new { success = true }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { success = false });
        }
    }
}