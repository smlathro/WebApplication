using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISPApplication.Controllers
{
    public class CSVFileController : Controller
    {
        // GET: CSVFile
        public ActionResult Index()
        {
            return View();
        }

        // GET: CSVFile/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CSVFile/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CSVFile/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CSVFile/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CSVFile/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CSVFile/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CSVFile/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
