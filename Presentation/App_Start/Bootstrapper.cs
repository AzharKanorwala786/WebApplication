using Presentation.Mappings;

namespace Presentation.App_Start
{
    public class Bootstrapper
    {
        public static void Run()
        {
            AutoMapperConfiguration.Configure();
        }
    }
}