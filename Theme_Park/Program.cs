class Program
{
    static void Main(string[] args)
    {
       /* //Instanciar
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


        montana.ObtenerInfo();*/
        //Pruebas de clase Usuario
        Usuario juan = new Usuario("Juan", 21, false);
        juan.ObtenerInfo();

        juan.UsarAtraccion(); 

        juan.ComprarTiquete();
        juan.ComprarTiquete();
        juan.ObtenerInfo(); 

        juan.UsarAtraccion(); 
        juan.ObtenerInfo(); 

        juan.SetEdad(21);
        juan.SetPaseEspecial(true);
        juan.ObtenerInfo(); 

        juan.UsarAtraccion(); 
        juan.ObtenerInfo(); 
    }
}