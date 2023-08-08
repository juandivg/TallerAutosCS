using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace TallerAutos.Clases;
class Orden
{
    public string idOrden { get; set; }
    private int idCliente;
    public int IdCliente
    {
        get { return idCliente; }
        set { idCliente = value; }
    }
    public string nombreCliente { get; set; }
    public string fecha { get; set; }
    public string placa { get; set; }
    public int kilometraje { get; set; }
    private int idEmpleado;
    public int IdEmpleado
    {
        get { return idEmpleado; }
        set { idEmpleado = value; }
    }
    public string nombreEmpleado { get; set; }
    public string especialidadEmpleado { get; set; }
    public string diagnosticoCliente { get; set; }
    private int idExperto;
    public int IdExperto
    {
        get { return idExperto; }
        set { idExperto = value; }
    }
    public string nombreExperto { get; set; }
    public List<string> diagnosticos{ get; set; } = new List<string>();
    public List <Ordenaprobacion> ordenesAprobar{ get; set; }=new List<Ordenaprobacion>();
    public Orden(string idOrden, int IdCliente, string nombreCliente, string fecha, string placa, int kilometraje, int IdEmpleado, string nombreEmpleado, string especialidadEmpleado, string diagnosticoCliente, int IdExperto, string nombreExperto){
        this.idOrden = idOrden;
        this.IdCliente = IdCliente;
        this.nombreCliente = nombreCliente;
        this.fecha = fecha;
        this.placa = placa;
        this.kilometraje = kilometraje;
        this.IdEmpleado= IdEmpleado;
        this.nombreEmpleado = nombreEmpleado;
        this.especialidadEmpleado = especialidadEmpleado;
        this.diagnosticoCliente = diagnosticoCliente;
        this.IdExperto= IdExperto;
        this.nombreExperto=nombreExperto;

    }
    public Orden(){}
    public Orden AgregarOrden(Cliente cliente, Vehiculo vehiculo, Empleado empleado, Experto experto){
        string idOrden = Guid.NewGuid().ToString();
        string fecha=DateTime.Now.ToString("");
        System.Console.WriteLine("Ingrese el diagnostico del cliente");
        string diagnosticoCliente=Console.ReadLine();
        Orden orden=new Orden(idOrden, cliente.Id, cliente.Nombre, fecha, vehiculo.placa, vehiculo.kilometraje, empleado.Id, empleado.Nombre, empleado.Especialidad, diagnosticoCliente, experto.Id, experto.Nombre);
        return orden;
    }
    public void AgregarDiagnostico(Orden orden)
    {
        System.Console.WriteLine("Agregue un diagnostico del experto");
        string diagnostico = Console.ReadLine();
        orden.diagnosticos.Add(diagnostico);
        //cliente.ordenes.Add(orden);
    }
    public Orden BuscarOrden(Cliente cliente){
        ListarOrdenes(cliente);
        System.Console.WriteLine("Ingrese el numero de la orden");
        string opcion=Console.ReadLine();
        return cliente.ordenes.Find(e => e.idOrden.Equals(opcion));
    }
    public void ListarOrdenes(Cliente cliente){
        System.Console.WriteLine($"Lista de ordenes para el cliente {cliente.Nombre}");
        foreach(Orden orden in cliente.ordenes){
            System.Console.WriteLine("********************DATOS DE LA ORDEN*********************");
            System.Console.WriteLine($"\tNro de orden: {orden.idOrden}\tFecha orden: {orden.fecha}");
            System.Console.WriteLine($"\tId de cliente: {orden.IdCliente}\tNombre cliente: {orden.nombreCliente}");
            System.Console.WriteLine("********************DATOS DEL VEHICULO*********************");
            System.Console.WriteLine($"\tNro de placa: {orden.placa}\tKilometraje: {orden.kilometraje}");
            System.Console.WriteLine("********************DIAGNOSTICO DEL CLIENTE*********************");
            System.Console.WriteLine($"\t{orden.diagnosticoCliente}");
            System.Console.WriteLine("********************PERSONAL A CARGO*********************");
            System.Console.WriteLine($"\tId de empleado: {orden.IdEmpleado}\tNombre Empleado: {orden.nombreEmpleado}\tEspecialidad:{orden.especialidadEmpleado}");
            System.Console.WriteLine("********************DATOS DEL EXPERTO*********************");
            System.Console.WriteLine($"\tId de experto: {orden.IdExperto}\tNombre Experto: {orden.nombreExperto}");
            System.Console.WriteLine("********************DIAGNOSTICOS DEL EXPERTO*********************");
            foreach(string diagnostico in orden.diagnosticos){
                System.Console.WriteLine($"{diagnostico}\n");
            }
        }
        System.Console.WriteLine("**********************************************************************");

        Console.ReadKey();
    }



}