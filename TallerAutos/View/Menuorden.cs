namespace TallerAutos.View;

public class Menuorden
{
    public Menuorden()
    {

    }

    public int MenuOrden()
    {
            //Console.Clear();
            Console.WriteLine("1.Agregar Orden");
            Console.WriteLine("2.Agregar diagnosticos de experto a una orden");
            System.Console.WriteLine("3.Ver ordenes de aprobracion del cliente");
            Console.WriteLine("4.Salir");

            return int.Parse(Console.ReadLine());
    }  
}
