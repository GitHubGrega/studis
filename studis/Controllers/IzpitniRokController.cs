﻿using studis.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace studis.Controllers
{
    [Authorize(Roles = "Profesor, Referent")]
    public class IzpitniRokController : Controller
    {
        public studisEntities db = new studisEntities();

        public ActionResult Index()
        {
            return View();
        }

        //GET: IzpitniRok/Dodaj
        public ActionResult Dodaj()
        {
            List<predmet> temp = db.predmets.OrderBy(a => a.ime).ToList();
            
            List<SelectListItem> predmeti = new List<SelectListItem>();
            foreach(predmet i in temp) {
                SelectListItem p = new SelectListItem();
                p.Value = i.id.ToString();
                p.Text = Convert.ToInt32(p.Value).ToString("000") + " - " + i.ime + " (" + i.koda + ")";
                predmeti.Add(p);
            }
            List<SelectListItem> ltemp = new List<SelectListItem>();
            ltemp.Add(new SelectListItem() { Value="", Text="Izbira profesorja" });
            ViewBag.Prazen = new SelectList(ltemp, "Value", "Text");
            ViewBag.Predmets = new SelectList(predmeti, "Value", "Text");
            //new SelectList(db.sifrant_studijskiprogram.OrderBy(a => a.naziv), "id", "naziv");
            //IzpitniRokModel model= new IzpitniRokModel();
            return View();
        }

        // POST: IzpitniRok/Dodaj
        [HttpPost]
        public ActionResult Dodaj(IzpitniRokModel model)
        {
            izpitnirok izpitniRok = new izpitnirok();
            izpitniRok.datum = UserHelper.StringToDate(model.datum);
            izpitniRok.predmet = db.predmets.SingleOrDefault(v => v.id == model.predmet);
            //izpitniRok.profesor = db.profesors.SingleOrDefault(p => p.id == model.profesor);
            try
            {
                // TODO: Add insert logic here
                db.izpitniroks.Add(izpitniRok);
                db.SaveChanges();
                return View("UspesnoDodan");
            }
            catch
            {
                return View();
            }
        }

        // GET: IzpitniRok/Edit
        public ActionResult Edit()
        {
            List<predmet> temp = db.predmets.OrderBy(a => a.ime).ToList();

            List<SelectListItem> predmeti = new List<SelectListItem>();
            foreach (predmet i in temp)
            {
                SelectListItem p = new SelectListItem();
                p.Value = i.id.ToString();
                p.Text = Convert.ToInt32(p.Value).ToString("000") + " - " + i.ime + " (" + i.koda + ")";
                predmeti.Add(p);
            }
            List<SelectListItem> ltemp = new List<SelectListItem>();
            ltemp.Add(new SelectListItem() { Value = "", Text = "Izbira" });
            ViewBag.Prazen = new SelectList(ltemp, "Value", "Text");
            ViewBag.Predmets = new SelectList(predmeti, "Value", "Text");
            return View();
        }

        // POST: IzpitniRok/Edit
        [HttpPost]
        public ActionResult Edit(IzpitniRokModel model)
        {

            try
            {
                // TODO: Add update logic here
                var rok = db.izpitniroks.SingleOrDefault(r => r.id == model.id);
                rok.datum = UserHelper.StringToDate(model.datum);
                //rok.predmet = db.predmets.SingleOrDefault(v => v.id == model.predmet);
                db.SaveChanges();
                return View("UspesnoSpremenjen");
            }
            catch
            {
                return View();
            }
        }

        // GET: IzpitniRok/Delete/5
        public ActionResult Izbrisi()
        {
            List<predmet> temp = db.predmets.OrderBy(a => a.ime).ToList();

            List<SelectListItem> predmeti = new List<SelectListItem>();
            foreach (predmet i in temp)
            {
                SelectListItem p = new SelectListItem();
                p.Value = i.id.ToString();
                p.Text = Convert.ToInt32(p.Value).ToString("000") + " - " + i.ime + " (" + i.koda + ")";
                predmeti.Add(p);
            }
            List<SelectListItem> ltemp = new List<SelectListItem>();
            ltemp.Add(new SelectListItem() { Value = "", Text = "Izbira" });
            ViewBag.Prazen = new SelectList(ltemp, "Value", "Text");
            ViewBag.Predmets = new SelectList(predmeti, "Value", "Text");
            return View();
        }

        // POST: IzpitniRok/Delete/5
        [HttpPost]
        public ActionResult Izbrisi(int id)
        {
            try
            {
                // TODO: Add delete logic here
                db.izpitniroks.Remove(db.izpitniroks.SingleOrDefault(r => r.id == id));
                db.SaveChanges();
                return View("UspesnoIzbrisan");
            }
            catch
            {
                return View();
            }
        }

        public string GetProfesorsForPredmet(int id)
        {
            
            int iid = Convert.ToInt32(id);
            List<profesor> profesors;
            try
            {
                profesors = db.predmets.SingleOrDefault(v => v.id == iid).profesors.ToList();
            } catch {
                //Debug.WriteLine("GetProfesorsForPredmet/" + id + "prazen seznam!");
                profesors = new List<profesor>();
            }
            var seznamProfesorjev = new List<SelectListItem>();
            int c = 0;
            foreach (profesor p in profesors)
            {
                c++;
                seznamProfesorjev.Add(new SelectListItem() { Value = p.id.ToString(), Text = (p.ime + " " + p.priimek) });
            }
            if (c < 1)
            {
                seznamProfesorjev.Add(new SelectListItem() { Value = "0", Text = "Ta predmet nima nosilca." });
            }
            /*
            var seznam = new List<SelectListItem>();
            Random rand= new Random();
            for(int i = 0; i< 5; i++) {
                seznam.Add(new SelectListItem() { Value = i.ToString(), Text = rand.Next(i, 100).ToString() });
            }
            */
            return new JavaScriptSerializer().Serialize(seznamProfesorjev);
        }

        public string GetIzpitniRoksForPredmet(int id)
        {
            /*
             * TO DO TO DO TO DO TO DO TO DO TO DO
             */
            Debug.WriteLine("ID " + id);
            int iid = Convert.ToInt32(id);
            Debug.WriteLine("ID " + iid);
            var pPredmet = db.predmets.SingleOrDefault(p => p.id == iid);
            var izpitniRoki = pPredmet.izpitniroks.ToList(); //Exception 
            var seznamIzpitniRoki = new List<SelectListItem>();
            int c = 0;
            foreach (izpitnirok i in izpitniRoki)
            {
                c++;
                string profesorji= "";
                foreach(profesor p in pPredmet.profesors) {
                    profesorji += " " + p.ime + " " + p.priimek + ",";
                }
                seznamIzpitniRoki.Add(new SelectListItem() { Value = i.id.ToString(), Text = (UserHelper.DateToString(i.datum) + " -" + profesorji) });
            }
            if (c < 1)
            {
                seznamIzpitniRoki.Add(new SelectListItem() { Value = "", Text = "Ta predmet nima razpisanih rokov." });
            }
            return new JavaScriptSerializer().Serialize(seznamIzpitniRoki);
        }

        public string GetDatumForIzpitniRok(int id)
        {
            /*
             * TO DO TO DO TO DO TO DO TO DO TO DO
             */
            int iid = Convert.ToInt32(id);
            var datum = db.izpitniroks.SingleOrDefault(r => r.id == iid).datum;
            return UserHelper.DateToString(datum);
        }

        public JsonResult PreveriDatum(string datum)
        {
            Debug.WriteLine("datum: " + datum);
            DateTime d = UserHelper.StringToDate(datum);
            Debug.WriteLine("Datum: " + d);
            var result = Validate.veljavenDatum(d);
            if (d < DateTime.Today)
            {
                result = false;
            }
            return Json(result);
        }

        public JsonResult PreveriIzpitniRok(int id)
        {
            var steviloOcen = db.izpitniroks.SingleOrDefault(r => r.id == id).ocenas.Count;
            var result = true;
            if (steviloOcen > 0)
            {
                result = false;
            }
            return Json(result);
        }
    }
}
