using Autofac;
using UsersManagement.Api.Configurations;

namespace UsersManagement.Api;
public class Startup
{ 
    private IConfiguration Configuration { get; }
    
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void Configure(WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
    }
    public void ConfigureServices(IServiceCollection services)
    {
        var connection = Configuration["LocalDatabase:Server=localhost;Database=Users;User Id=sa;Password=EUYh@d8rE=E8x9v<"];
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddOptions();
        services.AddMemoryCache();
    }

    public void ConfigureContainer(ContainerBuilder builder)
    {
        builder.RegisterModule(new DependencyRegister());
    }
}