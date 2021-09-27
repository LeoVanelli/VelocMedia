using System;

namespace VelocMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objetivo: Calcule a velocidade, a partir da distância (Δd, em metros) e do tempo (Δt, em segundos).

            Console.Write("Digite a distância percorrida (m): ");
            int deltaD = int.Parse(Console.ReadLine());

            Console.Write("Digite o tempo gasto (s): ");
            int deltaT = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nVelocidade média: {deltaD/deltaT} m/s");
        }
    }
}
