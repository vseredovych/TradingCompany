﻿using AutoMapper;
using TradingCompany.BLL.Mapper;
using TradingCompany.BLL.Services.Abstractions;
using TradingCompany.BLL.Services.Implementations;
using TradingCompany.DAL;
using Unity;
using Unity.Resolution;

namespace TradingCompany.BLL
{
    public static class DependencyInjectorBLL
    {
        private readonly static IUnityContainer _unityContainer = GetUnity();

        private static IUnityContainer GetUnity()
        {
            var container = new UnityContainer();
            container.RegisterDALTypes();
            container.RegisterBLLTypes();

            return container;
        }

        public static void RegisterBLLTypes(this IUnityContainer container)
        {
            container
                .RegisterType<IAuthenticationService, AuthenticationService>()
                .RegisterType<IUserService, UserService>()
                .RegisterType<IRoleService, RoleService>()
                .RegisterType<IProductService, ProductService>()
                .RegisterType<IOrderService, OrderService>()
                .RegisterInstance<IMapper>(ObjectsMapper.CreateMapper());
            //, InstanceLifetime.Singleton
        }

        public static T Resolve<T>(params ParameterOverride[] overrides)
        {
            return _unityContainer.Resolve<T>(overrides);
        }
    }
}
