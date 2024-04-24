using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Shape
    {
        public Shape(string name, string color) 
        {
            this.name = name;
            this.color = color;
        }

        public string name { get; set; }
        public string color { get; set; }
    }
}
