using System;

namespace Calculator{

    class Program{

        static void Main(string[] args){

            Menu();

        }

        static void Menu(){

            Console.Clear();
            Console.WriteLine("-----CRONÔMETRO-----");
            Console.WriteLine("Final 'm' em minutos");
            Console.WriteLine("Final 's' em segundos");
            Console.WriteLine("Ex.: 10s -> contar 10 segundos");
            Console.WriteLine("Ex.: 3m -> contar 3 minuntos");
            Console.WriteLine("Digite 0 para finalizar");
            Console.WriteLine("Digite o quanto você deseja contar: ");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if(type == 'm')
                multiplier = 60;

            if(time == 0)
                System.Environment.Exit(0);

            int total = time * multiplier;
            Start(total, data);
        }

        static void Start(int time, string data){

            int currentTime = 0;

            while(currentTime != time){

                Console.Clear();
                Console.WriteLine($"Tempo total: {data}");
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);

            }

            Console.Clear();
            Console.WriteLine("Cronômetro finalizado");
            Thread.Sleep(1000);

        }

    }

}