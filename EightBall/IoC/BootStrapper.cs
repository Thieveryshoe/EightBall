using EightBallLib;
using Lamar;

namespace EightBall.IoC
{
    public class BootStrapper
    {
        public static Container Bootstrap()
        {
            var container = new Container(c =>
                c.Scan(s =>
                {
                    s.TheCallingAssembly();
                    s.WithDefaultConventions();
                    s.AssembliesFromApplicationBaseDirectory();
                    s.AddAllTypesOf<ILanguagePack>();
                }));

            return container;
        }
    }
}
