using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;

namespace FizzBuzz.MVC.Models
{
    public class FizzBuzzViewModel
    {
        [Range(1, 1000)]
        [Required]
        [DisplayName("Value")]
        public int UserPosition { get; set; }
        public IPagedList<String> FizzBuzzNumbers { get; set; }
    }
}
