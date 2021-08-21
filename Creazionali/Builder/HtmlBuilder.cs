using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Creazionali.Builder
{
    class HtmlBuilder
    {
        protected readonly string RootName;
        protected HtmlElement root = new HtmlElement();
//https://www.infoworld.com/article/3606436/how-to-use-implicit-and-explicit-operators-in-csharp.html
        public static implicit operator HtmlElement(HtmlBuilder builder)
        {
            return builder.root;
        }
        public HtmlBuilder(string rootName)
        {
            RootName = rootName;
            root.name = rootName;
        }

        public HtmlBuilder AddChild(string childName, string childtext)
        {
            var e = new HtmlElement(childName, childtext);
            root.Elements.Add(e);
            return this;
        }

        public HtmlElement Build()
        {
            return root;
        }
        public override string ToString()
        {
            return root.ToString();
        }
    }
}
