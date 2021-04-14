using System;
using System.Collections.Generic;

namespace EightBallLib
{
    public interface IResponseProvider
    {
        string GetResponse(ILanguagePack languagePack);
    }
    
    public class ResponseProvider : IResponseProvider
    {
        public string GetResponse(ILanguagePack languagePack)
        {
            var key = BuildKey();
            return languagePack.Responses.GetValueOrDefault(key);
        }

        private static int BuildKey()
        {
            var r = new Random();
            var key = r.Next(1, 19);
            return key;
        }
    }
}