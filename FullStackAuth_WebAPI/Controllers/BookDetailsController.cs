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
    public class BookDetailsController : Controller
    {

        private readonly ApplicationDbContext db;

        public BookDetailsController(ApplicationDbContext context)
        {
            db = context;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var book = db.Books.Find(id);

            int sumOfRatings = 0;

            foreach (var review in book.Ratings)
            {
                sumOfRatings += review.Rating;
            }
            double averagerating = book.Ratings.count > 0 ? (double)sumOfRatings / book.Ratings.count : 0;



            return Ok(book);
        }

    }
}
