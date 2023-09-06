using System;
using PirateGame;
using System.Threading;
namespace PirateGame {
    public class Canhao : pyhsicalCombat {

        protected string atirar, limpar, recarregar;
        protected bool estaRecarregado, estaSujo, Executavel, foiAtirado;
        public static int acertouQuantasVezes = 0;
        public static Random hpDoInimigo = new Random();
        public static int hpInimigo = hpDoInimigo.Next(15, 20);
        public static int hpUsuario = 20;
        int atirouQntVezes = 0;
        
        //Shoot cannon
        public void Atirar() {
    
            atirar = "ATIRANDO CANHÃO";
            foiAtirado = false; 

            if (foiAtirado == false) {

                Console.WriteLine(atirar);
                Thread.Sleep(1200);
                foiAtirado = true;
                estaSujo = true;
                estaRecarregado = false;
                atirouQntVezes++;
                
            }
            if (atirouQntVezes >= 2) {

                Console.WriteLine("ATIRAMOS, PRECISMAOS LIMPAR AGORA ");
                Console.WriteLine("-------------------------------------");
                Limpar();
                atirouQntVezes = atirouQntVezes -2;
                return;
                
            }
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
                        Console.WriteLine("-----------------------------------------");
                        Thread.Sleep(2000);
                        Console.WriteLine(limpar);
                        estaSujo = false;
                    }

                    if (estaSujo == false) {

                            Console.WriteLine("Ja limpamos o canhão, Iremos recarrega-lo");
                            Console.WriteLine("-----------------------------------------");
                            Recarregar();
                            atirouQntVezes = atirouQntVezes - 2;
                        }

                     else {

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
        public void Recarregar() {


            if (estaSujo == true) {

                Thread.Sleep(290);
                Console.WriteLine("Nao podemos recarregar pois o CANHAO ESTA SUJO");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("VOLTE UMA ETAPA PARA PODER CONTINUAR");

                Limpar();
            }
            estaRecarregado = false;
            recarregar = "Recarregando... ";

            if (estaRecarregado == false && estaSujo == false) {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("ESTAMOS RECARREGANDO O CANHAO, CAPITAO!");
                Thread.Sleep(3500);
                Console.WriteLine("Canhao recarregado");
                Console.WriteLine("------------------------------------");
            }
        }
        public void Acertar() {

            Random acertar = new Random();

            if (acertar.Next(1, 10) % 2 != 0) {

                Console.WriteLine("Malditos olhos erramos o tiro! ");
            } else {

                Console.WriteLine("Acertamos o Tiro, capitao!");
                acertouQuantasVezes = acertouQuantasVezes + 1;
                if (acertouQuantasVezes == 3) {

                    EntrarEmCombate();

                }
            }
            Console.WriteLine("---------------------------------");

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

                    Console.WriteLine("Você escolheu a Pederneira.");
                    AtirarTiro();
                    break;

                case 3:
                    Console.WriteLine("Você usará os punhos.");
                    darDano();
                    break;
            }
        }

        //Rolar um dado para ver se acertou o Golpe.
        public void Golpear() {

            do {

                Random acertarGolpe = new Random();

                Console.WriteLine("Voce tenta acertar o Inimigo...");
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
            while (hpInimigo > 0 || hpUsuario > 0 );

            if (hpInimigo == 0 ) {

                Console.WriteLine("Voce derrotou o Inimigo");

            }
        }
        //Utilizando um d20 para rolar o dano 
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
                Console.WriteLine("Sua Tripulação toma o navio e todo o ouro nele!");
                Thread.Sleep(450);
                return 0;
            }
            return 0;
        }

        //Alterei o AtirarTiro() Apagando a parte : TiroDado >= 5
        public void AtirarTiro() {

            Random atirar = new Random();
            atirar.Next(1, 10);

            int tiroDado = atirar.Next(1, 10);

            if (tiroDado >= 6) {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Voce acertou um tiro");
                darDano();
            } else {

                Console.WriteLine("Voce errou o tiro");
                Console.WriteLine("-----------------------------------");
                receberDano();
            }
        }
    }
}
