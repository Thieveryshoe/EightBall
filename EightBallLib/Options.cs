using CommandLine;

namespace EightBallLib
{
    public class Options
    {
        [Option('l', "language", Required = true)]
        public string Language { get; set; }
    }
}