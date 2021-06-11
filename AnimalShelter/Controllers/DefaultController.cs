 [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        string[] authors = new string[]
        { "Jamie Knutsen" };
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return authors;
        }
    }