using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class bookapi
    {
        public int id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [RegularExpression(@"^\d+(,\d{1,2})?$")]
        public string Price { get; set; }
    }
}
