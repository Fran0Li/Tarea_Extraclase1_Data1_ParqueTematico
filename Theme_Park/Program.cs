class Program
{
    static void Main(string[] args)
    {
        //Instanciar
        //Pruebas de clase padre 
        Atraccion montana = new Atraccion("Montaña Rusa", 24);
        montana.ObtenerInfo();
        montana.Operar();

        montana.DarMantenimiento();
        montana.Operar();

        montana.FinalizarMantenimiento();
        montana.Operar();

        montana.SetNombre("Boomerang");
        montana.SetCapacidadMaxima(30);
        montana.SetCapacidadMaxima(-5);

        montana.ObtenerInfo();
    }
}