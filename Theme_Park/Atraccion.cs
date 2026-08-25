//Clase Padre Atracción
public class Atraccion
{
    //Atributos, private para ejemplificar el encapsulamiento
    private string nombre;
    private int capacidadMax;
    private bool estaFuncionando;
    
    //Constructor, para luego instanciar
    public Atraccion(string nombre, int capacidadMax)
    {
        this.nombre = nombre;
        this.capacidadMax = capacidadMax;
        this.estaFuncionando = true; //Funciona predeterminadamente
    }

    //Métodos para el polimorfismo
    public virtual void Operar()//Virtual permite que se pueda sobrescribir este método en clases hijas
    {
        if (this.estaFuncionando)
        {
            Console.WriteLine($"La atracción {this.nombre} ahora está operando");
        }
        else
        {
            Console.WriteLine($"La atracción {this.nombre} no está funcionando, por lo tanto, no puede operarse");
        }
    }
    public virtual void DarMantenimiento()
    {
        this.estaFuncionando = false;
        Console.WriteLine($"A la atraccion {this.nombre} se le esta dando mantenimiento, la atraccion ya no está funcionando");
    }
    public virtual void FinalizarMantenimiento()
    {
        this.estaFuncionando = true;
        Console.WriteLine($"La atraccion {this.nombre} terminó su mantenimiento, ahora ya está funcionando");
    }
    public virtual void ObtenerInfo()
    {
      Console.WriteLine("-----------------------------------"); 
      Console.WriteLine("INFO de atracción");
      Console.WriteLine($"Nombre: {this.nombre}, Capacidad Máxima: {this.capacidadMax}");
      if (this.estaFuncionando)
        {
            Console.WriteLine("Está funcionado");
        }
        else
        {
            Console.WriteLine("No está funcionando");
        } 
    }
    //Métodos getters y setters
    public string GetNombre()
    {
        return this.nombre;
    }
    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }
    public int GetCapacidadMax()
    {
        return this.capacidadMax;
    }
    public void SetCapacidadMaxima(int capacidad)
    {
        if (capacidad > 0)
        {
            this.capacidadMax = capacidad;
        }
        else
        {
            Console.WriteLine("La capacidad máxima debe ser un entero positivo");
        }
    }
}