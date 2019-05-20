using Model.Dao;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WTR.Areas.Admin.Controllers
{
    public class EmpController : Controller
    {
        // GET: Admin/Emp
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetData()
        {
            try
            {
                var dao = new EmployerDao();
                List<wrt_i_employer> lst = dao.getAll().ToList();
                List<object> lstemp = new List<object>();
                foreach (wrt_i_employer item in lst)
                {
                    lstemp.Add(new
                    {
                        id_employer = item.id_employer,
                        name = item.name,
                        phone = item.phone,
                        pass = item.pass,
                        e_mail = item.e_mail,
                        flag = item.flag,
                    });
                }
                return Json(new { success = true, content = lstemp }, JsonRequestBehavior.AllowGet);
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
        public ActionResult Create(wrt_i_employer emp)
        {
            try
            {
                EmployerDao dao = new EmployerDao();
                string id = dao.Insert(emp);
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, content = "null", message = "Thao tác tải dữ liệu không thành công. Vui lòng thực hiện lại thao tác", log = ex.ToString() });
            }
        }
        [HttpPost]
        public ActionResult Edit(wrt_i_employer emp)
        {
            var dao = new EmployerDao();
            var result = dao.Update(emp);
            if (result)
            {
                return Json(new { success = true, content = emp }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { success = false, content = "null", message = "Thao tác tải dữ liệu không thành công. Vui lòng thực hiện lại thao tác" }, JsonRequestBehavior.AllowGet);
            }

        }
        public ActionResult Delete(wrt_i_employer id)
        {
            EmployerDao dao = new EmployerDao();
            var result = dao.Delete(id);
            if (result)
            {
                return Json(new { success = true }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { success = false });
        }
    }
}