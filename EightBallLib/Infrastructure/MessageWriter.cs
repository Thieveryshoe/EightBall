using System;

namespace EightBallLib.Infrastructure
{
    public interface IMessageWriter
    {
        void PrintMessage(string message, int linesToCreate);
    }

    public class MessageWriter : IMessageWriter
    {
        public void PrintMessage(string message, int linesToCreate)
        {
            Console.WriteLine(message);
            CreateBlankSpace(linesToCreate);
        }

        private static void CreateBlankSpace(int linesToCreate)
        {
            var i = 0;
            while (i < linesToCreate)
            {
                Console.WriteLine();
                i++;
            }
        }
    }
}