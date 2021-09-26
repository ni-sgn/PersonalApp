using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly Services.Repository.IRepository _repository;

        public BooksController(ILogger<WeatherForecastController> logger, Services.Repository.IRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<DAL.Entities.Books> Books()
        {
            IEnumerable<DAL.Entities.Books> books = _repository.GetAllBooks();
            return books;
        }
    }
}
