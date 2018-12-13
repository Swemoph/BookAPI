using BookAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : Controller
    {

        // GET: api/values
        [HttpGet]
        public string Get()
        {
            Book[] collection = BookCollection.BookArray;
            return JsonConvert.SerializeObject(collection, Formatting.Indented);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            Book returnedBook = BookCollection.GetBook(id);
            string bookJson = JsonConvert.SerializeObject(returnedBook, Formatting.Indented);

            return bookJson;
        }
    }
}
