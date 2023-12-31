using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace DIO_C_.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y){
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y){
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

          public void Multiplicar(int x, int y){
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

          public void Dividir(int x, int y){
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

          public void Potencia(int x, int y){
            
            double pot = Math.Pow(x,y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }

          public void Seno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno, 4)}");
        }

        public void Coseno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"coseno de {angulo}° = {Math.Round(coseno, 4)}");
        }

        public void Tangente(double angulo){
            double radiano = angulo * Math.PI / 180;
            double tan = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}° = {Math.Round(tan, 4)}");
        }

        public void Raiz(double x){
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"A raiz de {x} é: {raiz}");
        }
    }
}