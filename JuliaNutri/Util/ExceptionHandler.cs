using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace JuliaNutri.Util
{
    public static class ExceptionHandler
    {
        public static IActionResult HandleException(this ControllerBase controller, Exception exc)
        {
            return exc switch
            {
                _ => controller.StatusCode((int)HttpStatusCode.InternalServerError, exc.Message)
            };
        }
    }
}
