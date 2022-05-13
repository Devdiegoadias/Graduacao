using Microsoft.AspNetCore.Mvc;
using RedeSocial.CrossCutting;

namespace RedeSocial.Web.Controllers
{
    public class UploadController : Controller
    {
        private AzureStorage azurestorage { get; set; }

        public UploadController(AzureStorage azureStorage)
        {
            this.azurestorage = azureStorage;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] IFormFile file)
        {
            var ms = new MemoryStream();


            using (var fileUpload = file.OpenReadStream())
            {
                await fileUpload.CopyToAsync(ms);
                fileUpload.Close();
            }

            ms.Position = 0;
            var url = await azurestorage.Save(ms, "TESTE" + Guid.NewGuid().ToString() + ".jpg");

            ViewBag.UrlGerada = url;

            return View();
        }

        public IActionResult Create()
        {
            return View();
        }


    }
}
