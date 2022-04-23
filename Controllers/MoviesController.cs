using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MODUL8_1302201132.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private static List<Movie> Movies = new List<Movie>()
        {
            new Movie("The Shawshank Redemption", "Frank Darabont", new List<string>(){"Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler" }, "wo imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."),
            new Movie("The Godfather", "Francis Ford Coppola", new List<string>(){ "Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton "}, "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."),
            new Movie("The Dark Knight", "Christopher Nolan", new List<string>(){ "Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine"}, "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice."),
        };
        // GET: api/<MoviesController>
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return Movies;
        }

        // GET api/<MoviesController>/5
        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return Movies[id];
        }

        // POST api/<MoviesController>
        [HttpPost]
        public void Post([FromBody] Movie value)
        {
            Movies.Add(value);
        }

        // DELETE api/<MoviesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Movies.RemoveAt(id);
        }
    }
}
