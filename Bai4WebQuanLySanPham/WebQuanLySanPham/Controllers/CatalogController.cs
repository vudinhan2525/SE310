using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebQuanLySanPham.Models;

namespace WebQuanLySanPham.Controllers
{
    public class CatalogController : Controller
    {
        // GET: Catalog
        public ActionResult Index()
        {
            ProductDataContext context = new ProductDataContext("Data Source=ANDV1710\\SQLEXPRESS;Initial Catalog=quanly;Integrated Security=True;");
            List<Catalog> dsCatalog = context.Catalogs.ToList(); // Ensure this returns a valid list

            // Check if dsCatalog is null
            if (dsCatalog == null)
            {
                // Log the error or handle it accordingly
                return View("Error"); // Redirect to an error view if necessary
            }

            return View(dsCatalog);
        }

    }
}