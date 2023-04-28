using System;

class Esqueleto: Personaje
{
    public int espada;

    public Esqueleto(string nombre, int fuerza, int defensa, int vida, int espada) : base(nombre, fuerza, defensa, vida)
    {
        this.espada = espada;
        this.espada = 15;
    }

    public new void atributos()
    {
        base.atributos();
        Console.WriteLine("·Espada: " + this.espada);
    }

    public new int daño(Personaje enemigo)
    {
        return this.fuerza * this.espada - enemigo.defensa;
    }
}

