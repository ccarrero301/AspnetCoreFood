using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreFood.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController : Controller
    {
        public string Phone()
        {
            return "1+555+555+555";
        }

        public string Address()
        {
            return "USA";
        }
    }
}