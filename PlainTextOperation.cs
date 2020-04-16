using System;

namespace pattern_visitor
{
    public class PlainTextOperation : Operation
    {
        public void Apply(HeadingNode node)
        {
            Console.WriteLine("text-heading");
        }

        public void Apply(AnchorNode node)
        {
            Console.WriteLine("text-anchor");
        }
    }
}