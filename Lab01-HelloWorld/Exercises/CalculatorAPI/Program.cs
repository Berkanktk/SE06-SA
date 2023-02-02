using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;

namespace CalculatorAPI
{
    [Route("api/calculator/{operator}/{number1}/{number2}")]
    public class CalculatorApi : Controller
    {
        [HttpGet]
        public IActionResult Calculate(string @operator, double number1, double number2)
        {
            double result;
            switch (@operator)
            {
                case "add":
                    result = number1 + number2;
                    break;
                case "subtract":
                    result = number1 - number2;
                    break;
                case "multiply":
                    result = number1 * number2;
                    break;
                case "divide":
                    result = number1 / number2;
                    break;
                default:
                    return BadRequest("Invalid operator.");
            }

            return Ok(result);
        }

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
// EXAMPLES
// GET http://localhost:5000/api/calculator/add/2/5
// GET http://localhost:5000/api/calculator/subtract/8/4
// GET http://localhost:5000/api/calculator/multiply/3/6
// GET http://localhost:5000/api/calculator/divide/10/2