using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Strutturali.Bridge
{
    public abstract class Shape
    {
        protected IRender renderer;
        //il bridge...tra la forma ed il componente che la traccia
        public Shape(IRender renderer)
        {
            this.renderer = renderer;
        }

        public abstract void Draw();
        public abstract void Resize(float factor);

    }
}
