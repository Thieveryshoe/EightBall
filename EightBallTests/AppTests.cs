/*using System.Collections.Generic;
using EightBallLib;
using EightBallLib.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace EightBallTests
{
    [TestClass]
    public class AppTests
    {
        private App _sut;
        private Mock<IResponseProvider> _responseProvider;
        private Mock<IMessageWriter> _messageWriter;
        private Mock<IMessageReader> _messageReader;
        
        private List<ILanguagePack> _languagePacks;

        [TestInitialize]
        public void Setup()
        {
            _responseProvider = new Mock<IResponseProvider>();
            _messageWriter = new Mock<IMessageWriter>();
            _messageReader = new Mock<IMessageReader>();
            
            _sut = new App(
                _responseProvider.Object,
                _messageWriter.Object,
                _messageReader.Object);
        }

        [TestMethod]
        public void It_should_get_the_language_repository()
        {

        }
    }
}*/