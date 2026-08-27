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

        //Pruebas de clase Ticket
        Ticket ticketMontana = new Ticket(montana); //reutiliza la instancia de MontanaRusa
        ticketMontana.ObtenerInfo();

        ticketMontana.UsarTicket(); 
        ticketMontana.UsarTicket(); 

        ticketMontana.ObtenerInfo();
        /*
        CarruselNuevo = new Carrusel("Carrusel Animalitos", 20, 10, 120);
        CarruselNuevo.ObtenerInfo()
        CarruselNuevo.CumpleEstatura(134)
        CarruselNuevo.CumpleEstatura(119)*/
    }
}