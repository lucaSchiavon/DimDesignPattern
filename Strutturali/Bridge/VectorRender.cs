using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Strutturali.Bridge
{
    class VectorRender : IRender
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"drawing a circle of radius {radius}");
        }
    }
}
