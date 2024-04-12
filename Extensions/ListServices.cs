using InjectionApi.Repositories;
using InjectionApi.Services;

namespace InjectionApi.Extensions
{
    public static class ListServices
    {
        public static void AddServAndRepo(this WebApplicationBuilder builder)
        {
            //Serviços
            //builder.Services.AddTransient<IPedido, EntregaPedidoLocal>();
            builder.Services.AddTransient<IPedido, EntregaPedidoRemoto>();

            //Repositórios
            builder.Services.AddTransient<MotoboyRepository>();
        }
    }
}
