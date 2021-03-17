using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCoreMoviesAPI.Models
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        public int Mid { get; set; }
        public string Mname { get; set; }
        public string StarCast { get; set; }
        public string Producer { get; set; }
        public string Director { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
