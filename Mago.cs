using System;

class Mago : Personaje
{
    public int libro;

    public Mago(string nombre, int fuerza, int defensa, int vida, int libro) : base(nombre, fuerza, defensa, vida)
    {
        this.libro = libro;
    }

    public void cambiar_libro()
    {
        Console.Write("Elige un libro: (1) Fuerza bestial, daño 8. (2) Aniquilacion, daño 10: ");
        int opcion = int.Parse(Console.ReadLine());
        if (opcion == 1)
        {
            this.libro = 8;
        }
        else if (opcion == 2)
        {
            this.libro = 10;
        }
        else
        {
            Console.WriteLine("Número de libro incorrecto");
        }
    }

    public new void atributos()
    {
        base.atributos();
        Console.WriteLine("·libro: " + this.libro);
    }

    public new int daño(Personaje enemigo)
    {
        return this.fuerza * this.libro - enemigo.defensa;
    }
}
