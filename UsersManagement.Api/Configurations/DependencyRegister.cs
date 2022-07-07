using Autofac;
using UsersManagement.Infrastructure.Interfaces;
using UsersManagement.Infrastructure.Repositories;

namespace UsersManagement.Api.Configurations;

public class DependencyRegister : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<UserRepository>().As<IUsersRepository>().InstancePerLifetimeScope();
    }
}