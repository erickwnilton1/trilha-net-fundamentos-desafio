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

        public void AdicionarVeiculo()
        {
            while (true)
            {
                Console.WriteLine("Digite a placa do veículo para estacionar:");
                string PlacaDoVeiculo = Console.ReadLine().Trim();

                if (string.IsNullOrWhiteSpace(PlacaDoVeiculo))
                {
                    Console.WriteLine("Insira os dados da placa do véiculo.");
                    return;
                }
                else if (PlacaDoVeiculo.Length < 7)
                {
                    Console.WriteLine("Placa incompleta, insira todos os dados da placa;");
                    return;
                }
                else
                {
                    veiculos.Add(PlacaDoVeiculo);
                    Console.WriteLine("Véiculo estacionado com sucesso.");
                }
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horasVeiculoEstacionado = int.Parse(Console.ReadLine());

                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal      
                decimal somaDoPrecoInicialePrecoPorHora = precoInicial + precoPorHora; 


                // *IMPLEMENTE AQUI*
                int horas = horasVeiculoEstacionado;
                decimal valorTotal = somaDoPrecoInicialePrecoPorHora * horas; 

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string items in veiculos)
                {
                    Console.WriteLine(items);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
