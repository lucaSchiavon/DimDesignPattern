using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Strutturali.Flyweight.TextFormatting
{
    public class BetterFormattedText
    {
        public string PlainText { get; }
        private readonly List<TextRange> formatting = new List<TextRange>();
        public BetterFormattedText(string plainText)
        {
            PlainText = plainText;
        }

        public TextRange GetRange(int start, int end)
        {
            var range = new TextRange { Start = start, End = end };
            formatting.Add(range);
            return range;
        }

        public class TextRange
        {
            public int Start, End;
            public bool Capitalize;
            public bool Covers(int position)
            {
                return position >= Start && position <= End;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (var i = 0; i < PlainText.Length; i++)
            {
                var c = PlainText[i];
                foreach (var range in formatting)
                {
                    if (range.Covers(i) && range.Capitalize)
                        c = char.ToUpperInvariant(c);
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

    }
}
