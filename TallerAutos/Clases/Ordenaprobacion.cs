using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace TallerAutos.Clases;

class Ordenaprobacion{
    public string ordenId { get; set; }
    public string fecha { get; set; }
    public int empleadoId { get; set; }
    public List <Item> items{ get; set; }=new List<Item>();
    public Ordenaprobacion(string ordenId, string fecha, int empleadoId){
        this.ordenId=ordenId;
        this.fecha=fecha;
        this.empleadoId=empleadoId;
    }
    public Ordenaprobacion(){}
    public Ordenaprobacion AgregarOrdenAprobacion(Orden orden){
        string fecha=DateTime.Now.ToString("");
        Ordenaprobacion ordenaprobacion= new Ordenaprobacion(orden.idOrden, fecha, orden.IdEmpleado );
        Item item=new Item();
        string continuar="S";
        System.Console.WriteLine("---------Agregar Items a la orden de aprobacion-----------");
        while(continuar=="S"){
            Item itemOpcion;
            itemOpcion=item.AgregarItem();
            ordenaprobacion.items.Add(itemOpcion);
            System.Console.WriteLine("Desea agregar otro item a la orden de aprobacion? (S/N)");
            continuar=Console.ReadLine();
        }
        return ordenaprobacion;

    }
    public void MostrarOrdenesAprobacion(Orden orden){
        
        foreach(Ordenaprobacion ordenaprobacion in orden.ordenesAprobar){
            System.Console.WriteLine("*******************************************************");
            System.Console.WriteLine($"Nro Orden: {ordenaprobacion.ordenId}");
            System.Console.WriteLine($"Fecha: {ordenaprobacion.fecha}");
            System.Console.WriteLine($"Id Empleado: {ordenaprobacion.empleadoId}");
            System.Console.WriteLine("****************DETALLE DE APROBACION******************");
            System.Console.WriteLine($"Item \tRepuesto\tValor unidad\tCantidad\tValor total\tEstado");

            foreach(Item item in ordenaprobacion.items){
                System.Console.WriteLine($"{item.id}\t{item.repuesto}\t{item.valorUnidad}\t{item.cantidad}\t{item.valorTotal}\t{item.aprobacion}");
            }

        }
        System.Console.WriteLine("*******************************************************");
        Console.ReadKey();

    }

}