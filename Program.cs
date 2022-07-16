using System;

namespace T05Ejercicio1
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("¿De qué figura quieres calcular el área (Círculo/Triángulo/Cuadrado)?");
            String figura = Console.ReadLine();
            figura = figura.ToLower();
            switch (figura)
            {
                case "círculo":
                    Console.WriteLine("Escribe el radio del círculo:");
                    double radio = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("El área del círculo es: " + Circulo(radio));
                    break;
                case "triángulo":
                    Console.WriteLine("Escribe la base del triángulo:");
                    double baseTri = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Escribe ahora la altura del triángulo:");
                    double alturaTri = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("El área del triángulo es: " + Triangulo(baseTri, alturaTri));
                    break;
                case "cuadrado":
                    Console.WriteLine("Escribe el lado del cuadrado:");
                    double lado = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("El área del cuadrado es: " + Cuadrado(lado));
                    break;
                default:
                    Console.WriteLine("Lo que ha escrito es incorrecto. Es posible que se le olvidara el acento");
                    break;
            }
        }

        static double Circulo(double radio)
        {
            return Math.PI * (Math.Pow(radio, 2));
        }
        static double Triangulo(double baseTri, double alturaTri)
        {
            return (baseTri * alturaTri) / 2;
        }
        static double Cuadrado(double lado)
        {
            return lado * lado;
        }

    }
}