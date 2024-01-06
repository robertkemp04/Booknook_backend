using FullStackAuth_WebAPI.Data;
using FullStackAuth_WebAPI.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Bcpg;
using System.Web.Providers.Entities;

namespace FullStackAuth_WebAPI.Controllers
{
    public class ReviewsController : Controller
    {

        private readonly ApplicationDbContext db;
        // POST api/cars
        [HttpPost, Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult Post([FromBody] Review review)
        {
            var loggedInUser = User.Identity.Name;
            db.Add(review);

            review.UserId = loggedInUser;

            db.SaveChanges();

            return StatusCode(201, review);
        }
    }
}
