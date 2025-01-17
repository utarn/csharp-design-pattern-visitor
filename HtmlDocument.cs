using System.Collections.Generic;

namespace pattern_visitor
{
    public class HtmlDocument
    {
        private readonly List<HtmlNode> _nodes;
        public HtmlDocument()
        {
            _nodes = new List<HtmlNode>();
        }

        public void Add(HtmlNode node)
        {
            _nodes.Add(node);
        }

        // public void Highlight()
        // {
        //     foreach (var node in _nodes)
        //     {
        //         node.Highlight();
        //     }
        // }

        public void Execute(Operation operation)
        {
            foreach (var node in _nodes)
            {
                node.Execute(operation);
            }
        }
    }
}