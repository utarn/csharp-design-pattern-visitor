namespace pattern_visitor
{
    public interface HtmlNode
    {
        // void Highlight();
        // void PlainText();

        void Execute(Operation operation);
    }
}