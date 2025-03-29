
using p1bpoo.MisClases;


//pilotos:

Chofer pilot1 = new Chofer("Carter", 30, "A");
Chofer pilot2 = new Chofer("Kanye", 35, "B");
Chofer pilot3 = new Chofer("Tyler", 28, "C");
Chofer pilot4 = new Chofer("Ken Carson", 25, "M");
Chofer pilot5 = new Chofer("Jonatan", 29, "C");

Console.WriteLine("Moto: ");
Moto suzuki = new Moto(2025, "Gris", "Suzuki-Ns 125");
suzuki.InformacionVehiculo();
Console.WriteLine(" ");

Console.WriteLine(suzuki.AsignarPiloto(pilot4));
pilot4.MostrarInformación();
pilot4.MostrarValidacion();
Console.WriteLine(" ");

suzuki.Encender();
suzuki.acelerar(100);
suzuki.HacerCaballito();
suzuki.Frenar(20);
suzuki.acelerar(130);
suzuki.Frenar(50);
suzuki.Frenar(20);
suzuki.HacerCaballito();
suzuki.Apagar();

Console.WriteLine("----------------------------------------------------------------------\n");
Console.WriteLine("----------------------------------------------------------------------\n");

Console.WriteLine("Taxi: ");
Taxi retinto = new Taxi(2012, "Blanco", "Toyota");
retinto.InformacionVehiculo();
retinto.verCantidadPasajeros();
Console.WriteLine(" ");

Console.WriteLine(retinto.AsignarPiloto(pilot5));
pilot5.MostrarInformación();
pilot5.MostrarValidacion();
Console.WriteLine(" ");
Console.WriteLine(retinto.AsignarPiloto(pilot2));
pilot2.MostrarInformación();
pilot2.MostrarValidacion();
Console.WriteLine(" ");

retinto.Encender();
retinto.acelerar(100);
retinto.Frenar(20);
retinto.Apagar();
retinto.acelerar(180);
retinto.Frenar(95);
retinto.Apagar();


Console.WriteLine("----------------------------------------------------------------------\n");
Console.WriteLine("----------------------------------------------------------------------\n");
Console.WriteLine("Autobus:");
autoBus bus = new autoBus(2010, "Verde y Blanco", "Toyota");
bus.InformacionVehiculo();
bus.VerCantidadAsientos();
Console.WriteLine(" ");

Console.WriteLine(bus.AsignarPiloto(pilot1));
pilot1.MostrarInformación();
pilot1.MostrarValidacion();
Console.WriteLine(" ");

bus.Encender();
bus.acelerar(50);
bus.Frenar(20);
bus.acelerar(110);
bus.Frenar(50);
bus.Apagar();









