using System;
using System.Threading.Tasks;
namespace PirateGame {
    interface pyhsicalCombat {

        //Modificadores de acesso de interface é public ou abstract. Portanto não faria muita diferença  utilizar uma classe abstrata ou n.
        //Interfaces podem possuir somente métodos e propriedades.

        void EscolherArma();

        void AtirarTiro();

        void Golpear();

        int darDano();
        int receberDano();
    }
}
