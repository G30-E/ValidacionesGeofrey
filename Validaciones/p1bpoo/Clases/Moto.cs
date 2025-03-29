using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    public class Moto : Vehiculo
    {
        public Moto(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            tiposLicenciaAceptados = new List<string> { "M" };
        }


        protected override int VelocidadMaxima { get; set; } = 120;
        protected override int CapacidadTanque { get; set; } = 10;
        protected override double ConsumoCombustible { get; set; } = 3.5;

        public void HacerCaballito()
        {
            if (velocidad > 95)
            {
                Console.WriteLine("La Moto esta haciendo golpe de gas");
            }
            else
            {
                Console.WriteLine("No se puede hacer golpe de gas si no ha llega al kilometraje necesario de 80 km/h");
            }
        }

        public override void acelerar(int cuanto)
        {
            if (velocidad + cuanto <= VelocidadMaxima)
            {
                velocidad += cuanto;
                Console.WriteLine("La Moto ha acelerado a {0} km/h.", velocidad);
            }
            else
            {
                Console.WriteLine("No se puede exceder la velocidad máxima de {0} km/h.", VelocidadMaxima);
            }
        }

        public override void Frenar(int cuanto)
        {
            if (velocidad - cuanto >= 0)
            {
                velocidad -= cuanto;
                Console.WriteLine("La moto ha frenado a {0} km/h.", velocidad);
            }
            else
            {
                Console.WriteLine("No se puede frenar más, la moto se está detenido.");
            }
        }
        public override string TipoLicencia()
        {
            return "Licencia tipo M requerida para conducir esta moto.";

        }
    }   
        
}
