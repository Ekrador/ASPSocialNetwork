using WebApplication8.Data.Repository;
using WebApplication8.Data.UoW;

namespace WebApplication8.Extentions
{
    public static class ServiceExtentions
    {
        public static IServiceCollection AddCustomRepository<TEntity, IRepository>(this IServiceCollection services)
                 where TEntity : class
                 where IRepository : class, IRepository<TEntity>
        {
            services.AddScoped<IRepository<TEntity>, IRepository>();

            return services;
        }

    }
}
