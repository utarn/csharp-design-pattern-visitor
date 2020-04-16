namespace pattern_visitor
{
    public interface Operation
    {
        void Apply(HeadingNode node);
        void Apply(AnchorNode node);
    }
}