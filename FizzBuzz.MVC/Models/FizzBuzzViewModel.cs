using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.MVC.Models
{
    public class FizzBuzzViewModel
    {
        public int UserPosition { get; set; }
        public List<String> FizzBuzzNumbers { get; set; }
    }
}
