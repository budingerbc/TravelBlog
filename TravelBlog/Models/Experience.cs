using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TravelBlog.Models;


namespace TravelBlog.Models
{
    [Table("Experiences")]
    public class Experience
    {
        public Experience()
        {
            this.People = new HashSet<People>();
        }

        [Key]
        public int ExperienceId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int LocationId { get; set; }
        public virtual ICollection<People> People { get; set; }
        public virtual Location Locations { get; set; }
    }

}
