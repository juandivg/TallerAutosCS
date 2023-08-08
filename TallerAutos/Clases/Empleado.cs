using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace TallerAutos.Clases;
class Empleado : Persona
{
    private string especialidad;
    public string Especialidad
    {
        get { return especialidad; }
        set { especialidad = value; }
    }
    public Empleado(int id, string nombre, string celular, string especialidad) : base(id, nombre, celular)
    {
        this.Especialidad = especialidad;
    }
    public Empleado() { }
    public Empleado AgregarEmpleado()
    {
        System.Console.WriteLine("Id del empleado");
        int id = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Nombre del empleado");
        string nombre = Console.ReadLine();
        System.Console.WriteLine("Celular del empleado");
        string celular = Console.ReadLine();
        System.Console.WriteLine("Especialidad del empleado");
        string especialidad = Console.ReadLine();
        Empleado empleado = new Empleado(id, nombre, celular, especialidad);
        return empleado;
    }

  
}