using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace TallerAutos.Clases;
class Persona
{
    private int id;
    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    
    private string nombre;
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    
    private string celular;
    public string Celular
    {
        get { return celular; }
        set { celular = value; }
    }
    
    public Persona(int id, string nombre, string celular)
    {
        this.Id = id;

        this.Nombre = nombre;

        this.Celular = celular;
    }
    public Persona() { }
}