using FullStackAuth_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace FullStackAuth_WebAPI.DataTransferObjects
{
    public class BookDetailsDto : Favorite
    {
        public int Id {  get; set; }
        public string BookId { get; set; }
        public string Title { get; set; }
        public string ThumbnailUrl { get; set; }
        public string User { get; set; }
    }
}
