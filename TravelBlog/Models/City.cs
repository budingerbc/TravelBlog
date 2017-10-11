using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBlog.Models
{
    [Table("Cities")]
    public class City
    {
        [Key]
        public int CityId { get; set; }
        public string Name { get; set; }
    }
}
