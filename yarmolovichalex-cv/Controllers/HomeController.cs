using System.Web.Mvc;

namespace yarmolovichalex_cv.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public FileResult DownloadCV()
        {
            string path = Server.MapPath("~//CV/cv.docx");
            return File(path, "application/vnd.openxmlformats-officedocument.wordprocessingml.document", "cv.docx");
        }
	}
}