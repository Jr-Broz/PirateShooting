using System;
using System.Collections.Generic;
using PirateGame;
using System.Text;
using System.Threading;
using System.Diagnostics.Contracts;
using System.ComponentModel;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
namespace PirateGame {
    public class Canhao : pyhsicalCombat {

        protected string atirar, limpar, recarregar;
        protected bool estaRecarregado, estaSujo, Executavel, foiAtirado, AtirarDenovo;
        public static int acertouQuantasVezes = 0;

        public static Random hpDoInimigo = new Random();
        public static int hpInimigo = hpDoInimigo.Next(15, 20);
        public static int hpUsuario = 20;

        //Shoot cannon
        public string Atirar() {


                atirar = "ATIRANDO CANHÃO";
                foiAtirado = false;
                if (foiAtirado == false) {

                    Console.WriteLine(atirar);
                    Thread.Sleep(1500);
                    foiAtirado = true;
                    AtirarDenovo = false;
                }

                if(foiAtirado == true) {

                    NaoPodeAtirar();
                }

                /*
                if (foiAtirado == true && AtirarDenovo == false) {

                    Console.WriteLine("VOCÊ JA ATIROU ESSE CANHÃO, VÁ PARA A PRÓXIMA ETAPA");
                    foiAtirado = true;
                    AtirarDenovo = false;
                }
                */
 
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
                    Console.WriteLine("Nao podemos recarregar pois o canhao esta sujo");          
                    return Limpar();
                }
                estaRecarregado = false;
                recarregar = "Recarregando... ";
                //Console.WriteLine(recarregar);


                if(foiAtirado == true) {

                    return "Nao podemos atirar, é preciso limpar e recarregar"; 
                }


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
        public void Acertar() {

            Random acertar = new Random();



            if (acertar.Next(1, 10) % 2 != 0) {



                Console.WriteLine("Malditos olhos, Erramos! ");
            } else {



                Console.WriteLine("Acertamos capitao!");
                acertouQuantasVezes = acertouQuantasVezes + 1;
                if (acertouQuantasVezes == 3) {

                    EntrarEmCombate();

                }
            }
            Console.WriteLine("---------------------------------");

        }


        public void NaoPodeAtirar() {

            
            Console.WriteLine("Nao podemos atirar, pois nao está recarregado");
        }




        public void EntrarEmCombate() {


            if (acertouQuantasVezes == 3) {

                Console.WriteLine("Voce Pode entrar em combate Fisico com o inimigo. [1] Para sim || [2] Para nao");

                int resposta = Int32.Parse((Console.ReadLine()));

                switch (resposta) {

                    case 1:

                        EscolherArma();
                        Golpear();
                        break;

                    case 2:

                        Console.WriteLine("Muito bem, Capitao, iremos afundar o navio.");
                        break;
                }
            }
        }    //Voltar para esse ponto.


        public void EscolherArma() {

            Console.WriteLine("Você entrou em combate físico, escolha entre: || [1] Cimitarra [2] Pederneira [3] Punhos");

            int resposta = Int32.Parse((Console.ReadLine()));

            switch (resposta) {

                case 1:

                    Console.WriteLine("Você escolheu a Cimitarra.");
                    break;

                case 2:

                    Console.WriteLine("Você escolheu a Pederneirs.");
                   AtirarTiro();
                    break;

                case 3:
                    Console.WriteLine("Você usará os punhos.");
                    darDano();
                    break;
            }
        }

        //Rolar um dado para ver se acertou o Golpe.

        public int Golpear() {


            do {

                Random acertarGolpe = new Random();

                Console.WriteLine("Voce Golpeia o Inimigo...");
                Thread.Sleep(1500);

                int verAcerto = acertarGolpe.Next(1, 20);


                if (verAcerto >= 12) {

                    Console.WriteLine("Voce acertou o golpe");
                    Console.WriteLine("-----------------------------------");
                    darDano();
              

                } else {

                    Console.WriteLine("Voce errou o golpe");
                    Console.WriteLine("-----------------------------------");
                    receberDano();
                  
                }
            }

            while (hpInimigo >= 0 || hpUsuario >= 0);
            return 0;

        }  

        //Provavel utilizar um d20 para rolar o dano 
        public int receberDano() {

            Random receberDano = new Random();

            int calcularDano = Convert.ToInt32((receberDano.Next(1, 20) * 1.5) / 2);

            hpUsuario -= calcularDano;

            Console.WriteLine($"Voce foi golpeado! recebeu  {calcularDano}   pontos de dano.");
            Console.WriteLine($"Seu HP: {hpUsuario}");
            if (hpUsuario <= 0) {

                Console.WriteLine("GAME OVER!");
                Console.Clear();
                return 0;
            }
            return 0;

        }
        public int darDano() {

            Random darDano = new Random();

            int calcularDano = Convert.ToInt32((darDano.Next(1, 20) * 1.5) / 2);

            hpInimigo -= calcularDano;
            Console.WriteLine($"Voce deu {calcularDano}" + " pontos de dano");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"HP do inimigo: {hpInimigo}");


            if (hpInimigo <= 0) {

                Console.WriteLine("O inimigo Foi Derrotado!");
                return 0;
            }
            return 0;
        }


        public void AtirarTiro() {

            Random atirar = new Random();
            atirar.Next(1, 10);

            int tiroDado = atirar.Next(1, 10);

            if (tiroDado >= 6 && tiroDado >= 5) {

                Console.WriteLine("Voce acertou um tiro");
                darDano();
            } 
            else {

                Console.WriteLine("Voce errou o tiro");
                receberDano();
            }
        }
    }
}
