class Program
{
    static void Main(string[] args)
    {
        //Instanciar
        //Pruebas de clase padre 
        MontanaRusa montana = new MontanaRusa("Montaña Rusa", 24, 20, true);
        montana.ObtenerInfo();
        montana.Operar();

        montana.DarMantenimiento();
        montana.Operar();

        montana.FinalizarMantenimiento();
        montana.Operar();

        montana.SetNombre("Boomerang");
        montana.SetCapacidadMaxima(30);
        montana.SetCapacidadMaxima(-5);
        montana.GetAlturaMax();
        montana.SetAlturaMax(18);
        montana.GetDeCabeza();
        montana.SetDeCabeza(false);


        montana.ObtenerInfo();
    }
}