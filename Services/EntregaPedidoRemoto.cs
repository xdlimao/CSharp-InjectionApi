using InjectionApi.Repositories;

namespace InjectionApi.Services
{
    public class EntregaPedidoRemoto : IPedido
    {
        private readonly MotoboyRepository _motoboyRepository;
        public EntregaPedidoRemoto(MotoboyRepository motoboyRepository)
        {

            _motoboyRepository = motoboyRepository;

        }
        public string ProcessarPedido()
        {
            return $"Motoboy chamado {_motoboyRepository.GetMotoboyName()} no seu portão otário";
        }
    }
}
