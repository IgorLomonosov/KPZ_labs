namespace ClassLibrary
{
    public abstract class LightNode
    {
        public abstract string OuterHtml { get; }
        public abstract string InnerHtml { get; }
        public abstract void Accept(IVisitor visitor);
    }
}
