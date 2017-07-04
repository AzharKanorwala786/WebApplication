namespace Presentation.App_Start
{
    using Presentation.Mappings;
    public class Bootstrapper
    {
        public static void Run()
        {
            AutoMapperConfiguration.Configure();
        }
    }
}