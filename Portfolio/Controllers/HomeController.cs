using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Setup.Initialize();
            ViewBag.Title = "Adam Kaufman's Portfolio";
            return View();
        }

        [ValidateInput(false)]
        public string GetProjectData(string projectType, int index)
        {
            List<string> returnArray = new List<string>();
            switch (projectType)
            {
                case "ProfessionalWork":
                    returnArray.Add(Setup.ProfessionalWork[index].Name);
                    returnArray.Add(Setup.ProfessionalWork[index].Description);
                    returnArray.AddRange(Setup.ProfessionalWork[index].MediaRefs);
                    break;
                case "AppDevelopment":
                    returnArray.Add(Setup.AppDevelopment[index].Name);
                    returnArray.Add(Setup.AppDevelopment[index].Description);
                    returnArray.AddRange(Setup.AppDevelopment[index].MediaRefs);
                    break;
                case "WebDevelopment":
                    returnArray.Add(Setup.WebDevelopment[index].Name);
                    returnArray.Add(Setup.WebDevelopment[index].Description);
                    returnArray.AddRange(Setup.WebDevelopment[index].MediaRefs);
                    break;
                case "Design":
                    returnArray.Add(Setup.Design[index].Name);
                    returnArray.Add(Setup.Design[index].Description);
                    returnArray.AddRange(Setup.Design[index].MediaRefs);
                    break;
                default:
                    return "{}";
            }

            return JsonConvert.SerializeObject(returnArray.ToArray(), Formatting.Indented);
        }
    }
}