namespace ClassLibrary
{
    public abstract class LightNode
    {
        protected INodeState state;
        public abstract string OuterHtml { get; }
        public abstract string InnerHtml { get; }
        public abstract void Accept(IVisitor visitor);
        public void SetState(INodeState state)
        {
            this.state = state;
        }
    }
}
