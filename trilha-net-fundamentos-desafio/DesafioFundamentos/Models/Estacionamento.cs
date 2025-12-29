namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> placas = new List<string>();


        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo( )
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
             string placa = Console.ReadLine();
             placas.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
             string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (placas.Any(x => x.ToUpper() == placa.ToUpper()))
            {

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                decimal horasEstacionado = Convert.ToDecimal(Console.ReadLine());
                
            
                decimal valorTotal = 0;


                valorTotal = precoInicial + (precoPorHora * horasEstacionado);
                // TODO: Remover a placa digitada da lista de veículos
                placas.Remove(placa);
                // *IMPLEMENTE AQUI*

                Console.WriteLine($"O veículo de placa {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (placas.Any())
            {
                int contador = 0;
                foreach ( string placa in placas)
                {
                    Console.WriteLine($"Os veículos estacionados são: ");
                    Console.WriteLine($"Veículo {contador + 1}: {placa}");
                    contador++;  

                }
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
