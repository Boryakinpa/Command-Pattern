using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TextEditor
    {
        private int commands = 0;
        private string undoText;
        public string text { get; private set; } = string.Empty;
        public void Operation()
        {
            Console.WriteLine(text);
        }

        public void Undo()
        {
            text = undoText;
        }

        public void InsertTextCommand(string _text)
        {
            undoText = text;
            text += _text;
        }

        public void DeleteTextCommand(int _symbols)
        {
            undoText = text;
            if (text.Length >= _symbols)
            {
                text = text.Remove(text.Length - _symbols);
            }
        }
    }
}
