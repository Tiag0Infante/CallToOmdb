using CallToOmdb.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Security.Principal;
using System.Text.Json.Serialization;

namespace CallToOmdb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
       

        public async Task<IActionResult> Index()
        {
            // Retrieve the stored movie info from TempData
            //var movieInfo = TempData["MovieInfo"] as ResponseModel;

            // Pass the movie info to the Index view
            //return View(movieInfo);
            var test = "slkdjaslkdja";
            var populateModel = await RequestToOmdb();
            return View(populateModel);
        }
        [HttpPost]
        public async Task<ResponseModel> RequestToOmdb()
        {
            //var options = new RestClientOptions("")
            //{
            //    MaxTimeout = -1,
            //};
            //var client = new RestClient(options);
            var client = new RestClient();
            var request = new RestRequest("http://www.omdbapi.com/?apikey=111c6692&t=brian", Method.Post);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
            var populateModel = JsonConvert.DeserializeObject<ResponseModel>(response.Content);


            // Redirect to the Index action
            return populateModel;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
