using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace TallerAutos.Clases;
class Vehiculo
{
    public string placa { get; set; }
    public string marca { get; set; }
    public int kilometraje { get; set; }
    public Vehiculo(string placa, string marca, int kilometraje)
    {
        this.placa = placa;
        this.marca = marca;
        this.kilometraje = kilometraje;
    }
    public Vehiculo() { }
    public Vehiculo AgregarVehiculo()
    {
        System.Console.WriteLine("Ingrese la placa del vehiculo");
        string placa=Console.ReadLine();
        System.Console.WriteLine("Ingrese la marca:");
        string marca=Console.ReadLine();
        System.Console.WriteLine("Ingrese el kilometraje");
        int kilometraje=int.Parse(Console.ReadLine());
        Vehiculo vehiculo=new Vehiculo(placa, marca, kilometraje);
        return vehiculo;
    }
    public Vehiculo BuscarVehiculo(Cliente cliente){
        System.Console.WriteLine($"Ingrese la placa del vehiculo del cliente {cliente.Nombre} al que se le va a hacer la orden");
        string opcion=Console.ReadLine();
        return cliente.vehiculos.Find(e => e.placa.Equals(opcion));
    }
}