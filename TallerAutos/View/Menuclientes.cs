namespace TallerAutos.View;

public class Menuclientes
{
    public Menuclientes()
    {

    }

    public int ClientesMenu()
    {
            //Console.Clear();
            Console.WriteLine("1.Registrar cliente");
            Console.WriteLine("2.Registrar Vehiculo");
            Console.WriteLine("3.Listar vehiculos por cliente");
            Console.WriteLine("4.Salir");
            return int.Parse(Console.ReadLine());
    }  
}
