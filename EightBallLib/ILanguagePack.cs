using System.Collections.Generic;

namespace EightBallLib
{
    public interface ILanguagePack
    {
        Dictionary<int, string> Responses { get; }
        string WelcomeMessage { get; }
        string Language { get; }
    }
}