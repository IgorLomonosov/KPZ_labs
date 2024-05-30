using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ChangeTextCommand : ICommand
    {
        private readonly LightTextNode _textNode;
        private readonly string _newText;
        private string _oldText;

        public ChangeTextCommand(LightTextNode textNode, string newText)
        {
            _textNode = textNode;
            _newText = newText;
        }

        public void Execute()
        {
            _oldText = _textNode.Text;
            _textNode.Text = _newText;
        }

        public void Undo()
        {
            _textNode.Text = _oldText;
        }
    }
}
