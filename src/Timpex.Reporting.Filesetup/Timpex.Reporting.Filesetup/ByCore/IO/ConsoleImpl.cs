using System;

namespace Timpex.Reporting.Filesetup.ByCore.IO
{
    public class ConsoleImpl
    {
        public static Func<ConsoleImpl> New = () => new ConsoleImpl();

        public void Write(string text)
        {
            PrintSuccessTag();
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
    }
}