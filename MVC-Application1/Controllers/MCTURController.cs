using MVC_Application1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Application1.Controllers
{
    public class MCTURController : Controller
    {
        // GET: MCTUR
        public ActionResult Index()
        {
            MCTURClass1 obj = new MCTURClass1();
            obj.edad = 29;
            obj.nombre = "Alejandro";
            obj.apellido = "Reyes";
            return View(obj);
        }
    }
}