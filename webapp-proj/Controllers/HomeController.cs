using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapp_proj.Models;
using Newtonsoft.Json;
using System.Web;
using System.Web.Helpers;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

// keys use to call page 
namespace webapp_proj.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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

        public IActionResult MyCall()
        {
            return View("Test");
        }

        [Route("api/covid")]
        public async Task<IActionResult> CovidApi()
        {
            List<CovidData> dataInfo = new List<CovidData>();
            //Ca Updated
            string url_a = "https://api.opencovid.ca";
            var webRequest_a = WebRequest.Create(url_a) as HttpWebRequest;
            //Province Updated
            string url = "https://api.opencovid.ca/summary";


            var webRequest = WebRequest.Create(url) as HttpWebRequest;

            if (webRequest_a == null && webRequest == null)
            {
                return this.Content(HttpStatusCode.NoContent.ToString());
            }
            //Ca
            webRequest_a.ContentType = "application/json";
            webRequest_a.UserAgent = "Nothing";
            using (var content = webRequest_a.GetResponse().GetResponseStream())
            using (var stream = new StreamReader(content))
            {

                var json = stream.ReadToEnd();
                JObject jsonObject = JObject.Parse(json);
                IList<JToken> result = jsonObject["summary"].ToList();

                var covidData = new CovidData();
                foreach (var item in result)
                {
                    covidData = new CovidData();
                    covidData.Province = Convert.ToString(item["province"]);
                    covidData.Cumulative_Case = Convert.ToInt32(item["cumulative_cases"]);
                    covidData.Cases = Convert.ToInt32(item["cases"]);
                    covidData.ActiveCases = Convert.ToInt32(item["active_cases"]);
                    covidData.ActiveCasesChange = Convert.ToInt32(item["active_cases_change"]);
                    covidData.Cumulative_Deaths = Convert.ToInt32(item["cumulative_deaths"]);
                    covidData.Deaths = Convert.ToInt32(item["deaths"]);
                    covidData.Cumulative_Recovered = Convert.ToInt32(item["cumulative_recovered"]);
                    covidData.Recovered = Convert.ToInt32(item["recovered"]);
                    covidData.Cumulative_Testing = Convert.ToInt32(item["cumulative_testing"]);
                    covidData.Testing = Convert.ToInt32(item["testing"]);
                    covidData.Vaccine_Doses = Convert.ToInt32(item["avaccine"]);
                    covidData.Cumulative_Vaccine_Doses = Convert.ToInt32(item["cumulative_avaccine"]);
                    covidData.P_Vaccinated = Convert.ToInt32(item["cvaccine"]);
                    covidData.Cumulative_Vaccinated = Convert.ToInt32(item["cumulative_cvaccine"]);
                    dataInfo.Add(covidData);
                }
            }
            //Province
            webRequest.ContentType = "application/json";
            webRequest.UserAgent = "Nothing";

            using (var content = webRequest.GetResponse().GetResponseStream())
            using (var stream = new StreamReader(content))
            {

                var json = stream.ReadToEnd();
                JObject jsonObject = JObject.Parse(json);
                IList<JToken> result = jsonObject["summary"].ToList();

                var covidData = new CovidData();
                foreach (var item in result)
                {
                    if (Convert.ToString(item["province"]) != "Repatriated")
                    {
                        covidData = new CovidData();
                        covidData.Province = Convert.ToString(item["province"]);
                        covidData.Cumulative_Case = Convert.ToInt32(item["cumulative_cases"]);
                        covidData.Cases = Convert.ToInt32(item["cases"]);
                        covidData.ActiveCases = Convert.ToInt32(item["active_cases"]);
                        covidData.ActiveCasesChange = Convert.ToInt32(item["active_cases_change"]);
                        covidData.Cumulative_Deaths = Convert.ToInt32(item["cumulative_deaths"]);
                        covidData.Deaths = Convert.ToInt32(item["deaths"]);
                        covidData.Cumulative_Recovered = Convert.ToInt32(item["cumulative_recovered"]);
                        covidData.Recovered = Convert.ToInt32(item["recovered"]);
                        covidData.Cumulative_Testing = Convert.ToInt32(item["cumulative_testing"]);
                        covidData.Testing = Convert.ToInt32(item["testing"]);
                        covidData.Vaccine_Doses = Convert.ToInt32(item["avaccine"]);
                        covidData.Cumulative_Vaccine_Doses = Convert.ToInt32(item["cumulative_avaccine"]);
                        covidData.P_Vaccinated = Convert.ToInt32(item["cvaccine"]);
                        covidData.Cumulative_Vaccinated = Convert.ToInt32(item["cumulative_cvaccine"]);

                        dataInfo.Add(covidData);
                    }
                }
            }

            return View(dataInfo);
        }


    }
}
