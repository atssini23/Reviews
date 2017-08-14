using System;
using System.ComponentModel.DataAnnotations;
namespace Rest.Models
{
    public class Review : BaseEntity

    {
        public int ReviewId { get; set; }
        public string ReviewerName { get; set; }
        public string RestaurantName { get; set; }
        public string Context { get; set; }
        public int Stars { get; set; }
        public DateTime Vistit { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}