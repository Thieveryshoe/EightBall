using System.Collections.Generic;
using EightBallLib;

namespace LanguagePacks
{
    public class English : ILanguagePack
    {
        public string Language => "English";
        public string WelcomeMessage => "What would you like to ask the magic eight ball?";
        public Dictionary<int, string> Responses =>
            new Dictionary<int, string>
            {
                {1, "It is certain."},
                {2, "Without a doubt."},
                {3, "You may rely on it."},
                {4, "Yes, definitely."},
                {5, "It is decidedly so."},
                {6, "As I see it, yes."},
                {7, "Most likely."},
                {8, "Yes."},
                {9, "Outlook good."},
                {10, "Signs point to yes."},
                {11, "Reply hazy try again."},
                {12, "Better not tell you now."},
                {13, "Cannot predict now."},
                {14, "Concentrate and ask again."},
                {15, "Don’t count on it."},
                {16, "Outlook not so good."},
                {17, "My sources say no."},
                {18, "Very doubtful."},
                {19, "My reply is no."}
            };
    }
}