using System;

namespace pattern_visitor
{
    public class HeadingNode : HtmlNode
    {
        // public void Highlight()
        // {
        //     Console.WriteLine("highlight-heading");
        // }

        // public void PlainText()
        // {
        //     Console.WriteLine("text-heading");
        // }
        public void Execute(Operation operation)
        {
            operation.Apply(this);
        }
    }
}