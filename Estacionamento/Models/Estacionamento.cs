﻿namespace DesafioFundamentos.Models
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
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("CADASTRAR VEÍCULO");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Convert.ToString(Console.ReadLine());

            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("REMOVER VEÍCULO");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = "";

            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = 0;
                horas = Convert.ToInt32(Console.ReadLine());
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal
                decimal valorTotal = precoInicial + (precoPorHora * horas);
                // TODO: Remover a placa digitada da lista de veículos
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente\n");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("LISTA DE VEÍCULOS ESTACIONADOS");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                foreach(string carros in veiculos)
                {
                    Console.WriteLine($"Placas localizadas: {carros.ToUpper()}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}