namespace TallerAutos.View;

public class Menuprincipal
{
    public Menuprincipal()
    {

    }

    public int Menu()
    {
            //Console.Clear();
            Console.WriteLine("1.Clientes");
            Console.WriteLine("2.Ordenes");
            Console.WriteLine("3.Generar Factura");
            Console.WriteLine("4.Salir");
            return int.Parse(Console.ReadLine());
    }  
}
