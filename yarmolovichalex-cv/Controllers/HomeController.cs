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
            return File(@"/CV/cv.docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document", "cv.docx");
        }
	}
}