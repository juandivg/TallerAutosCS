using TallerAutos.View;
using TallerAutos.Clases;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Cliente> clientes = new List<Cliente>();
        Cliente cliente = new Cliente();
        Cliente clienteOpcion;
        Vehiculo vehiculo = new Vehiculo();
        Vehiculo vehiculoOpcion;
        Empleado empleado = new Empleado();
        Empleado empleadoOpcion;
        Experto experto = new Experto();
        Experto expertoOpcion;
        Orden orden = new Orden();
        Orden ordenOpcion = new Orden();
        Ordenaprobacion ordenaprobacion= new Ordenaprobacion();
        Ordenaprobacion ordenaprobacionOpcion;
        Factura factura= new Factura();

        Menuprincipal menu = new Menuprincipal();
        int opcion = 0;
        do
        {
            opcion = menu.Menu();
            switch (opcion)
            {
                case 1:
                    int opcionCliente = 0;
                    Menuclientes menuclientes = new Menuclientes();

                    do
                    {
                        opcionCliente = menuclientes.ClientesMenu();
                        switch (opcionCliente)
                        {
                            case 1:
                                clienteOpcion = cliente.AgregarCliente();
                                clientes.Add(clienteOpcion);
                                break;
                            case 2:
                                clienteOpcion = cliente.BuscarCliente(clientes);
                                vehiculoOpcion = vehiculo.AgregarVehiculo();
                                clienteOpcion.vehiculos.Add(vehiculoOpcion);

                                break;
                            case 3:
                                cliente.ListarVehiculos(clientes);
                                break;
                            case 4:
                                break;
                            default:
                                break;
                        }
                    } while (opcionCliente != 4);

                    break;
                case 2:
                    int opcionOrden = 0;
                    Menuorden menuorden = new Menuorden();
                    do
                    {
                        opcionOrden = menuorden.MenuOrden();
                        switch (opcionOrden)
                        {
                            case 1:
                                AgregarOrdenes();
                                break;

                            case 2:
                                Diagnosticos();

                                break;
                            case 3:
                                ListarOrdenesAprobacion();
                                break;
                            case 4:

                                break;
                        }

                    } while (opcionOrden != 4);
                    break;
                case 3:
                    FacturaMostrar();
                    break;
                case 4:
                    break;
            }
        } while (opcion != 4);
        void AgregarOrdenes()
        {
            clienteOpcion = cliente.BuscarCliente(clientes);
            cliente.VehiculosCliente(clienteOpcion);
            vehiculoOpcion = vehiculo.BuscarVehiculo(clienteOpcion);
            empleadoOpcion = empleado.AgregarEmpleado();
            expertoOpcion = experto.AgregarExperto();
            ordenOpcion = orden.AgregarOrden(clienteOpcion, vehiculoOpcion, empleadoOpcion, expertoOpcion);
            clienteOpcion.ordenes.Add(ordenOpcion);
        }
        void Diagnosticos(){
            clienteOpcion = cliente.BuscarCliente(clientes);
            ordenOpcion=orden.BuscarOrden(clienteOpcion);
            orden.AgregarDiagnostico(ordenOpcion);
            ordenaprobacionOpcion=ordenaprobacion.AgregarOrdenAprobacion(ordenOpcion);
            ordenOpcion.ordenesAprobar.Add(ordenaprobacionOpcion);


        }
        void ListarOrdenesAprobacion(){
            clienteOpcion = cliente.BuscarCliente(clientes);
            ordenOpcion=orden.BuscarOrden(clienteOpcion);
            ordenaprobacion.MostrarOrdenesAprobacion(ordenOpcion);

        }
        void FacturaMostrar(){
            clienteOpcion = cliente.BuscarCliente(clientes);
            ordenOpcion=orden.BuscarOrden(clienteOpcion);
            factura.MostrarFactura(ordenOpcion);

        }
    }

}