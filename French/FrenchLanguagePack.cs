using System.Collections.Generic;
using EightBallLib;

namespace French
{
    public class FrenchLanguagePack : ILanguagePack
    {
        public string Language => "French";
        public string WelcomeMessage => "Que voulez-vous demander à la boule magique?";
        public Dictionary<int, string> Responses =>
            new Dictionary<int, string>
            {
                {1, "C'est assuré."},
                {2, "C'est certain."},
                {3, "Sans aucun doute."},
                {4, "Oui, certainement."},
                {5, "Il ne saurait en être autrement."},
                {6, "Je pense bien que oui."},
                {7, "C'est très probable."},
                {8, "Oui."},
                {9, "Ca semble raisonable."},
                {10, "La réponse tend vers oui."},
                {11, "Difficile à dire."},
                {12, "Mieux vaut ne pas vous le dire maintenant."},
                {13, "Impossible à prédire de suite."},
                {14, "Concentrez-vous et demandez à nouveau."},
                {15, "Ne comptez pas dessus."},
                {16, "Ca ne semble pas probable."},
                {17, "On m'indique que non."},
                {18, "J'en doute fortement."},
                {19, "Ma réponse est non."}
            };
    }
}