using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Circle : Shape, IDrawable
    {
        public Circle(string name, string color, int radius) : base(name, color)
        {
            this.radius = radius;
        }

        public int radius { get; set; }

        public void Draw()
        {
            Console.WriteLine($"Малюється {color} {name} з радіусом {radius}");
        }
    }
}
