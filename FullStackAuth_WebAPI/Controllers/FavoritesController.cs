using FullStackAuth_WebAPI.Data;
using FullStackAuth_WebAPI.DataTransferObjects;
using FullStackAuth_WebAPI.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Claims;


namespace FullStackAuth_WebAPI.Controllers
{
    public class FavoritesController : Controller
    {
        private readonly ApplicationDbContext db;

        [HttpGet, Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult Get()
        {
            var reviews = db.Books.ToList();
            return Ok(reviews);
        }

        [HttpPost, Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult Post([FromBody] Favorite favorites)
        {
            var loggedInUser = User.Identity.Name;
            db.Add(favorites);

            favorites.UserId = loggedInUser;

            db.SaveChanges();

            return StatusCode(201, favorites);
        }
    }
}
