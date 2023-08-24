using System;
using System.Collections.Generic;
using PirateGame;
using System.Text;
using System.Threading;
using System.Diagnostics.Contracts;
namespace PirateGame {
    public class Canhao {

        string atirar, limpar, recarregar;

        bool estaRecarregado, estaSujo, Executavel, foiAtirado, AtirarDenovo;
        Random acertar;

        //Shoot cannon
        public string Atirar() {

            do {

                atirar = "ATIRANDO CANHÃO";
                foiAtirado = false;
                AtirarDenovo = false;
                if (foiAtirado == false) {

                    Console.WriteLine(atirar);
                    Thread.Sleep(1500);
                    foiAtirado = true;
                }

                /*
                if (foiAtirado == true && AtirarDenovo == false) {

                    Console.WriteLine("VOCÊ JA ATIROU ESSE CANHÃO, VÁ PARA A PRÓXIMA ETAPA");
                    foiAtirado = true;
                    AtirarDenovo = false;
                }
                */
            }
            while (AtirarDenovo == true);

            return this.atirar;
        }

        //Clean cannon
        public string Limpar() {

            do {
                
                limpar = "CANHÃO LIMPO, PRONTO PARA RECARREGAR, CAPITAO";
                estaSujo = true;

                if (estaSujo == true) {

                    Console.WriteLine("Voce quer limpar o canhao ?");
                    string resposta = Console.ReadLine();

                    if (resposta == "sim" || resposta == "Sim" || resposta == "s" || resposta == "S" || resposta == "SIM") {

                     

                    Console.WriteLine("ESTAMOS LIMPANDO O CANHAO, CAPITÃO!");
                    Thread.Sleep(2000);
                    Console.WriteLine(limpar);
                        estaSujo = false;

                    } else {

                        Console.WriteLine("Ok, nao iremos limpar o canhão");
                        Thread.Sleep(290);
                        estaSujo = true;
                    }

                }
                Console.WriteLine("---------------------------------");
                return this.limpar;
            }
            while (estaSujo == true);

        }

        //Reload Cannon
        public string Recarregar() {

            do {

                if (estaSujo == true) {

                    Thread.Sleep(290);
                    Console.WriteLine("Nao podemos recarregar pois o CANHAO ESTA SUJO");
                   
                    Console.WriteLine("VOLTE UMA ETAPA PARA PODER CONTINUAR");
                    

                }
                estaRecarregado = false;
                recarregar = "Recarregando... ";
                //Console.WriteLine(recarregar);
                                     
                
                if (estaRecarregado == false && estaSujo == false) {
                    Console.WriteLine("ESTAMOS RECARREGANDO O CANHAO, CAPITAO!");
                    Thread.Sleep(3500);
                    //return Limpar();
                    Console.WriteLine("Canhao Recarregado");
                }

                Console.WriteLine("---------------------------------");
                return recarregar;
            }
            while (estaSujo == true);

        }















            //Check if you hit the other "Ship" or not.
            public int Acertar() {

            Random acertar = new Random();

            if (acertar.Next(1, 10) % 2 != 0) {

                Console.WriteLine("Malditos olhos, Erramos! ");
            } else {

                Console.WriteLine("Acertamos capitao!");

            }
            Console.WriteLine("---------------------------------");
            return 0;
        }
    }
}
