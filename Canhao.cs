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

        public static int atirouQuantasVezes = 0;

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


        //Englobar todas as funções da interface nesta Funçao abaixo.
        public void EntrarEmCombate() {





            if (atirouQuantasVezes == 3) {

                Console.WriteLine("Voce Pode entrar em combate Fisico com o inimigo. [1] Para sim || [2] Para nao");

                int resposta = Int32.Parse((Console.ReadLine()));

                switch(resposta) {

                    case 1:

                        EscolherArma();
                        break;

                    case 2:

                        Console.WriteLine("Muito bem, Capitao, iremos afundar o navio.");
                        break;
                }





            }
        }



      

 
        //Feito, Acredito que feito.
        public void EscolherArma() {

            Console.WriteLine("Você entrou em combate físico, escolha entre a || [1] Cimitarra e uma  [2] Pederneira");

            int resposta = Int32.Parse((Console.ReadLine()));

                     
            switch(resposta) {

                case 1:

                    Console.WriteLine("Você escolheu a Cimitarra");
             
                    break;

                case 2:

                    Console.WriteLine("Você escolheu a Pederneira");
                    break;

                default:

                    Console.WriteLine("Como nenhuma arma foi escolhida, Você usará os punhos");
                    break;
            }
    }

        //Rolar um dado para ver se acertou o Golpe.
        public void Golpear() {

            Random acertarGolpe = new Random();

        int verAcerto =  acertarGolpe.Next(1, 20);

            if(verAcerto >= 12) {



            }

        }

       

        public void ChecarSeAcertouGolpeFisico() {




        }

        //Provavel utilizar um d20 para rolar o dano 
        public int receberDano() {

            int hpUsuario = 30;

            


        }
        public int darDano() {


            Random darDano = new Random ();

            int calcularDano = Convert.ToInt32((darDano.Next(1,20) * 1.5));

        }


    }


}
