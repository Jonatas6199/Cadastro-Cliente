using System.Web.Http;
using Unity;
using Unity.WebApi;
using WebAPI.Interfaces.IRepositories;
using WebAPI.Interfaces.IServices;
using WebAPI.Repository;
using WebAPI.Services;

namespace WebAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);

            //Services
            container.RegisterType<IClientService, ClientService>();
            container.RegisterType<IClientAddressService, ClientAddressService>();

            //Repository
            container.RegisterType<IClientRepository, ClientRepository>();
            container.RegisterType<IClientAddressRepository, ClientAddressRepository>();
        }
    }
}