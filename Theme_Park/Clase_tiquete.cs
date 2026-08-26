public class Tiquete
{
    private Atraccion atraccion; //A que atraccion pertenece
    private bool usado;
    public Tiquete(Atraccion atraccion)
    {
        this.atraccion = atraccion;
        this.usado = false; // Se vuelve verdadero hasta que lo utilicen
    }
    //Métodos
    public void UsarTiquete()//lo marca como usado
    {
       if(this.usado == false)
        {
            this.usado == true;
            Console.WriteLine($"Se ha usado este tiquete para la atracción: {this.atraccion.GetNombre()}");
        }
        else
        {
            Console.WriteLine("Ya se usó este tiquete");
        }

    }
    public void ObtenerInfo()
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("INFO de tiquete");
        Console.WriteLine($"Atracción: {this.atraccion.GetNombre()}");
        if (this.usado)
        {
            Console.WriteLine("Este tiquete ya fue usado");
        }
        else
        {
            Console.WriteLine("No se ha usado este tiquete");
        }
    }
     public Atraccion GetAtraccion()
    {
        return this.atraccion;
    }
    public bool GetUsado()
    {
        return this.usado;
    }
}