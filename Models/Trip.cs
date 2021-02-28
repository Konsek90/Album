using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Album.Models
{
    public class Trip
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime Start { get; set; }
        [Required]
        public DateTime End { get; set; }
        [Required]
        public string Place { get; set; }

        [NotMapped]
        public IEnumerable<string> Photos { get; set; }

        public Trip()
        {

        }

        public Trip(string name, DateTime start, DateTime end, string place)
        {
            Name = name;
            Start = start;
            End = end;
            Place = place;
        }
    }
}
