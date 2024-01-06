﻿using FullStackAuth_WebAPI.Models;

namespace FullStackAuth_WebAPI.DataTransferObjects
{
    public class ReviewWithUserDto : Review
    {
        public int Id { get; set; }
        public string BookId { get; set; }
        public string Text { get; set; }
        public double Rating { get; set; }
        public string UserId { get; set; }
        public string User { get; set; }
    }
}
