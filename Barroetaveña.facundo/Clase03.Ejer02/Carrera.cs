using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03.Ejer02
{
    using Autos;
    class Carrera
    {
        public Auto auto1 = new Auto();
        public Auto auto2 = new Auto();
        public Auto auto3 = new Auto();
        public Auto auto4 = new Auto();
        public Auto auto5 = new Auto();
        public Auto auto6 = new Auto();
        public Random rnd = new Random();

        public string MostrarCarrera()
        {
            return auto1.MostrarAuto() + " - " + auto1.getKilometrosRecorridos() + "\n\n" + auto2.MostrarAuto() + " - " + auto2.getKilometrosRecorridos() + "\n\n" + auto3.MostrarAuto() + " - " + auto1.getKilometrosRecorridos() + "\n\n" + auto4.MostrarAuto() + " - " + auto1.getKilometrosRecorridos() + "\n\n" + auto5.MostrarAuto() + " - " + auto1.getKilometrosRecorridos() + "\n\n" + auto6.MostrarAuto()+ " - " + auto1.getKilometrosRecorridos() ;
        }

        public void PorTiempo(int minutos)
        {
            auto1.setKilometrosRecorridos(rnd.Next(20, 70));
            auto2.setKilometrosRecorridos(rnd.Next(20, 70));
            auto3.setKilometrosRecorridos(rnd.Next(20, 70));
            auto4.setKilometrosRecorridos(rnd.Next(20, 70));
            auto5.setKilometrosRecorridos(rnd.Next(20, 70));
            auto6.setKilometrosRecorridos(rnd.Next(20, 70));
        }
        
        

    }
}
