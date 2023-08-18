using PirateShooting;
using System;
using System.Collections.Generic;
using System.Text;

namespace PirateGame {
    public class Program {

        static void Main(string[] args) {

            Canhao canhaoo = new Canhao();

            bool sair = false;
            
            while(!sair) {  

            Console.WriteLine("Digite: || [1] Para atirar || [2] Para Limpar o Canhao || [3] Para Recarregar o Canhao || [4] Para Sair");
            String resposta = Console.ReadLine();
                Console.WriteLine("--------------------------");
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

                    Console.WriteLine("Terminando programa");
                    Console.ReadKey();
                    sair = true;
                    break;

                 default:

                    Console.WriteLine("A Espera de ordens, Capitao");
                    break;
            }
         }
        }
    }
}
