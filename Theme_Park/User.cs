//Clase independiente de usuario
public class Usuario
{
    //Atributos
    private string nombre;
    private int edad;
    private int cantidadTiquetes;
    private bool paseEspecial;
    public Usuario(string nombre, int edad, bool paseEspecial) //Constructor
    {
        this.nombre = nombre;
        this.edad = edad;
        this.cantidadTiquetes = 0;
        this.paseEspecial = paseEspecial;
    } 
    //Métodos
    public void ComprarTiquete()
    {
        this.cantidadTiquetes++;
        Console.WriteLine($"{this.nombre} compró el tiquete exitosamente, ahora tienes {cantidadTiquetes} tiquete/s");
    }
    public bool PuedeUsarAtraccion(Atraccion atraccion) //Valida si el usuario puede usar una atraccion
    {
        if (!atraccion.GetEstaFuncionando())
        {
            Console.WriteLine($"La atracción {atraccion.GetNombre()} está en mantenimiento, no se puede usar");
            return false;
        }
        if (this.paseEspecial)
        {
            Console.WriteLine($"{this.nombre} tiene pase especial, no necesita tiquete");
            return true;
        }
        else if (this.cantidadTiquetes > 0)
        {
            this.cantidadTiquetes--;
            Console.WriteLine($"{this.nombre} puede usar la atracción, tiene tiquete disponible");
            return true;
        }
        else
        {
            Console.WriteLine($"{this.nombre} no tiene pase especial ni tiquetes restantes, no puede usar la atracción");
            return false;
        }
    }
    public void MostrarInfo()
    {
        Console.WriteLine("----------------------------------");
        Console.WriteLine("INFO usuario");
        Console.WriteLine($"Nombre: {this.nombre}, edad: {this.edad}, Tiquetes disponibles: {this.cantidadTiquetes}");
        if (this.paseEspecial)
        {
            Console.WriteLine($"{this.nombre} tiene pase especial");
        }
        else
        {
            Console.WriteLine($"{this.nombre} no tiene pase especial");
        }
        Console.WriteLine("----------------------------------");
    }
    public string GetNombre()
    {
        return this.nombre;
    }
    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }
    public int GetEdad()
    {
        return this.edad;
    }
    public void SetEdad(int edad)
    {
        if (edad > 0)
        {
            this.edad = edad;
        }
        else
        {
            Console.WriteLine("La edad debe ser un número entero positivo");
        }
    }
    public int GetCantidadTiquetes()
    {
        return this.cantidadTiquetes;
    }
    public bool GetPaseEspecial()
    {
        return this.paseEspecial;
    }
    public void SetPaseEspecial(bool paseEspecial)
    {
        this.paseEspecial = paseEspecial;
    }
}