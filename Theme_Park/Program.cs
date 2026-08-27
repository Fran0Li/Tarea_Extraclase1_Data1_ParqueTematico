class Program
{
    static void Main(string[] args)
    {
       //Pruebas de instancia del funcionamiento general
       
       //Prueba: Clase padre atraccion con hija Montaña rusa
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
        montana.SetAlturaMax(18);
        montana.SetDeCabeza(false);
        montana.ObtenerInfo();

        //Prueba Montaña rusa vr, herencia nivel 3, hija de montaña rusa
        MontanaRusaVR vr = new MontanaRusaVR("Realidad Alterna", 8, 15, false, "Aventura Espacial");
        vr.ObtenerInfo();
        vr.Operar(); //Baja batería a 85%
        vr.Operar(); //Baja a 70%
        vr.ObtenerInfo();

        vr.SetNivelBateriaLentes(15); //La pone en baja para que no pueda operar
        vr.Operar();

        vr.RecargarLentes();
        vr.Operar(); 

        //Pruebas Carrusel, hija de atraccion, otra rama de herencia
        Carrusel carruselNuevo = new Carrusel("Carrusel Animalitos", 20, 10, 120);
        carruselNuevo.ObtenerInfo();
        Console.WriteLine(carruselNuevo.CumpleEstatura(134)); 
        Console.WriteLine(carruselNuevo.CumpleEstatura(119)); 

        //Pruebas clase usuario
        Usuario juan = new Usuario("Juan", 21, false);
        juan.MostrarInfo();

        juan.PuedeUsarAtraccion(montana);

        juan.ComprarTiquete();
        juan.ComprarTiquete();
        juan.MostrarInfo();

        juan.PuedeUsarAtraccion(montana);
        juan.MostrarInfo();

        juan.SetPaseEspecial(true);
        juan.MostrarInfo();

        juan.PuedeUsarAtraccion(montana); //Con pase especial, no gasta tiquete
        juan.MostrarInfo();

        // atracción en mantenimiento bloquea el acceso, aunque tenga pase especial
        montana.DarMantenimiento();
        juan.PuedeUsarAtraccion(montana); 

        montana.FinalizarMantenimiento(); 
        
        //Pruebas clase Tiquete
        Tiquete tiqueteMontana = new Tiquete(montana);
        tiqueteMontana.ObtenerInfo();

        tiqueteMontana.UsarTiquete(); //Primera vez: se marca como usado
        tiqueteMontana.UsarTiquete(); //Segunda vez: debería avisar que ya se usó
        tiqueteMontana.ObtenerInfo();
    }
}