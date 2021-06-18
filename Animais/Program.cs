using System;

namespace Animais
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro cachorro = new Cachorro();
            cachorro.nome = "Floki";
            cachorro.idadeAnos = 7;
            cachorro.pesoQuilos = 30;
            cachorro.raca = "Pastor-alemão";
            cachorro.castrado = true;

            Gato gato = new Gato();
            gato.cor = "Preto";
            gato.sexo = "macho";
            gato.horasSono = 16;
            gato.feroz = false;
            gato.temDoenca = false;

            Hamster hamster = new Hamster();
            hamster.apelido = "Romeu";
            hamster.curioso = true;
            hamster.comprimentoCm = 7.4;
            hamster.morde = false;
            hamster.filhotesQuantidade = 6;
        }
    }
}