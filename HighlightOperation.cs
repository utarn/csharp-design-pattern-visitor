using System;

namespace pattern_visitor
{
    public class HighlightOperation : Operation
    {
        public void Apply(HeadingNode node)
        {
            Console.WriteLine("highlight-heading");
        }

        public void Apply(AnchorNode node)
        {
            Console.WriteLine("highlight-anchor");
        }
    }
}