using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using Model.EF;
namespace WTR.Areas.Admin.Controllers
{
    public class DriverController : Controller
    {
        // GET: Admin/Driver
        public ActionResult Index(string searchString, int page = 1, int pageSize = 3)
        {
            var dao = new DriverDao();
            var model = dao.ListAllPaging(searchString, page, pageSize);
            ViewBag.SearchString = searchString;
            return View(model);
        }
        [HttpGet]
        public ActionResult GetData(int page = 1, int pageSize = 3)
        {
            try
            {
                var dao = new DriverDao();
                List<wrt_i_driver> lst = dao.getAll(page, pageSize).ToList();
                List<object> lstDriver = new List<object>();
                foreach (wrt_i_driver item in lst)
                {
                    lstDriver.Add(new
                    {
                        id_driver = item.id_driver,
                        name = item.name,
                        birth = item.birth,
                        add = item.add,
                        note = item.note,
                        flag = item.flag,
                        phone = item.phone,
                    });
                }
                return Json(new { success = true, content = lstDriver }, JsonRequestBehavior.AllowGet);
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
        public ActionResult Create(wrt_i_driver driver)
        {
            try
            {
                DriverDao dao = new DriverDao();
                string id = dao.Insert(driver);
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, content = "null", message = "Thao tác tải dữ liệu không thành công. Vui lòng thực hiện lại thao tác", log = ex.ToString() });
            }
        }
        [HttpPost]
        public ActionResult Edit(wrt_i_driver driver)
        {
            var dao = new DriverDao();
            var result = dao.Update(driver);
            if (result)
            {
                return Json(new { success = true, content = driver }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { success = false, content = "null", message = "Thao tác tải dữ liệu không thành công. Vui lòng thực hiện lại thao tác" }, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult Delete(wrt_i_driver driver)
        {

            var dao = new DriverDao();
            var result = dao.Delete(driver);
            if (result)
            {
                return Json(new { success = true }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { success = false });
        }
    }
}