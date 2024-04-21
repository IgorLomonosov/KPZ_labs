namespace ClassLibraryTask5
{
    public class TextDocument
    {
        public string Content { get; set; }

        public TextDocument(string content)
        {
            Content = content;
        }

        public TextDocumentMemento CreateMemento()
        {
            return new TextDocumentMemento(Content);
        }

        public void RestoreMemento(TextDocumentMemento memento)
        {
            Content = memento.SavedContent;
        }
    }
}
