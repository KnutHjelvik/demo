using System;

namespace Timpex.Reporting.Filesetup.ByCore.IO
{
    public class ConsoleImpl
    {
        public static Func<ConsoleImpl> New = () => new ConsoleImpl();

        public virtual void Write(string text)
        {
            PrintSuccessTag();
            Console.WriteLine(text);
        }

        public virtual void Info(string text)
        {
            PrintInfoTag();
            Console.WriteLine(text);
        }

        private void PrintSuccessTag()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Ok");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("]: ");
        }


        private void PrintInfoTag()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("COMMAND");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("]: ");
        }
    }
}