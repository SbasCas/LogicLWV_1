using System;

namespace Parcial_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Un tren sale de la estación “A” a las 10:00 AM y viaja a una velocidad constante de 80 km/h. Un segundo tren sale de la misma estación a las 11:00 AM y viaja en la misma dirección a una velocidadconstante de 100 km / h.
            //¿A qué hora el segundo tren alcanzará al primer tren? Mostrar esta hora enpantalla

            //Variables 

            double Velocidadtren1 = 80, Velocidadtren2 = 100, Horapartida1 = 10, Horapartida2 = 11, Distancia, TiempoA, HoraA;

            Distancia= Velocidadtren1 * (Horapartida2 - Horapartida1);  

            TiempoA= Distancia / (Velocidadtren2 - Velocidadtren1);

            HoraA = (Horapartida1 + TiempoA);

            Console.WriteLine("El segundo tren alcanzara al primero a las " + HoraA + ":00 horas");







            

            

        }
    }
}
