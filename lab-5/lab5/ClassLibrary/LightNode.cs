namespace ClassLibrary
{
    public abstract class LightNode
    {
        protected INodeState state;
        public abstract string OuterHtml { get; }
        public abstract string InnerHtml { get; }

        public void SetState(INodeState state)
        {
            this.state = state;
        }
    }
}
