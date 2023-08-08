using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace TallerAutos.Clases;

class Cliente: Persona{
    private string email;
    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    
    public string fechaRegistro { get; set; }
    public List <Vehiculo> vehiculos{ get; set; }= new List<Vehiculo>();
    public List <Orden> ordenes { get; set; }=new List<Orden>();
    public Cliente(int id, string nombre, string celular, string email, string fechaRegistro):base(id, nombre, celular){
        this.email = email;
        this.fechaRegistro = fechaRegistro;
    }
    public Cliente(){}
    public Cliente AgregarCliente(){
        System.Console.WriteLine("Id del cliente:");
        int id=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Nombre del cliente");
        string nombre=Console.ReadLine();
        System.Console.WriteLine("Celular del cliente");
        string celular=Console.ReadLine();
        System.Console.WriteLine("Email del cliente");
        string email=Console.ReadLine();
        string fecha=DateTime.Now.ToString("");
        Cliente cliente =new Cliente(id,nombre,celular,email,fecha);
        return cliente;

    }
    public  Cliente BuscarCliente(List <Cliente> clientes){
        ListarClientes(clientes);
        Console.ReadKey();
        System.Console.WriteLine("Ingrese el Id del cliente");
        int opcion = int.Parse(Console.ReadLine()); 
        return clientes.Find( e => e.Id == opcion );
    }
    public void ListarClientes(List <Cliente> clientes){
        System.Console.WriteLine($"Id del cliente \tNombre\tCelular\tEmail\tFecha de registro");
        foreach(Cliente cliente in clientes){
            System.Console.WriteLine($"{cliente.Id}\t{cliente.Nombre}\t{cliente.Celular}\t{cliente.Email}\t{cliente.fechaRegistro}");
        }
    }
    public void ListarVehiculos(List <Cliente> clientes){
        foreach(Cliente cliente in clientes){
            System.Console.WriteLine($"El cliente con id {cliente.Id} tiene los automoviles:");
            System.Console.WriteLine($"Placa del vehiculo\tNombre del vehiculo\tKilometraje");
            foreach (Vehiculo vehiculo in cliente.vehiculos){
                System.Console.WriteLine($"{vehiculo.placa}\t{vehiculo.marca}\t{vehiculo.kilometraje}");
            }
        }
        Console.ReadKey();
    }
    public void VehiculosCliente(Cliente cliente){
        Console.WriteLine($"Vehiculos de {cliente.Nombre}: ");
        foreach(Vehiculo vehiculo in cliente.vehiculos){
            System.Console.WriteLine($"{vehiculo.placa}\t{vehiculo.marca}\t{vehiculo.kilometraje}");
        }
    }
}
