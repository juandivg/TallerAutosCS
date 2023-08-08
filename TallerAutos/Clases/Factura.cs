using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace TallerAutos.Clases;
class Factura{
    public string OrdenNum { get; set; }
    public string idFactura { get; set; }
    public int clienteId { get; set; }
    public Factura(string OrdenNum, string idFactura, int clienteId){
        this.OrdenNum = OrdenNum;
        this.idFactura = idFactura;
        this.clienteId = clienteId;
    }
    public Factura(){}
    public Factura AgregarFactura(Orden orden){
        string idFactura=Guid.NewGuid().ToString();
        Factura factura=new Factura(orden.idOrden, idFactura, orden.IdCliente);
        return factura;
    }
    public void MostrarFactura(Orden orden){
        Factura facturaOpcion=AgregarFactura(orden);
        int subtotal=0;
        double manodeObra=0;
        System.Console.WriteLine("**********************************************************************");
        System.Console.WriteLine($"No. orden: {facturaOpcion.OrdenNum}");
        System.Console.WriteLine($"No. factura: {facturaOpcion.idFactura}");
        System.Console.WriteLine($"Id cliente: {facturaOpcion.clienteId}");
        System.Console.WriteLine($"Item \tRepuesto\tValor unidad\tCantidad\tSubtotal");
        foreach(Ordenaprobacion ordenaprobacion in orden.ordenesAprobar){
                foreach(Item item in ordenaprobacion.items){
                    if(item.aprobacion=="A"){
                        System.Console.WriteLine($"{item.id}\t{item.repuesto}\t{item.valorUnidad}\t{item.cantidad}\t{item.valorTotal}");
                        subtotal+=item.valorTotal;
                        manodeObra+=0.1*item.valorUnidad;
                    }
                
            }
        }
        System.Console.WriteLine("---------------------------------------------------------------------");
        System.Console.WriteLine($"Subtotal: {subtotal}");
        System.Console.WriteLine($"Mano de obra: {manodeObra}");
        System.Console.WriteLine($"Total: {subtotal+manodeObra}");
        System.Console.WriteLine("**********************************************************************");
        Console.ReadKey();

    }



}