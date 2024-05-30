namespace ClassLibrary
{
    public abstract class LightNode
    {
        protected INodeState state;
        public abstract string OuterHtml { get; }
        public abstract string InnerHtml { get; }
        protected virtual void OnCreated() { }
        protected virtual void OnInserted() { }
        protected virtual void OnRemoved() { }
        protected virtual void OnStylesApplied() { }
        protected virtual void OnClassListApplied() { }
        protected virtual void OnTextRendered() { }

        public LightNode()
        {
            OnCreated();
        }
        public abstract void Accept(IVisitor visitor);
        public void SetState(INodeState state)
        {
            this.state = state;
        }
    }
}
