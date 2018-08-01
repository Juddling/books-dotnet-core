using System.Collections.Generic;
using dotnet.Database;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace dotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController: ControllerBase
    {
        private readonly BooksContext _context;
        
        public BooksController(BooksContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public ActionResult<List<Book>> GetAll()
        {
            return _context.Books.ToList();
        }
    }
}