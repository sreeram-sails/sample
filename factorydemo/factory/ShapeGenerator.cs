using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorydemo.factory
{
    class ShapeGenerator
    {
        public  IShape GetShape(string shapeType)
        {
            if(shapeType==null)
            {
                return null;
            }
            if(shapeType=="CIRCLE")
            {
                return new DrawCircle();
            }
            if (shapeType == "SQUARE")
            {
                return new DrawSquare();
            }
            if (shapeType == "RECTANGLE")
            {
                return new DrawRectangle();
            }
            return null;
        }
    }
}
