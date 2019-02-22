using MongoDB.Driver;
using Semana05.Collections;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Semana05.Controllers
{
    public class AnimalsController : Controller
    {

        public AnimalsController()
        {
            var server = new MongoClient(ConfigurationManager.AppSettings.Get("mongoConnection"));

            var database = server.GetDatabase(ConfigurationManager.AppSettings.Get("veterinaria"));

            var animales = database.GetCollection<Animals>("animals");
        }
        // GET: Animals
        public ActionResult Index()
        {
            return View();
        }

        // GET: Animals/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Animals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Animals/Create
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

        // GET: Animals/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Animals/Edit/5
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

        // GET: Animals/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Animals/Delete/5
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
