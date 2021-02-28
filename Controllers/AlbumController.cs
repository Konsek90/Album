using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Album.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace Album.Controllers
{
    public class AlbumController : Controller
    {
        private readonly AlbumContext _context;

        public AlbumController(AlbumContext context)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("pl-PL");
            _context = context;
        }

        // GET: Album
        public ActionResult Index()
        {
            return View();

        }

        public ActionResult GetTrips()
        {
            var trips = _context.Trips.ToList();
            return Json(trips);
        }

        [HttpPost]
        public ActionResult RemoveTrip(int removeId)
        {
            var trip = _context.Trips.Find(removeId);

            if (trip != null)
            {
                var dir = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "photos", removeId.ToString());

                if (Directory.Exists(dir))
                {
                    var files = Directory.GetFiles(dir);
                    foreach (var f in files)
                    {
                        System.IO.File.Delete(f);
                    }
                    Directory.Delete(dir);
                }

                _context.Remove(trip);
                _context.SaveChanges();

                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public ActionResult AddTrip(Trip model)
        {
            if (model != null && ModelState.IsValid)
            {
                if (model.Start > model.End)
                {
                    return BadRequest();
                }

                _context.Trips.Add(model);
                _context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }


        // GET: Album/Details/5
        public ActionResult Details(int id)
        {
            var model = _context.Trips.Find(id);

            if (model == null)
            {
                return BadRequest();
            }

            var dir = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "photos", id.ToString());

            if (Directory.Exists(dir))
            {
                model.Photos = Directory.GetFiles(dir).Select(s => Path.GetFileName(s));
            }

            return View(model);
        }

        // GET: Album/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Album/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Album/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Album/Edit/5
        [HttpPost]
        public ActionResult EditTrip(Trip model)
        {
            if (model != null && ModelState.IsValid)
            {
                if (model.Start > model.End)
                {
                    return BadRequest();
                }

                var trip = _context.Trips.Find(model.Id);

                if (trip == null)
                {
                    return BadRequest();
                }

                trip.Name = model.Name;
                trip.Start = model.Start;
                trip.End = model.End;
                trip.Place = model.Place;
                _context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        // GET: Album/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Album/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public async Task<ActionResult> UploadPhoto(UploadPhotoViewModel model)
        {
            if (model != null && model.Photo != null && model.Photo.Length > 0)
            {
                var dir = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "photos", model.WycieczkaId.ToString());


                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                var path = Path.Combine(dir, model.Photo.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await model.Photo.CopyToAsync(stream);
                }
            }

            return RedirectToAction("Details", new { id = model.WycieczkaId });
        }

        [HttpPost]
        public ActionResult DeletePhoto(DeletePhotoViewModel model)
        {
            if (model != null && !string.IsNullOrEmpty(model.PhotoName))
            {
                var dir = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "photos", model.Idwycieczka.ToString(), model.PhotoName);

                if (!Directory.Exists(dir))
                {
                    System.IO.File.Delete(dir);
                }
            }

            return RedirectToAction("Details", new { id = model.Idwycieczka });
        }
    }
}