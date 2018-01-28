[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(AvaliacaoInfnet.MVC.App_Start.SimpleInjectorInitializer), "Initialize")]

namespace AvaliacaoInfnet.MVC.App_Start
{
    using AvaliacaoInfnet.CC.IoC;
    using SimpleInjector;
    using SimpleInjector.Integration.Web;
    using SimpleInjector.Integration.Web.Mvc;
    using System.Reflection;
    using System.Web.Mvc;
  

    public class SimpleInjectorInitializer
    {
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }

        private static void InitializeContainer(Container container)
        {
            BootStrapper.RegisterServices(container);
            // For instance:
            // container.Register<IUserRepository, SqlUserRepository>(Lifestyle.Scoped);
        }
    }
}