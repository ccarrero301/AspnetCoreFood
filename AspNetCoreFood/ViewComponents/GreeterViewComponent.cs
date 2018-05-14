using AspNetCoreFood.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreFood.ViewComponents
{
    public class GreeterViewComponent : ViewComponent
    {
        private readonly IGreeter _greeter;

        public GreeterViewComponent(IGreeter greeter)
        {
            _greeter = greeter;
        }

        public IViewComponentResult Invoke()
        {
            var model = _greeter.GetMessageOfTheDay();

            return View("Default", model);
        }
    }
}
