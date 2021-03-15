using P02._DrawingShape_Before.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P02._DrawingShape_Before.Drawers
{
    public class CurcleDrawer : IDrawingManager
    {
        public void Draw(IShape shape)
        {
            Console.WriteLine("drawing Curcle");
        }

        public bool IsMatch(IShape shape)
        {
            return shape is Circle;
        }
    }
}
