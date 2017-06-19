namespace WebApi.App_Start
{
  
    using System.Reflection;
    using System.Web.Http;
    using Autofac;
    using Autofac.Integration.WebApi;
    using RepositoryLayer.Interface;
    using RepositoryLayer.Repositories;
    using BusinessLayer.Services;
    using BusinessLayer.Interface;

    public class AutoFacConfig
    {
        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }

        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            //Register your Web API controllers.  
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            // Repository
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>));

            builder.RegisterGeneric(typeof(GenericService<>)).As(typeof(IGenericService<>));

            // register services
            //builder.RegisterType<ProductService>().As<IProductService>().InstancePerLifetimeScope();

            //builder.RegisterType<CategoryService>().As<ICategoryService>().InstancePerLifetimeScope();

            //Set the dependency resolver to be Autofac.  
            Container = builder.Build();

            return Container;
        }
     }
  }