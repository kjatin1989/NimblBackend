using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DanielOramTradeMeSimple.Models;

namespace DanielOramTradeMeSimple.Controllers

{


    public class ListingController : Controller
    {

        private static readonly DanielOramsListingViewModel[] Listings = {
                                                                            new DanielOramsListingViewModel {
                                                                                Id = 1,
                                                                                Name = "My Ferrari",
                                                                                Featured = false,
                                                                                StartDate = DateTime.Now,
                                                                                Price = 50000


                                                                            },
                                                                            new DanielOramsListingViewModel {
                                                                                Id = 2,
                                                                                Name = "My House",
                                                                                Featured = true,
                                                                                StartDate = DateTime.Now,
                                                                                Price = 500000


                                                                            }
                                                                        };
        //
        // GET: /Listing/
        public ActionResult Index()
        {
            return View(Listings);
        }

        //
        // GET: /Listing/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Listing/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Listing/Create
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

        //
        // GET: /Listing/Edit/5
        
        public ActionResult Edit(int id)
        {
            var modelToEdit = Listings.Single(model => model.Id == id);
            return View(modelToEdit);
        }

        //TODO: change this back?
        // POST: /Listing/Edit/5
        [HttpPost]
        public ActionResult Edit(DanielOramsListingViewModel model)
        //public ActionResult Edit(int id, FormCollection collection)
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

        //
        // GET: /Listing/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Listing/Delete/5
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
