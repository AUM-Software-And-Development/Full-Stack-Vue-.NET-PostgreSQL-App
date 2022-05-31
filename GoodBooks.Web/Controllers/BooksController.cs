using Microsoft.AspNetCore.Mvc;

namespace GoodBooks.Web.Controllers;

[ApiController]
public class BooksController : ControllerBase
{
    private readonly ILogger<BooksController> _logger;

    public BooksController(ILogger<BooksController> logger) {
        _logger = logger;
    }

    [HttpGet("/api/books")]
    public ActionResult Get() {
        return Ok("Books");
    }
}
