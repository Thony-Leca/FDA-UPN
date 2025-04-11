
class compra_IGV
{
    static void Main(string[] args)
    {
        double igv;
        string name_producto;
        double precio;
        double total_compra;
        igv = 1.18;
        Console.WriteLine("Genera tu compra");
        Console.WriteLine("Escribe el nombre del producto:");
        name_producto = Console.ReadLine();
        Console.WriteLine("Escribe el precio del producto:");
        precio = Double.Parse(Console.ReadLine());
        total_compra = precio * igv;
        Console.WriteLine("El total por tu producto llamado " + name_producto + " es S/" + total_compra + " incluido IGV.");
    }
}
