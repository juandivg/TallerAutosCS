using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace TallerAutos.Clases;
class Experto : Persona
{
    
    public Experto(int id, string nombre, string celular) : base(id, nombre, celular)
    { }
    public Experto() { }
    public Experto AgregarExperto()
    {
        System.Console.WriteLine("Id del experto:");
        int id = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Nombre del experto");
        string nombre = Console.ReadLine();
        System.Console.WriteLine("Celular del experto");
        string celular = Console.ReadLine();
        Experto experto = new Experto(id, nombre, celular);
        return experto;
    }

}