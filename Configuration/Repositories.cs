using Bonsai.External.Repositories;
using Bonsai.UseCases.Interfaces;

namespace Bonsai.Configuration
{
    public static class Repositories
    {
        public static void Configure(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IOrderRepository, OrderRepository>();
        }
    }
}