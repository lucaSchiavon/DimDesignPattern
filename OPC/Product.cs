using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.OPC
{
    public enum Color
    { 
        Red,Green,Blue
    }
    public enum Size
    { 
        Small,Medium,Large,Yuge
    }
    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;

        public Product(string name, Color color, Size size)
        {
            Name = name;
            Color = color;
            Size = size;
        }
    }
}
