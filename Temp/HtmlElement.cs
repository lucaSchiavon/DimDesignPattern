using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Temp
{
    public class HtmlElement
    {
        public string name, text;
        public List<HtmlElement> Elements = new List<HtmlElement>();

        public HtmlElement() { }
        public HtmlElement(string name, string text)
        {
            this.name = name;
            this.text = text;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(GetTag(this));
            Elements.ForEach(x =>
            {

                sb.Append(GetTag(x));

            });

            return sb.ToString();
        }

        public static HtmlBuilder Create(string name) => new HtmlBuilder(name);

        private string GetTag(HtmlElement Element)
        {
            return string.Concat(Element.name, " ", Element.text ?? "", Environment.NewLine);
        }
    }

}
