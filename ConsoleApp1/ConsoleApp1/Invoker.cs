using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Invoker
    {
        Command command;
        public void SetCommand(Command c)
        {
            command = c;
        }
        public void Print()
        {
            command.Execute();
        }
        public void Cancel()
        {
            command.Undo();
        }
        public void Insert(string text)
        {
            command.InsertTextCommand(text);
        }

        public void Delete(int symbols)
        {
            command.DeleteTextCommand(symbols);
        }
    }
}
