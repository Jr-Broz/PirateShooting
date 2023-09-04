using System;
using System.Windows;
using System.Text;
using System.Threading;
namespace PirateGame {
    public class Program {
        static void Main(string[] args){

            Canhao canhaoo = new Canhao();
            bool sair = false;
            Console.ForegroundColor= ConsoleColor.Cyan;

            while (!sair) {

                Console.WriteLine("Digite: || [1] Para atirar || [2] Para Limpar o Canhao || [3] Para Recarregar o Canhao || [4] Para Jogar no automatico || [5] para Sair");
                Console.WriteLine("[Voce pode atirar com o Canhão 2 vezes]");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                String resposta = Console.ReadLine();

                switch (resposta) {

                    case "1":

                        canhaoo.Atirar();
                        canhaoo.Acertar();
                        break;

                    case "2":

                        canhaoo.Limpar();
                        break;

                    case "3":

                        canhaoo.Recarregar();
                        break;

                    case "4":

                        canhaoo.JogarAutomatico();                    
                        break;

                    case "5":

                        Console.WriteLine("Saindo do Jogo... espere um pouco");
                        sair = true;
                        Thread.Sleep(1000);
                        Environment.Exit(1);
                        System.Environment.Exit(1);
                        break;


                    default:

                        Console.WriteLine("A Espera de ordens, Capitao");
                        Thread.Sleep(390);
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
