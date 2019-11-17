using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Resolution;
using TradingCompany.DAL.Repositories.Abstractions;
using TradingCompany.DAL.Repositories.Implementations;
using TradingCompany.DAL.UnitOfWork;

namespace TradingCompany.DAL
{
    public static class DependencyInjectorDAL
    {
        private readonly static IUnityContainer _unityContainer = GetUnity();
        private static IUnityContainer GetUnity()
        {
            var container = new UnityContainer();
            container.RegisterDALTypes();

            return container;
        }

        public static void RegisterDALTypes(this IUnityContainer container)
        {
            container
                .RegisterType<IOrdersRepository, OrdersRepository>()
                .RegisterType<IOrdersToProductsRepository, OrdersToProductsRepository>()
                .RegisterType<IProductsRepository, ProductsRepository>()
                .RegisterType<IRolesRepository, RolesRepository>()
                .RegisterType<ISuppliersRepository, SuppliersRepository>()
                .RegisterType<ISuppToProdRepository, SuppToProdRepository>()
                .RegisterType<IUsersRepository, UsersRepository>()
                .RegisterType<IUnitOfWork, UnitOfWork.UnitOfWork>();
        }
        //.RegisterType<IUserRepository, UserRepository>()
        //.RegisterType<TradingCompanyContext>(new PerThreadLifetimeManager());

        public static T Resolve<T>(params ParameterOverride[] overrides)
        {
            return _unityContainer.Resolve<T>(overrides);
        }
    }
}
