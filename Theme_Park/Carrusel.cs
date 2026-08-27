//Clase hija de Atraccion 
public class Carrusel: Atraccion
{
    //Atributos para el carrusel
    private int velocidadMax;
    private int estaturaMax; //En cm y por eso esta en int, como es para chiquitos entonces por eso pide altura maxima
    //Constructor: hereda de la padre (nombre, capacidadMax)
    public Carrusel(string nombre, int capacidadMax, int velocidadMax, int estaturaMax): base(nombre, capacidadMax)
    {
        this.velocidadMax = velocidadMax;
        this.estaturaMax = estaturaMax;
    }
    //Metodos
        //Override para ObtenerInfo, agrega atributos propios de esta clase
    public override void ObtenerInfo() //Ejemplo de Poliformismo
    {
        base.ObtenerInfo(); //Llama al método de la clase padre y la ejecuta aquí(de primero)
        Console.WriteLine($"El carrusel {GetNombre()} cuenta con una capacidad de {GetCapacidadMax()} personas,");
        Console.WriteLine($" la atraccion tiene una velocidad maxima de {velocidadMax}");
        Console.WriteLine($" y personas por encima de los {estaturaMax} cm no puede entrar");
        Console.WriteLine("---------------------------------------------");
        }
    
    public string CumpleEstatura(int altura)
    {
        if (altura >= this.estaturaMax)
        {
            string mensaje = "No puede entrar a la atraccion porque excede el limite de altura";
            return mensaje;
        } 
        else
        {
           string mensaje = "Puede subir";
            return mensaje; 
        }
    }
    public int GetEstatura()
    {return this.estaturaMax;}
    public void SetEstatura(int estatura_nueva)
    {
        if (estatura_nueva > 0)
        {
            this.estaturaMax = estatura_nueva;
        }
        else
        {
            Console.WriteLine("La estatura máxima debe ser un valor entero positivo");
        }
    }
}