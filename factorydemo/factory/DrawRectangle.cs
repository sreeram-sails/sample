using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorydemo.factory
{
    class DrawRectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw Rectangle");
        }
    }
}
