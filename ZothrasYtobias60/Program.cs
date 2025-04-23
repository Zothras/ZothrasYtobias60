using System.Drawing;
using ZothrasYTobias;
using static System.Runtime.InteropServices.JavaScript.JSType;

void carga(Personaje p)
{
    Console.WriteLine("Ingrese el color de su personaje");
    p.Color = Console.ReadLine();
    Console.WriteLine("Ingrese la cantidad de vida que tiene su personaje");
    p.Vida = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la cantidad de defensa que tiene su personaje");
    p.Defensa = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la cantidad de fuerza que tiene su personaje");
    p.Fuerza = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la cantidad de mana que tiene su personaje");
    p.Mana = int.Parse(Console.ReadLine());
}

void mostramela(Personaje p)
{
    Console.WriteLine("Color: " + p.Color);
    Console.WriteLine("Vida: " + p.Vida);
    Console.WriteLine("Defensa: " + p.Defensa);
    Console.WriteLine("Fuerza: " + p.Fuerza);
    Console.WriteLine("Mana: " + p.Mana);

}

void CambioDeColor (Personaje p) 
{
    string colornuevo;
    Console.WriteLine("El color actual de su personaje (Personaje 1) es: " + p.Color);
    Console.WriteLine("Porfavor indique cual es el nuevo color de su personaje");
    colornuevo = Console.ReadLine();
    p.Color = colornuevo;
    Console.WriteLine("Su nuevo color es: " + p.Color);
}

void RecibirDaño (Personaje p) 
{
    int dañoquemehicieron;
    Console.WriteLine("Aurelion sol bajo desde las estrellas y te escupio con fuego intelestelar, ¿Cuanto daño te ha hecho?");
    dañoquemehicieron = int.Parse(Console.ReadLine());
    p.Vida -= dañoquemehicieron;
    Console.WriteLine("La nueva vida de su personaje es: " );
    Console.WriteLine(" " + p.Vida);
}

void Atacar (Personaje p) 
{


}


Personaje p1 = new Personaje();    
Console.WriteLine("Carga del personaje 1");
carga(p1);
Personaje p2 = new Personaje();
Console.WriteLine("Carga del personaje 2");
carga(p2);
Console.Clear();
Console.WriteLine("Datos del personaje 1: ");
mostramela(p1);
Console.WriteLine("-----------");
Console.WriteLine("Datos del personaje 2: ");
mostramela(p2);

Console.WriteLine("Escriba la accion que quiera hacer a continuacion teniendo en cuenta las distintas opciones, sus opciones son: ");
Console.WriteLine("1: Cambiar Color ");
Console.WriteLine("2: Recibir Daño ");
Console.WriteLine("3: Atacar ");
string accion = Console.ReadLine(); 

switch (accion)
{

    case "Cambiar Color":
        CambioDeColor(p1);
        Console.WriteLine("Los datos de su personaje son: ");
        mostramela(p1);
        break;

    case "Recibir Daño":
        RecibirDaño(p1);
        Console.WriteLine("Los datos de su personaje son: ");
        mostramela(p1);
        break;

    case "Atacar":
        Console.WriteLine("1: 3 ");

        break;
}

Console.ReadKey();

