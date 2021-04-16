using System.Collections.Generic;
using EightBallLib;

namespace LanguagePacks
{
    public class Spanish : ILanguagePack
    {
        public string Language => "Spanish";
        public string WelcomeMessage => "¿Qué le gustaría preguntarle a la bola ocho mágica?";
        public Dictionary<int, string> Responses =>
            new Dictionary<int, string>
            {
                {1, "Es cierto."},
                {2, "Sin duda."},
                {3, "Puedes confiar en ello."},
                {4, "Sí definitivamente."},
                {5, "Es decididamente así."},
                {6, "Como yo lo veo, sí."},
                {7, "Más probable."},
                {8, "Si."},
                {9, "Perspectiva buena."},
                {10, "Las señales apuntan a que sí."},
                {11, "Respuesta confusa, intenta otra vez."},
                {12, "Mejor no decirte ahora."},
                {13, "No se puede predecir ahora."},
                {14, "Concéntrate y pregunta otra vez."},
                {15, "No cuentes con eso."},
                {16, "Perspectiva no tan buena."},
                {17, "Mis fuentes dicen que no."},
                {18, "Muy dudosa"},
                {19, "Mi respuesta es no."}
            };
    }
}