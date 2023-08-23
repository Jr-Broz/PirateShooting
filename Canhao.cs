using System;
using System.Collections.Generic;
using PirateGame;
using System.Text;
using System.Threading;
using System.Diagnostics.Contracts;

namespace PirateShooting {
    public class Canhao {

        string atirar, limpar, recarregar;
        bool jaFoiAtirado;
        bool estaLimpo;
        bool estaRecarregado;
        bool Executavel;
        Random acertar;

        //Shoot cannon
        public string Atirar() {

            atirar = "ATIRANDO CANHÃO";
            Console.WriteLine(atirar);
            estaLimpo = false;

            if(estaLimpo == false) {


                Thread.Sleep(1500);
                jaFoiAtirado = true;
         }
            
            return this.atirar;            
        }             

        //Clean cannon
        public string Limpar() {

            limpar = "CANHÃO LIMPO, PRONTO PARA USO";
            estaLimpo = false;

            if(estaLimpo == false) {

                Console.WriteLine("ESTAMOS LIMPANDO O CANHAO, CAPITÃO!");
                Thread.Sleep(2000);
                Console.WriteLine(limpar);
                estaLimpo = true;
                Executavel = true;


                if (Executavel == false && estaLimpo == true) {


                    Console.WriteLine("Já ESTA LIMPO, NAO É PRECISO LIMPAR DENOVO.");
                    Executavel = false;
                }
            }
            Console.WriteLine("---------------------------------");
            return this.limpar;
            
        }

        //Reload Cannon
        public string Recarregar() {

            recarregar = "Recarregando... ";
            Console.WriteLine(recarregar);
            estaRecarregado = false;
            Executavel = true;  

            if(estaRecarregado == false) {
                Console.WriteLine("ESTAMOS RECARREGANDO O CANHAO, CAPITAO!");
                Thread.Sleep(3500);
                Console.WriteLine("CANHÃO RECARREGADO E PRONTO PARA UTILIZAR!");
                estaRecarregado = true;
                
            }
            Console.WriteLine("---------------------------------");
            return recarregar;
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
