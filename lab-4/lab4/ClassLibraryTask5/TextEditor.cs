using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask5
{
    public class TextEditor
    {
        private TextDocument _currentDocument;
        private Stack<TextDocumentMemento> _undoStack;

        public TextEditor()
        {
            _currentDocument = new TextDocument("");
            _undoStack = new Stack<TextDocumentMemento>();
        }

        public void LoadDocument(string content)
        {
            _currentDocument = new TextDocument(content);
            _undoStack.Clear();
        }

        public void Save()
        {
            TextDocumentMemento memento = _currentDocument.CreateMemento();
            _undoStack.Push(memento);
        }

        public void Undo()
        {
            if (_undoStack.Count > 0)
            {
                TextDocumentMemento memento = _undoStack.Pop();
                _currentDocument.RestoreMemento(memento);
            }
            else
            {
                Console.WriteLine("Nothing to undo.");
            }
        }

        public void PrintDocument()
        {
            Console.WriteLine("Current Content:");
            Console.WriteLine(_currentDocument.Content);
            Console.WriteLine();
        }
    }
}
