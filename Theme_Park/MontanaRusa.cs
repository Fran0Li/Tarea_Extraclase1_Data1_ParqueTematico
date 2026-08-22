//Clase hija de Atraccion (Hereda de Atraccion, segunda en la jerarquía)
public class MontanaRusa : Atraccion
{
    //Atributos para la montaña rusa
    private float alturaMax;
    private bool deCabeza; //Se refiere a que si en alguna parte el usuario queda de cabeza durante el recorrido.
    //Constructor: hereda de la padre (nombre, capacidadMax)
    public MontanaRusa(string nombre, int capacidadMax, float alturaMax, bool deCabeza) : base(nombre, capacidadMax)
    {
        this.alturaMax = alturaMax;
        this.deCabeza = deCabeza;
    }
    //Métodos
    //Override para ObtenerInfo, agrega atributos propios de esta clase
    public override void ObtenerInfo()
    {
        base.ObtenerInfo();
        Console.WriteLine($"Altura Máxima: {this.alturaMax} metros");
        if (this.deCabeza)
        {
            Console.WriteLine("Tiene una parte que es de cabeza");
        }
        else
        {
            Console.WriteLine("No tiene una parte que sea de cabeza");
        }
        
    }
    public float GetAlturaMax()
    {
        return this.alturaMax;
    }
    public void SetAlturaMax(float altura)
    {
        if (altura > 0)
        {
            this.alturaMax = altura;
        }
        else
        {
            Console.WriteLine("La altura máxima debe ser un valor entero positivo");
        }
    }
    public bool GetDeCabeza()
    {
        return this.deCabeza;
    }
    public void SetDeCabeza(bool deCabeza)
    {
        this.deCabeza = deCabeza; 
    }
}