using System;

namespace EJERCICIO_IMC

{
    class Program
    {
        static void Main(string[] args)

         // - Si el IMC del paciente es menor a 18,5, entonces tiene peso insuficiente.
         // - Si el IMC está entre 18,5 y 24,9 se encuentre en la categoría de Peso Saludable
         // - Si el IMC está entre 25,0 y 29,9 entonces tiene sobrepeso
         // - Si el IMC es mayor de 29.9 entonces tiene obesidad.

         //Mostrar en pantalla la categoría de cada uno de los pacientes.La aplicación debe estar en capacidad de pedirle al usuario si quiere volver a calcular
        {
            while (true)
            {
                Console.Write("Introduzca el peso del paciente(en kg): ");
                double peso = Convert.ToDouble(Console.ReadLine());

                Console.Write("Introduzca la altura del paciente (en metros): ");
                double altura = Convert.ToDouble(Console.ReadLine());

                double imc = CalculateImc(peso, altura);
                string categoria = GetImcCategory(imc);

                Console.WriteLine($"La categoría del paciente es: {categoria}");
                Console.Write("¿Desea calcular otra IMC? (sí/no)?: ");

                if (Console.ReadLine() == "no")
                {
                    break;
                }
            }
        }

        private static double CalculateImc(double peso, double altura)
        {
            return peso / (altura * altura);
        }

        private static string GetImcCategory(double imc)
        {
            if (imc < 18.5)
            {
                return "Bajo peso";
            }
            else if (imc < 25.0)
            {
                return "Peso saludable";
            }
            else if (imc < 30.0)
            {
                return "Sobrepeso";
            }
            else
            {
                return "Obesidad";
            }
        }
    }
}