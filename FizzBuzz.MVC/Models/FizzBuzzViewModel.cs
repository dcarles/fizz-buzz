using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.MVC.Models
{
    public class FizzBuzzViewModel
    {
        [Range(1, 1000)]
        [Required]
        public int UserPosition { get; set; }
        public List<String> FizzBuzzNumbers { get; set; }
    }
}
