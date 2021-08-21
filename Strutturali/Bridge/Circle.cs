using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Strutturali.Bridge
{
    public class Circle : Shape
    {
        private float radius;
        public Circle(IRender renderer,float radius)
            :base(renderer)
        {
            this.radius = radius;
        }
        public override void Draw()
        {
            renderer.RenderCircle(radius);
        }

        public override void Resize(float factor)
        {
            radius *= factor;
        }

    }
}
