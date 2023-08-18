using System;
using System.Collections.Generic;
using PirateGame;
using System.Text;

namespace PirateShooting {

    public class Canhao {

        string atirar, limpar, recarregar;
        Random acertar;

      //Shoot cannon
        public string Atirar() {

            atirar = "Atirando canhao";
            Console.WriteLine(atirar);
            return this.atirar;

        }
      
        //Clean cannon
        public string Limpar() {

            limpar = "Limpando Canhao !";
            Console.WriteLine(limpar);
            return limpar;
        } 

        //Reload Cannon
        public string Recarregar() {

            recarregar = "Recarregando... ";
            Console.WriteLine(recarregar);
            return recarregar;
        }

        //Check if you hit the other "Ship" or not.
        public int Acertar() {

            Random acertar = new Random();

            if (acertar.Next(1, 10) % 2 != 0) {

                Console.WriteLine("Malditos olhos, Erramos! ");
            } else {

                Console.WriteLine("Acertamos capitao!");

                return acertar.Next(1, 10);
            }
            return 0;
        }
    }
}
