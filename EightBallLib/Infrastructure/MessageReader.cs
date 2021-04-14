using System;

namespace EightBallLib.Infrastructure
{
    public interface IMessageReader
    {
        void ReadLine(int linesToCreate);
    }

    public class MessageReader : IMessageReader
    {
        public void ReadLine(int linesToCreate)
        {
            Console.ReadLine();
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
