using System;
using CommandLine;
using EightBall.IoC;
using EightBallLib;

namespace EightBall
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Parser.Default.ParseArguments<Options>(args).WithParsed(Execute);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static void Execute(Options o)
        {
            var container = BootStrapper.Bootstrap();
            var app = container.GetInstance<IApp>();
            app.Execute(o);
        }
    }
}
