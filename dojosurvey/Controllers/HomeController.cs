using Microsoft.AspNetCore.Mvc;
    namespace dojosurvey.Controllers     
    {
        public class HomeController : Controller   
        {
            [HttpGet]       
            [Route("")]     
            public ViewResult  Index()
            {
                
                return View();
            }
            
            
            
            
            [HttpPost]
            [Route("process")]
            public IActionResult process(string name,string location,string Languages,string description)
            {
                ViewBag.Name=name;
                ViewBag.location=location;
                ViewBag.language=Languages;
                ViewBag.description=description;

                
                return View("Result");
            }
            
            
                        
        }
    }