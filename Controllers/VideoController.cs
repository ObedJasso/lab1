using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using MVCPlantilla41.Utilerias;

namespace MvcPlantilla.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            //consultar los datos de la base de datos
            ViewData ["DataVideo"] = BaseHelper.ejecutarConsulta("SELECT * FROM videos", CommandType.Text);
            return View();
        }

    }
}
