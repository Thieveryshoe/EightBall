using System.Collections.Generic;
using System.Linq;
using EightBallLib.Infrastructure;

namespace EightBallLib
{
    public interface IApp
    {
        void Execute(Options o);
    }

    public class App : IApp
    {
        private readonly IResponseProvider _responseProvider;
        private readonly IMessageWriter _messageWriter;
        private readonly IMessageReader _messageReader;
        private readonly IEnumerable<ILanguagePack> _languagePacks;

        public App(
            IResponseProvider responseProvider,
            IMessageWriter messageWriter,
            IMessageReader messageReader,
            IEnumerable<ILanguagePack> languagePacks)
        {
            _responseProvider = responseProvider;
            _messageWriter = messageWriter;
            _messageReader = messageReader;
            _languagePacks = languagePacks;
        }

        public void Execute(Options o)
        {
            var languagePack = GetLanguagePack(o.Language);

            _messageWriter.PrintMessage(languagePack.WelcomeMessage, 1);
            _messageReader.ReadLine(1);
            
            var response = _responseProvider.GetResponse(languagePack);
            _messageWriter.PrintMessage(response, 1);
        }

        private ILanguagePack GetLanguagePack(string language)
        {
            return _languagePacks.FirstOrDefault(x => x.Language.ToLower() == language.ToLower());
        }
    }
}
