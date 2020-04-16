using System;

namespace pattern_visitor
{
    public class AnchorNode : HtmlNode
    {
        // public void Highlight()
        // {
        //     Console.WriteLine("highlight-anchor");
        // }

        // public void PlainText()
        // {
        //     Console.WriteLine("text-anchor");
        // }
        public void Execute(Operation operation)
        {
            operation.Apply(this);
        }
    }
}