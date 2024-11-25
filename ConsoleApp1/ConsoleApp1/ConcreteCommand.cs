using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ConcreteCommand : Command
    {
        TextEditor receiver;
        public ConcreteCommand(TextEditor r)
        {
            receiver = r;
        }
        public override void Execute()
        {
            receiver.Operation();
        }

        public override void Undo()
        {
            receiver.Undo();
        }

        public override void InsertTextCommand(string text)
        {
            receiver.InsertTextCommand(text);
        }

        public override void DeleteTextCommand(int symbols)
        {
            receiver.DeleteTextCommand(symbols);
        }
    }
}
