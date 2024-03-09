using System;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Timers;

namespace Parcial_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Un vendedor recibe un sueldo base de $XXXX.Además, recibe una comisión del 10 % sobre el valor total de cada venta que realiza.El vendedor desea saber:
            //¿Cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el mes ?
            //¿Cuál es el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones?
            //¿Cuál fue la venta que le generó la mayor comisión?
            //¿Cuál fue el promedio de las comisiones que recibió por cada venta?

            //variables

            double sueldo,venta1, venta2, venta3, comisión, totalmes;

            Console.WriteLine("Ingrese el sueldo del vendedor");

            sueldo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresar las ventas del mes");

            venta1 = Convert.ToDouble(Console.ReadLine());
            venta2 = Convert.ToDouble(Console.ReadLine());
            venta3 = Convert.ToDouble(Console.ReadLine());

            comisión = (venta1 + venta2 + venta3) * 0.10;

            Console.WriteLine("la comision por las 3 ventas del mes es: $" + comisión);
            totalmes = sueldo + comisión;

            Console.WriteLine("El sueldo total mas comision es : $" + totalmes);


            




        }
    }
}
