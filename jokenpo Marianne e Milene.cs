using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokenPo
{
    class Program
    {
        static void Main(string[] args)
        {
            int opção, jogada;
            double vjogador = 0, vmáquina = 0;
            do
            {
                Console.WriteLine("MELHOR DE TRÊS");
                Console.WriteLine("0- PEDRA");
                Console.WriteLine("1- PAPEL");
                Console.WriteLine("2- TESOURA");

                opção = Convert.ToInt32(Console.ReadLine());

                Random jokenpo = new Random();
                jogada = jokenpo.Next(2);

                // 0 -> PEDRA
                // 1 -> PAPEL
                // 2 -> TESOURA

                if (opção == 0 && jogada == 0)
                {
                    Console.Clear();
                    Console.WriteLine("A MÁQUINA JOGOU PEDRA!");
                    Console.WriteLine("EMPATE!");

                }

                else if (opção == 0 && jogada == 1)
                {
                    Console.Clear();
                    Console.WriteLine("A MÁQUINA JOGOU PAPEL!");
                    Console.WriteLine("COMPUTADOR VENCEU!");
                    vmáquina = vmáquina + 1;
                }
                else if (opção == 1 && jogada == 0)
                {
                    Console.Clear();
                    Console.WriteLine("A MÁQUINA JOGOU TESOURA!");
                    Console.WriteLine("JOGADOR VENCEU!");
                    vjogador = + 1;
                }
                else if (opção == 1 && jogada == 1)
                {
                    Console.Clear();
                    Console.WriteLine("A MÁQUINA JOGOU PEDRA!");
                    Console.WriteLine("EMPATE!");
                }
                else if (opção == 2 && jogada == 0)
                {
                    Console.Clear();
                    Console.WriteLine("A MÁQUINA JOGOU PAPEL!");
                    Console.WriteLine("JOGADOR VENCEU!");
                    vjogador = + 1;
                }
                else if (opção == 2 && jogada == 1)
                {
                    Console.Clear();
                    Console.WriteLine("A MÁQUINA JOGOU TESOURA!");
                    Console.WriteLine("JOGADOR VENCEU!");
                    vjogador = + 1;
                }
                else if (opção == 2 && jogada == 2)
                {
                    Console.Clear();
                    Console.WriteLine("A MÁQUINA JOGOU PEDRA!");
                    Console.WriteLine("EMPATE!");
                }
                else if (opção == 2 && jogada == 1)
                {
                    Console.Clear();
                    Console.WriteLine("A MÁQUINA JOGOU PAPEL!");
                    Console.WriteLine("JOGADOR VENCEU!");
                    vjogador = + 1;
                }
                else if (opção == 1 && jogada == 2)
                {
                    Console.Clear();
                    Console.WriteLine("A MÁQUINA JOGOU PEDRA!");
                    Console.WriteLine("COMPUTADOR VENCEU!");
                    vmáquina = vmáquina + 1;
                }

                else if (opção == 0 && jogada == 2)
                {
                    Console.Clear();
                    Console.WriteLine("A MÁQUINA JOGOU PAPEL!");
                    Console.WriteLine("COMPUTADOR VENCEU!");
                    vmáquina = vmáquina + 1;
                }

            } while (vjogador + vmáquina <= 2);

            Console.Clear();

            if (vjogador > vmáquina)
            {
                Console.WriteLine("JOGADOR VENCEU COM!" + vjogador);
                Console.WriteLine("COMPUTADOR PERDEU COM" + vmáquina);
            }
            else
            {
                Console.WriteLine("JOGADOR PERDEU COM!" + vjogador);
                Console.WriteLine("COMPUTADOR VENCEU COM" + vmáquina);
            }
            Console.ReadKey();
        }
    }
}
