namespace P02._DrawingShape_Before
{
    using Contracts;
    using P02._DrawingShape_Before.Drawers;
    using System.Collections.Generic;

    class DrawingManager 
    {
        private List<IDrawingManager> drawers = new List<IDrawingManager>()
        {
            new CurcleDrawer(),
            new RectangleDrawer()
        };

        
        public void Draw(IShape shape)
        {
            foreach (var drawer in drawers)
            {
                if (drawer.IsMatch(shape))
                {
                    drawer.Draw(shape);
                }
            }
        }

       
    }
}
