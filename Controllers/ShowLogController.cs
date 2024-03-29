using Lab1sharp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace Lab1sharp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShowLogController : ControllerBase
    {

        public IActionResult Decode()
        {
            string logContent = System.IO.File.ReadAllText("Logs.txt");
            return Ok(logContent);
        }

        [HttpGet]
        [Route("/ClearLog")]
        public IActionResult ClearLog()
        {
            System.IO.File.WriteAllText("Logs.txt", string.Empty);

            return Ok("Log cleared!");
        }
    }
}
