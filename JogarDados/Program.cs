using JogarDados.Dominio;
using System;

namespace Program
{
    public class JogarDadosMain
    {
        public static void Main(string[] args)
        {
            bool ctrl = true;
            string jogador1 = null, jogador2 = null;
            int vencedor, rodadas = 0;

            // Instanciando objeto JogarDadosSim localmente
            JogarDadosSim jogo = new JogarDadosSim();



            // Loop para garantir nomes de jogadores diferentes
            while (ctrl)
            {
                Console.WriteLine("Nome jogador 1:");
                jogador1 = Console.ReadLine();

                Console.WriteLine("Nome jogador 2:");
                jogador2 = Console.ReadLine();

                if (jogador1 == jogador2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERRO: Ambos os nomes iguais.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    ctrl = false;
                }
            }

            ctrl = true;

            // Defina o número de rodadas que você deseja
            while (ctrl)
            {
                Console.WriteLine("Numero de rodadas: (Entre 1 e 5)");
                rodadas = int.Parse(Console.ReadLine());

                if (rodadas < 1 || rodadas > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERRO: Valor deve ser entre 1 e 5.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    ctrl = false;
                }

            }


            // Chame o método SimularDados usando o objeto jogo
            vencedor = jogo.SimularDados(jogador1, jogador2 ,rodadas);

            // Exiba o vencedor do jogo
            Console.WriteLine("O jogador " + (vencedor == 1 ? jogador1 : jogador2) + " venceu o jogo!");
        }
    }
}