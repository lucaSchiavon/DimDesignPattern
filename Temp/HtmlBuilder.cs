using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Temp
{
    public class HtmlBuilder
    {
        protected readonly string rootName;
        public HtmlElement root = new HtmlElement();

        public HtmlBuilder(string rootName)
        {
            this.rootName = rootName;
            root.name = rootName;
        }

        public HtmlBuilder AddChild(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            root.Elements.Add(e);
            return this;
        }

        public override string ToString() => root.ToString();
    }
}
