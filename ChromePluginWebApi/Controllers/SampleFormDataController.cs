using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ChromePluginWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleFormDataController : ControllerBase
    {

        private readonly ILogger<SampleFormDataController> _logger;

        public SampleFormDataController(ILogger<SampleFormDataController> logger)
        {
            _logger = logger;
        }

        [EnableCors]
        [HttpGet]
        public IEnumerable<int> Get(int value)
        {
            return new List<int>() { value, value + 1, value + 2 };
        }

        [EnableCors]
        [HttpGet]
        [Route("book")]
        public Book GetBook()
        {
            return new Book()
            {
                Title = "The Cat in the Hat",
                Author = "Dr. Seuss",
                Pages = "48"
            };
        }
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Pages { get; set; }

        }

    }



}
