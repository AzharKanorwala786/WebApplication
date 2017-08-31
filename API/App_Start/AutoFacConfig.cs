namespace WebApi.App_Start
{
    using API.AutoMapperConfig;
    using AutoMapper;
    using Autofac;
    using Autofac.Integration.WebApi;
    using BusinessLayer.Interface;
    using BusinessLayer.Services;
    using DataAccess;
    using System.Reflection;
    using System.Web.Http;

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
            builder.RegisterGeneric(typeof(RepositoryHelper<>)).As(typeof(IRepositoryHelper<>));

            builder.RegisterType<ProductRepository>().As<IProductRepository>().InstancePerRequest();
            // register services
            builder.RegisterType<ProductService>().As<IProductService>().InstancePerLifetimeScope();

            builder.Register(c => AutoMapperConfig.BuildMaps()).As<IMapper>().SingleInstance();

            builder.RegisterType<Context>().InstancePerLifetimeScope();

            //Set the dependency resolver to be Autofac.  
            Container = builder.Build();

            return Container;
        }
     }
  }