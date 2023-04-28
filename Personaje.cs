using System;

//Definimos nuestra clase padre llamada Personaje
public class Personaje
{
    //Asignamos sus atributos
    public string nombre;
    public int fuerza;
    public int defensa;
    public int vida;

    //Declaramos el metodo constructor.
    public Personaje(string nombre, int fuerza, int defensa, int vida)
    {
        this.nombre = nombre;
        this.fuerza = fuerza;
        this.defensa = defensa;
        this.vida = vida;
    }

    //Imprimimos lo asignado por el metodo constructor.
    public void atributos()
    {
        Console.WriteLine($"{nombre}:");
        Console.WriteLine($"·Fuerza: {fuerza}");
        Console.WriteLine($"·Defensa: {defensa}");
        Console.WriteLine($"·Vida: {vida}");
    }

    //A partir de aqui declaramos nuestros metodos.
    public bool esta_vivo() //El metodo esta_vivo es un booleano que nos indica el estado del personaje.
    {
        return vida > 0;
    }

    public void morir() //El metodo morir nos ayuda a que la vida del personje no baje de 0, osea que al recibir mucho daño su vida no quede en numeros negativos.
    {
        vida = 0;
        Console.WriteLine($"{nombre} ha muerto");
    }

    public int daño(Personaje enemigo) //El metodo daño nos mostrara el daño real de nuestro personaje.
    {
        return fuerza - enemigo.defensa;
    }

    public void atacar(Personaje enemigo) //El metodo atacar usara los tres metodos anteriores para el proceso de peleas en el juego.
    {
        int dano = daño(enemigo);
        enemigo.vida = enemigo.vida - dano;
        Console.WriteLine(nombre + " ha realizado " + dano + " puntos de daño a " + enemigo.nombre);
        if (enemigo.esta_vivo())
        {
            Console.WriteLine("Vida de " + enemigo.nombre + " es " + enemigo.vida);
        }
        else
        {
            enemigo.morir();
        }
    }

}