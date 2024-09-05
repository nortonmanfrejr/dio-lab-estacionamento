using System.ComponentModel;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        //-----------------------------------------------------------------------------------------------------
        // Aux Functions

        private bool Exists() => veiculos.Any();
        private bool Exists(string placa) => veiculos.Any(x => x.ToUpper() == placa);

        //-----------------------------------------------------------------------------------------------------

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            var veiculo = Console.ReadLine();
            veiculo = veiculo.ToUpper();
            veiculos.Add(veiculo);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = Console.ReadLine();
            placa = placa.ToUpper();

            // Verifica se o não veículo existe
            if (Exists(placa) == false) 
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                return;
            }

            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

            // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
            // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal
            // *IMPLEMENTE AQUI*
            int.TryParse(Console.ReadLine(), out int h);

            int horas = h;
            decimal valorTotal = precoInicial + (precoPorHora * horas);

            // TODO: Remover a placa digitada da lista de veículos
            veiculos.Remove(placa);

            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            var existsVeiculos = Exists() == true;
            Console.WriteLine(existsVeiculos == true ? "Os veículos estacionados são:" : "Não há veículos estacionados.");

            // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
            // *IMPLEMENTE AQUI*
            if (existsVeiculos == true) veiculos.ForEach(x => Console.WriteLine(x));
        }
    }
}
