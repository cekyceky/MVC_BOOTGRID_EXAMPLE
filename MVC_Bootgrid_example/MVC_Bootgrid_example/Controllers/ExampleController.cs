using MVC_Bootgrid_example.Models;
using MVC_Bootgrid_example.Models.Bootgrid;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.Mvc;

namespace MVC_Bootgrid_example.Controllers
{
    public class ExampleController : Controller
    {
        // GET: Example
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public JsonResult GetMyGrid(RequestData model)
        {

            var contacts = new List<Contact>
            {
                new Contact
                {
                    id = 1,
                    name = "Bruno",
                    address = "Lisbon, Portugal",
                    birthday = DateTime.ParseExact("05/06/1990","dd/MM/yyyy",CultureInfo.InvariantCulture).ToString("dd/MM/yyyy"),
                    isSelected = false
                },
                 new Contact
                {
                    id = 2,
                    name = "Martin",
                    address = "New York, USA",
                    birthday = DateTime.ParseExact("17/08/1976","dd/MM/yyyy",CultureInfo.InvariantCulture).ToString("dd/MM/yyyy"),
                    isSelected = true
                },
                 new Contact
                {
                    id = 3,
                    name = "Maria",
                    address = "Cancun, Mexico",
                    birthday = DateTime.ParseExact("09/11/1998","dd/MM/yyyy",CultureInfo.InvariantCulture).ToString("dd/MM/yyyy"),
                    isSelected = false
                }
            };

            var tResult = new ResponseData<List<Contact>>()
            {
                current = model.current,
                rowCount = model.rowCount,
                rows = contacts,
                total = contacts.Count
            };
            // Then return the response with data...
            return Json(tResult, JsonRequestBehavior.AllowGet);
        }
    }
}