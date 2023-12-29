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
            
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.ReadKey();
            //IMPLEMENTADO !!
           
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            
            //IMPLEMENTADO !!
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                //IMPLEMENTADO !!
                int horas = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o preço inicial:");
                decimal precoInicial = decimal.Parse(Console.ReadLine()); // Defina o preço inicial aqui

                Console.WriteLine("Digite o preço por hora:");
                decimal precoPorHora = decimal.Parse(Console.ReadLine()); // Defina o preço por hora aqui

                decimal valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(placa); 

                //IMPLEMENTADO !!

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                foreach (string item in veiculos)
                {
                    Console.WriteLine(item);
                }
                //IMPLEMENTADO !!
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
