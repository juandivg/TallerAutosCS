using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace TallerAutos.Clases;

class Item{
    public string id { get; set; }
    public string repuesto{ get; set; }
    public int valorUnidad{ get; set; }
    public int cantidad{ get; set; }
    public int valorTotal{ get; set; }
    public string aprobacion{ get; set; }
    public Item(string id, string repuesto, int valorUnidad, int cantidad, int valorTotal, string aprobacion){
        this.id = id;
        this.repuesto = repuesto;
        this.valorUnidad=valorUnidad;
        this.cantidad=cantidad;
        this.valorTotal=valorTotal;
        this.aprobacion=aprobacion;
    }
    public Item(){}
    public Item AgregarItem(){
        System.Console.WriteLine("Ingrese el Id del item");
        string id=Console.ReadLine();
        System.Console.WriteLine("Ingrese el nombre del repuesto");
        string repuesto=Console.ReadLine();
        System.Console.WriteLine("Ingrese el valor por unidad del repuesto");
        int valorUnidad=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Ingrese la cantidad requerida del repuesto");
        int cantidad=int.Parse(Console.ReadLine());
        int valorTotal=cantidad*valorUnidad;
        System.Console.WriteLine("Ingrese si el cliente aprobo o reprobo este item (A/R):");
        string aprobacion=Console.ReadLine();
        Item item= new Item(id, repuesto, valorUnidad, cantidad, valorTotal, aprobacion);
        return item;
    }
}