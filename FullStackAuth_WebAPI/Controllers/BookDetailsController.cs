using FullStackAuth_WebAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace FullStackAuth_WebAPI.Controllers
{
    public class BookDetailsController
    {

        private readonly ApplicationDbContext db;

        [HttpGet({"id")]
        public IActionResult Get(int id)
        {
            var book = db.Books.Find(id);
        }
    }
}
