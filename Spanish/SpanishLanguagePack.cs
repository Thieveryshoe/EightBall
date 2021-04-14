using System.Collections.Generic;
using EightBallLib;

namespace Spanish
{
    public class SpanishLanguagePack : ILanguagePack
    {
        public string Language => "Spanish";
        public string WelcomeMessage => "Spanish welcome message";
        public Dictionary<int, string> Responses =>
            new Dictionary<int, string>
            {
                {1, "uno"},
                {2, "dos"},
                {3, "tres"},
                {4, "spanish 5"},
                {5, "spanish 6"},
                {6, "spanish 7"},
                {7, "spanish 8"},
                {8, "spanish 9"},
                {9, "spanish 10"},
                {10, "spanish 11"},
                {11, "spanish 1."},
                {12, "Spanish 10"},
                {13, "Spanish 100."},
                {14, "Spanish."},
                {15, "Spanish."},
                {16, "Spanish."},
                {17, "Spanish."},
                {18, "Spanish."},
                {19, "Spanish."}
            };
    }
}