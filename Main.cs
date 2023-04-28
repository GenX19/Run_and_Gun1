using System;

class Program
{
    static void Main(string[] args)
    {
        /*rsonaje nuevo_personaje = new Personaje("Mago", 60, 10, 100);
        Personaje nuevo_enemigo = new Personaje("Bowser", 30, 10, 50);
        nuevo_personaje.atacar(nuevo_enemigo);
        nuevo_enemigo.atributos();*/

        Mago mago_uno = new Mago("Gandal", 30, 20, 100, 5);
        mago_uno.cambiar_libro();
        Esqueleto esqueleto_uno = new Esqueleto("Skull",35, 10, 50,5);

        mago_uno.atacar(esqueleto_uno);
        esqueleto_uno.atacar(mago_uno);
        mago_uno.atributos();
        esqueleto_uno.atributos();
    }
}

