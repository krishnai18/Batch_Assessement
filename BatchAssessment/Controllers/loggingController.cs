//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Logging;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace BatchAssessment.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class loggingController : ControllerBase
//    {
//        private readonly ILogger _logger;

//        public loggingController(ILoggerFactory logFactory)
//        {
//            _logger = logFactory.CreateLogger<loggingController>();
//        }

//        public IActionResult Index()
//        {
//            _logger.LogInformation("Log message in the Index() method");

//            return Index();
//        }

//        public IActionResult About()
//        {

//            _logger.LogInformation("Log message in the About() method");

//          return About();
//        }
//    }
//}
