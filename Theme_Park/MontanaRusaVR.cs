
//Ejemplo de HERENCIA: MontanaRusaVR hereda de MontanaRusa, que a su vez hereda de Atraccion (nivel 3)
public class MontanaRusaVR : MontanaRusa
{
    //Ejemplo de ENCAPSULAMIENTO: atributos private, solo accesibles mediante getters/setters
    //Ejemplo de TIPOS DE DATOS: string, int
    private string temaRealidadVirtual;
    private int nivelBateriaLentes;

    //Constructor: usa "base(...)" para reutilizar el constructor de la clase padre
    public MontanaRusaVR(string nombre, int capacidadMax, float alturaMax, bool deCabeza, string temaRealidadVirtual) 
        : base(nombre, capacidadMax, alturaMax, deCabeza)
    {
        this.temaRealidadVirtual = temaRealidadVirtual;
        this.nivelBateriaLentes = 100;
    }

    //Ejemplo de POLIMORFISMO: sobrescribe (override) el comportamiento de Operar() definido en la clase padre
    public override void Operar()
    {
        if (this.nivelBateriaLentes < 20)
        {
            Console.WriteLine("Los lentes de realidad virtual tienen poca batería, no se puede operar");
        }
        else
        {
            base.Operar();
            this.nivelBateriaLentes -= 15;
        }
    }

    public override void ObtenerInfo()
    {
        base.ObtenerInfo();
        Console.WriteLine($"Experiencia VR: {this.temaRealidadVirtual}");
        Console.WriteLine($"Batería de lentes: {this.nivelBateriaLentes}%");
        Console.WriteLine("-----------------------------------");
    }

    //Ejemplo de MÉTODO propio de esta clase, no existe en las clases padre
    public void RecargarLentes()
    {
        this.nivelBateriaLentes = 100;
        Console.WriteLine($"Los lentes VR de {this.GetNombre()} fueron recargados al 100%");
    }

    public string GetTemaRealidadVirtual()
    {
        return this.temaRealidadVirtual;
    }

    public void SetTemaRealidadVirtual(string tema)
    {
        this.temaRealidadVirtual = tema;
    }

    public int GetNivelBateriaLentes()
    {
        return this.nivelBateriaLentes;
    }

    //Ejemplo de ENCAPSULAMIENTO: el setter valida el dato antes de guardarlo
    public void SetNivelBateriaLentes(int nivel)
    {
        if (nivel >= 0 && nivel <= 100)
        {
            this.nivelBateriaLentes = nivel;
        }
        else
        {
            Console.WriteLine("El nivel de batería debe estar entre 0 y 100");
        }
    }
}